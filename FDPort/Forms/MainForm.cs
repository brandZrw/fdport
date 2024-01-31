using FDPort.Class;
using FDPort.Communication;
using FDPort.DockPanel;
using FDPort.FieldModuleClass;
using FDPort.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;


namespace FDPort.Forms
{
    public partial class MainForm : Form
    {

        public Parse parse = new Parse();
        public DataRec dataRec = new DataRec();

        public CommonArea commonArea;
        public RecListDock recListDock;
        public SendCmdDock sendCmdDock;
        public SendListDock sendListDock;
        public ChartDock chartDock;

        private DeserializeDockContent deserializeDockContent;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "FDPort " + Project.Version;
            Project.mainForm = this;
            deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
            commonArea = new CommonArea();
            recListDock = new RecListDock();
            sendCmdDock = new SendCmdDock();
            sendListDock = new SendListDock();
            chartDock = new ChartDock();
            DockInit();


            Project.init();
            parse.DataBitParsed = new Parse.DataBitParse( DataBitParseOk);
            parse.DataNotBitParsed = new Parse.DataNotBitParse (DataNotBitParseOk);
            ParamInit();
            chartDock.ChartInit();
            Project.param.sendMap.CollectionChanged += sendListDock.SendMap_CollectionChanged;
        }

        private void DockInit()
        {
            commonArea.Show(dockPanel1, DockState.DockBottom);
            chartDock.Show(dockPanel1, DockState.Document);
            recListDock.Show(dockPanel1, DockState.DockRight);
            sendListDock.Show(recListDock.Pane, DockAlignment.Left, 0.7);
            sendCmdDock.Show(sendListDock.Pane, DockAlignment.Left, 0.6);
            dockPanel1.DockBottomPortion = 0.45;
            dockPanel1.DockRightPortion = 0.5;
        }

        private void ParamInit()
        {
            // 参数初始化
            Project.param.PropertyChanged += Param_PropertyChanged;
            Project.param.com = "COM1";
            Project.param.baud = "115200";
            Project.param.timeout = "20";
            Project.param.cIP = "127.0.0.1";
            Project.param.cPort = "9000";
            Project.param.sIP = "127.0.0.1";
            Project.param.sPort = "9000";
            Project.param.isLittleEndian = false;
            Project.param.portChoose = 0;
            Project.param.addTimestamp = true;
        }

