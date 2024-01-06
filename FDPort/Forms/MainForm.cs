using FDPort.Class;
using FDPort.DockPanel;
using FDPort.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
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
            
            commonArea.Show(dockPanel1,DockState.DockBottom);
            chartDock.Show(dockPanel1, DockState.Document);
            
            recListDock.Show(dockPanel1, DockState.DockRight);
            
            sendListDock.Show(recListDock.Pane,DockAlignment.Left,0.7);
            sendCmdDock.Show(sendListDock.Pane, DockAlignment.Left, 0.6);
            dockPanel1.DockBottomPortion = 0.45;
            dockPanel1.DockRightPortion = 0.5;
            Project.init();
            parse.dataIsParse += DataParseOk;
           
            ParamInit();
            chartDock.chart_init();
            Project.param.sendMap.CollectionChanged += sendListDock.SendMap_CollectionChanged;
            
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
            Project.param.recHex = true;
            Project.param.recUI = true;
            Project.param.sendHex = true;
            Project.param.setUI = true;
            Project.param.chartUI = true;
            Project.param.cmdUI = true;
            Project.param.configUI = true;
            Project.param.addTimestamp = true;
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
                    if (rec.isShow)
                    {
                        chartDock.chart_add_point(name, Convert.ToDecimal(rec.GetValue()));
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
            chartDock.chart_clear();

            Project.load(path);

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
                        chartDock.chart_add_series(d);
                    }
                    else
                    {
                        chartDock.chart_del_series(d);
                    }
                }
            }
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
        void saveParam(string path)
        {
            using (MemoryStream st = new MemoryStream())
            {
                dockPanel1.SaveAsXml("temp.xml", Encoding.Unicode);
                Project.param.layout = File.ReadAllText("temp.xml", Encoding.Unicode);
                File.Delete("temp.xml");
                Project.save(path);
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
            chartDock.chart_clear();
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
                int maxlen = 0;
                DataTable dt = new DataTable();
                foreach (Series key in chartDock.LineChart.Series)
                {
                    dt.Columns.Add(key.Name, typeof(int));
                    if (maxlen < key.Points.Count)
                    {
                        maxlen = (int)key.Points.Count;
                    }
                }
                for (int i = 0; i < maxlen; i++)
                {
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(dr);
                }

                foreach (Series key in chartDock.LineChart.Series)
                {
                    for (int i = 0; i < key.Points.Count; i++)
                    {
                        int x = (int)key.Points[i].YValues[0];
                        dt.Rows[(int)key.Points[i].XValue - 1][key.Name] = x;
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
#endregion
    }
}