        /// <summary>
        /// 非比段类型接收匹配成功
        /// </summary>
        /// <param name="name">匹配的字段名</param>
        void DataNotBitParseOk(FieldModule m)
        {
            if (Project.param.recvMap.ContainsKey(m.name))
            {
                Project.param.recvMap[m.name].Apply();
                DataParseOk(m.name);
            }
        }
        /// <summary>
        /// 比段类型接收匹配成功
        /// </summary>
        /// <param name="name">匹配的字段名</param>
        void DataBitParseOk(FieldModule m)
        {
            if (Project.param.recvMap.ContainsKey(m.name))
            {
                FieldBit bit = (FieldBit)m;
                KeyValuePair<string, FieldRecvParam> temp = Project.param.recvMap.FirstOrDefault(t => t.Key.Equals(bit.parent));
                object tempValue = temp.Value.GetValue();
                UInt64 res = bit.GetBitValue(Convert.ToDecimal(tempValue));
                Project.param.recvMap[m.name].tempValue = (decimal)res;
                Project.param.recvMap[m.name].Apply();//数据更新
                DataParseOk(m.name);
            }
        }
        /// <summary>
        /// 接收匹配成功
        /// </summary>
        /// <param name="name">匹配的字段名</param>
        void DataParseOk(string name)
        {
            FieldRecvParam rec = Project.param.recvMap[name];
            foreach (DataGridViewRow row in recListDock.recList.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == name)
                {
                    row.Cells[1].Value = rec.ShowValue();
                    if(rec.isShow)
                    {
                          chartDock.ChartAddSeries(name);
                    }
                    if(chartDock.plotData.ContainsKey(name))
                    {
                        UIControl.AddSeriesPoint(chartDock.lineChart, chartDock.plotData, name, Convert.ToDecimal(rec.GetValue()));
                    }

                }
            }
        }

        #region 参数操作
        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string localFilePath = "";
            //string localFilePath, fileNameExt, newFileName, FilePath;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "FDPort(*.FDPort)|*.FDPort";
            //设置默认文件类型显示顺序
            sfd.FilterIndex = 1;
            //保存对话框是否记忆上次打开的目录
            sfd.RestoreDirectory = true;
            //点了保存按钮进入
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径
                string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名,不带路径
                saveParam(localFilePath);
            }

        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "FDPort(*.FDPort)|*.FDPort";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                commonArea.close();
                loadParam(dialog.FileName);
                
                Project.param.sendMap.CollectionChanged -= sendListDock.SendMap_CollectionChanged;
                Project.param.sendMap.CollectionChanged += sendListDock.SendMap_CollectionChanged;
            }

        }

        /// <summary>
        /// 导入参数
        /// </summary>
        /// <param name="path"></param>
        void loadParam(string path)
        {
            recListDock.recList.Rows.Clear();
            sendListDock.sendList.Rows.Clear();
            sendCmdDock.cmdList.Rows.Clear();
            chartDock.ChartClear();
            if(Project.param.needForwarding)
            {
                Project.param.portForwarding?.Close();
            }
            Project.param.portForwarding = null;
            Project.param.needForwarding = false;

            Project.Load(path);

            

            Project.param.PropertyChanged += Param_PropertyChanged;
            switch (Project.param.portChoose)
            {
                case 1:
                    tCP服务端ToolStripMenuItem_Click(null, null);
                    break;
                case 2:
                    tCP客户端ToolStripMenuItem_Click(null, null);
                    break;
                default:
                    串口ToolStripMenuItem_Click(null, null);
                    break;

            }

            Project.param.portForwarding?.SetParam(Project.param.portForwarding.param1, Project.param.portForwarding.param2);
            if (Project.param.portForwarding != null)
            {
                端口选择ToolStripMenuItem.Text = "端口选择:" + Project.param.portForwarding.name;
            }
            是否转发ToolStripMenuItem.Checked = false;
            if (Project.param.needForwarding)// 端口转发开启就使用端口转发
            {
                Project.param.portForwarding.Open();
                if(Project.param.portForwarding.Connected())
                {
                    是否转发ToolStripMenuItem.Checked = true;
                }
            }
            Project.param.needForwarding = 是否转发ToolStripMenuItem.Checked;
            高位在前ToolStripMenuItem.Checked = !Project.param.isLittleEndian;
            低位在前ToolStripMenuItem.Checked = Project.param.isLittleEndian;
            添加时间戳ToolStripMenuItem.Checked = Project.param.addTimestamp;

            commonArea.AreaTextFresh();// 更新各个端口的文字

            foreach (CmdSend send in Project.param.cmdSend)
            {
                sendCmdDock.cmdList.Rows.Add(send.name, null, send.autoSend, send.sendTime);
            }
            foreach (KeyValuePair<string, FieldSendParam> d in Project.param.sendMap)
            {
                sendListDock.sendList.Rows.Add(d.Key, d.Value);
            }
            foreach (string d in Project.param.showRecMap)
            {
                if (Project.param.recvMap.ContainsKey(d))
                {
                    FieldRecvParam param = Project.param.recvMap[d];
                    recListDock.recList.Rows.Add(d, param.ShowValue(), param.isShow);
                    if (param.isShow)
                    {
                        chartDock.ChartAddSeries(d);
                    }
                    else
                    {
                        chartDock.ChartDelSeries(d);
                    }
                }
            }

            // 导入布局
            if (!string.IsNullOrEmpty(Project.param.layout))
            {
                if (File.Exists("tempreader.xml"))
                {
                    File.Delete("tempreader.xml");
                }
                FileStream st = new FileStream("tempreader.xml", FileMode.Create);
                StreamWriter sw = new StreamWriter(st, Encoding.Unicode);
                sw.Write(Project.param.layout);
                sw.Close();
                st.Close();

                commonArea.DockPanel = null;
                sendListDock.DockPanel = null;
                sendCmdDock.DockPanel = null;
                recListDock.DockPanel = null;
                chartDock.DockPanel = null;
                foreach (var window in dockPanel1.FloatWindows.ToList())
                    window.Dispose();
                dockPanel1.LoadFromXml("tempreader.xml", deserializeDockContent);
                File.Delete("tempreader.xml");
            }
        }

        /// <summary>
        /// 保存参数
        /// </summary>
        /// <param name="path"></param>
        void saveParam(string path)
        {
            using (MemoryStream st = new MemoryStream())
            {
                dockPanel1.SaveAsXml("temp.xml", Encoding.Unicode);
                Project.param.layout = File.ReadAllText("temp.xml", Encoding.Unicode);
                File.Delete("temp.xml");
                Project.Save(path);
            }
        }


        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(ChartDock).ToString())
                return chartDock;
            else if (persistString == typeof(CommonArea).ToString())
                return commonArea;
            else if (persistString == typeof(RecListDock).ToString())
                return recListDock;
            else if (persistString == typeof(SendCmdDock).ToString())
                return sendCmdDock;
            else if (persistString == typeof(SendListDock).ToString())
                return sendListDock;
            else
            {

                // DummyDoc overrides GetPersistString to add extra information into persistString.
                // Any DockContent may override this value to add any needed information for deserialization.

                string[] parsedStrings = persistString.Split(new char[] { ',' });
                if (parsedStrings.Length != 3)
                    return null;

                if (parsedStrings[0] != typeof(ChartDock).ToString())
                    return null;

                ChartDock dummyDoc = new ChartDock();

                return dummyDoc;
            }
        }

        // 窗口属性改变
        private void Param_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "isLittleEndian":
                    高位在前ToolStripMenuItem.Checked = !Project.param.isLittleEndian;
                    低位在前ToolStripMenuItem.Checked = Project.param.isLittleEndian;
                    break;
                case "addTimestamp":
                    添加时间戳ToolStripMenuItem.Checked = Project.param.addTimestamp;
                    break;
            }
        }


        #endregion

        #region event

        private void 串口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.param.portChoose = 0;
            commonArea.ShowCommType(Project.param.portChoose);
            串口ToolStripMenuItem.Checked = true;
            tCP服务端ToolStripMenuItem.Checked = false;
            tCP客户端ToolStripMenuItem.Checked = false;
        }
        private void tCP服务端ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.param.portChoose = 1;
            commonArea.ShowCommType(Project.param.portChoose);
            串口ToolStripMenuItem.Checked = false;
            tCP服务端ToolStripMenuItem.Checked = true;
            tCP客户端ToolStripMenuItem.Checked = false;
        }
        private void tCP客户端ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.param.portChoose = 2;
            commonArea.ShowCommType(Project.param.portChoose);
            串口ToolStripMenuItem.Checked = false;
            tCP服务端ToolStripMenuItem.Checked = false;
            tCP客户端ToolStripMenuItem.Checked = true;
        }

        private void 刷新端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonArea.FreshComList();
        }

        private void 清空配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recListDock.recList.Rows.Clear();
            sendListDock.sendList.Rows.Clear();
            sendCmdDock.cmdList.Rows.Clear();
            chartDock.ChartClear();
            Project.param = new ProjectParam();
            ParamInit();   
        }

       

        private void 单元测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitTest.GetInstance(Project.param.unitTests).Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                commonArea.close();
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        private void 开始保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!commonArea.needSave)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt(*.txt)|*.txt";
                //设置默认文件类型显示顺序
                sfd.FilterIndex = 1;
                //保存对话框是否记忆上次打开的目录
                sfd.RestoreDirectory = true;
                //点了保存按钮进入
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string dataSavePath;
                    dataSavePath = sfd.FileName.ToString(); //获得文件路径
                    commonArea.sw = File.AppendText(dataSavePath);
                    commonArea.needSave = true;
                    开始保存ToolStripMenuItem.Text = "停止保存日志";
                }

            }
            else
            {
                commonArea.needSave = false;
                开始保存ToolStripMenuItem.Text = "开始保存日志";
                commonArea.sw.Close();
            }
        }

        private void 保存图像数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "cvs(*.cvs)|*.cvs";
            //设置默认文件类型显示顺序
            sfd.FilterIndex = 1;
            //保存对话框是否记忆上次打开的目录
            sfd.RestoreDirectory = true;
            //点了保存按钮进入

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int maxLen = 0;
                DataTable dt = new DataTable();
                for(int i =0; i < chartDock.plotData.Count;i++)
                {
                    dt.Columns.Add(chartDock.plotData.ElementAt(i).Key, typeof(double));
                    if (maxLen < chartDock.plotData.ElementAt(i).Value.Count)
                    {
                        maxLen = (int)chartDock.plotData.ElementAt(i).Value.Count;
                    }
                }
                for (int i = 0; i < maxLen; i++)
                {
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(dr);
                }

                for (int i = 0; i < chartDock.plotData.Count; i++)
                {
                    KeyValuePair<string, PlotPoints> pairs = chartDock.plotData.ElementAt(i);
                    for (int j = 0 ; j < pairs.Value.points.Count; j++)
                    {
                        //int x = (int)key.Points[i].YValues[0];
                        //dt.Rows[(int)key.Points[i].XValue - 1][key.Name] = x;
                        dt.Rows[j + (maxLen - pairs.Value.points.Count)][pairs.Key] = pairs.Value[j];
                    }
                }

                common.SaveDataTableCSV(sfd.FileName.ToString(), dt);
            }
        }

        private void 接收协议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Protocols.GetInstance().Show();
        }


        private void 添加时间戳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            添加时间戳ToolStripMenuItem.Checked = !添加时间戳ToolStripMenuItem.Checked;
            Project.param.addTimestamp = 添加时间戳ToolStripMenuItem.Checked;
        }
        private void 高位在前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            高位在前ToolStripMenuItem.Checked = true;
            低位在前ToolStripMenuItem.Checked = false;
            Project.param.isLittleEndian = false;
        }
        private void 低位在前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            高位在前ToolStripMenuItem.Checked = false;
            低位在前ToolStripMenuItem.Checked = true;
            Project.param.isLittleEndian = true;
        }
        

        private void 端口选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPort newPort = NewPort.GetInstance();
            newPort.OnPortOpenOk = new NewPort.PortOpenOkCb( NewPort_OnPortOpenOk);
            newPort.Show();
        }

        private void NewPort_OnPortOpenOk(PortBase port)
        {
            是否转发ToolStripMenuItem.Checked = true;
            端口选择ToolStripMenuItem.Text = "端口:" + port.name;
        }

        private void 是否转发ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(是否转发ToolStripMenuItem.Checked)
            {
                Project.param.portForwarding.Close();
                是否转发ToolStripMenuItem.Checked = false;
                Project.param.needForwarding = false;
            }
            else
            {
                
                if(Project.param.portForwarding == null)
                {
                    MessageBox.Show("请先选择端口");
                }
                else
                {
                    Project.param.portForwarding.Open();
                    是否转发ToolStripMenuItem.Checked = true;
                    Project.param.needForwarding = true;
                }
            }
        }
        private void 还原界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockInit();
        }
        #endregion


    }
}
