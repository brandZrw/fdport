using DynamicExpresso;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using FDPort.Class;
using FDPort.Forms;
using FDPort.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static FDPort.Class.AsyncTCPClient;
using UIControl = FDPort.Logic.UIControl;

namespace FDPort.Forms
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Parse parse;
        private bool needSave = false; // 是否需要保存数据
        public DataRec dataRec = new DataRec(); // 数据接收类
        System.Windows.Forms.Timer sendTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.Text = "FDPort " + Project.Version;
            串口ToolStripMenuItem_Click(null, new EventArgs());
            GetComList();
            Project.init();
            Project.mainForm = this;
            if (cmbPort.Items.Count > 0)
            {
                cmbPort.SelectedIndex = 0;
            }
            baudCombo.SelectedIndex = 3;

            chart_init();

            sendList.Columns[0].Width = (int)(0.5 * sendList.Width);
            sendList.Columns[1].Width = (int)(0.49 * sendList.Width);

            recList.Columns[0].Width = (int)(0.42 * recList.Width);
            recList.Columns[1].Width = (int)(0.42 * recList.Width);
            recList.Columns[2].Width = (int)(0.15 * recList.Width);

            parse = new Parse();
            parse.dataIsParse += DataParseOk;
            dataRec.dataDealFunc += recData;

            // 数据绑定

            cmbPort.DataBindings.Add("Text", Project.param, "com");
            baudCombo.DataBindings.Add("Text", Project.param, "baud");
            tcpTimeout.DataBindings.Add("Text", Project.param, "timeout");
            tcpCliIP.DataBindings.Add("Text", Project.param, "cIP");
            tcpCliPort.DataBindings.Add("Text", Project.param, "cPort");
            serIP.DataBindings.Add("Text", Project.param, "sIP");
            serPort.DataBindings.Add("Text", Project.param, "sPort");
            ParamInit();
            Project.param.sendMap.CollectionChanged += SendMap_CollectionChanged;

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
            foreach (DataGridViewRow row in recList.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == name)
                {
                    row.Cells[1].Value = rec.ShowValue();
                    if (rec.isShow)
                    {
                        chart_add_point(name, Convert.ToDecimal(rec.GetValue()));
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
                Project.param.sendMap.CollectionChanged -= SendMap_CollectionChanged;
                Project.param.sendMap.CollectionChanged += SendMap_CollectionChanged;
            }
        }

        /// <summary>
        /// 导入参数
        /// </summary>
        /// <param name="path"></param>
        void loadParam(string path)
        {
            recList.Rows.Clear();
            sendList.Rows.Clear();
            cmdList.Rows.Clear();
            chart_clear();

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
            收发配置ToolStripMenuItem.Checked = Project.param.configUI;
            曲线ToolStripMenuItem.Checked = Project.param.chartUI;
            命令ToolStripMenuItem.Checked = Project.param.cmdUI;
            设置参数ToolStripMenuItem.Checked = Project.param.setUI;
            接收参数ToolStripMenuItem.Checked = Project.param.recUI;
            高位在前ToolStripMenuItem.Checked = !Project.param.isLittleEndian;
            低位在前ToolStripMenuItem.Checked = Project.param.isLittleEndian;
            添加时间戳ToolStripMenuItem.Checked = Project.param.addTimestamp;

            cmbPort.Text = Project.param.com;
            baudCombo.Text = Project.param.baud;
            tcpTimeout.Text = Project.param.timeout;
            tcpCliIP.Text = Project.param.cIP;
            tcpCliPort.Text = Project.param.cPort;
            serIP.Text = Project.param.sIP;
            serPort.Text = Project.param.sPort;

            foreach (CmdSend send in  Project.param.cmdSend)
            {
                cmdList.Rows.Add(send.name, null, send.autoSend, send.sendTime);
            }
            foreach (KeyValuePair<string, FieldSendParam> d in Project.param.sendMap)
            {
                sendList.Rows.Add(d.Key, d.Value);
            }
            foreach (string d in Project.param.showRecMap)
            {
                if (Project.param.recvMap.ContainsKey(d))
                {
                    FieldRecvParam param = Project.param.recvMap[d];
                    recList.Rows.Add(d, param.ShowValue(), param.isShow);
                    if (param.isShow)
                    {
                        chart_add_series(d);
                    }
                    else
                    {
                        chart_del_series(d);
                    }
                }
            }
        }

        // 窗口属性改变
        private void Param_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "configUI":
                    收发配置ToolStripMenuItem.Checked = Project.param.configUI;
                    break;
                case "chartUI":
                    曲线ToolStripMenuItem.Checked = Project.param.chartUI;
                    break;
                case "cmdUI":
                    命令ToolStripMenuItem.Checked = Project.param.cmdUI;
                    break;
                case "setUI":
                    设置参数ToolStripMenuItem.Checked = Project.param.setUI;
                    break;
                case "recUI":
                    接收参数ToolStripMenuItem.Checked = Project.param.recUI;
                    break;
                case "isLittleEndian":
                    高位在前ToolStripMenuItem.Checked = !Project.param.isLittleEndian;
                    低位在前ToolStripMenuItem.Checked = Project.param.isLittleEndian;
                    break;
                case "addTimestamp":
                    添加时间戳ToolStripMenuItem.Checked = Project.param.addTimestamp;
                    break;
            }
        }

        void saveParam(string path)
        {
            Project.save(path);
        }
        #endregion

        #region 界面逻辑

        #region recList

        private void recList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (e.RowIndex < Project.param.showRecMap.Count)
            {
                Project.param.showRecMap.Remove(Project.param.showRecMap.ElementAt(e.RowIndex));
            }
        }
        private void recList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)// 改数值
            {
                if ((bool)recList.Rows[e.RowIndex].Cells[2].EditedFormattedValue == false)
                {
                    //选中改为不选中
                    if (Project.param.recvMap.ContainsKey(Project.param.showRecMap.ElementAt(e.RowIndex)))
                    {
                        FieldRecvParam m = Project.param.recvMap[Project.param.showRecMap.ElementAt(e.RowIndex)];
                        m.isShow = false;
                        // 删除曲线
                        chart_del_series(Project.param.showRecMap.ElementAt(e.RowIndex));
                    }
                }
                else
                {
                    // 添加曲线
                    chart_add_series(Project.param.showRecMap.ElementAt(e.RowIndex));
                    //不选中改为选中
                    FieldRecvParam m = Project.param.recvMap[Project.param.showRecMap.ElementAt(e.RowIndex)];
                    m.isShow = true;
                }
            }
        }
        private void recList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 0) // 改名字
                {
                    if (e.RowIndex >= Project.param.showRecMap.Count)
                    {
                        object t = recList.Rows[e.RowIndex].Cells[0].Value;
                        string s;
                        if (t == null)
                        {
                            s = null;
                        }
                        else
                        {
                            s = t.ToString();
                        }

                        Project.param.showRecMap.Add(s);
                    }
                    else
                    {
                        Project.param.showRecMap[e.RowIndex] = (string)recList.Rows[e.RowIndex].Cells[0].Value;
                    }
                }
            }
        }
        public void RecList_AddRow(KeyValuePair<string, FieldRecvParam> pair)
        {
            Project.param.showRecMap.Add(pair.Key);
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell textcell = new DataGridViewTextBoxCell();
            textcell.Value = pair.Key;
            row.Cells.Add(textcell);
            DataGridViewTextBoxCell textcell2 = new DataGridViewTextBoxCell();
            textcell2.Value = pair.Value.ShowValue();
            row.Cells.Add(textcell2);
            recList.Rows.Add(row);

        }
        #endregion

        #region sendList

        public void SendList_Change(int row, string value)
        {
            sendList.Rows[row].Cells[1].Value = value;
        }

        private void SendMap_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
            {
                KeyValuePair<string, FieldSendParam> pair = (KeyValuePair<string, FieldSendParam>)e.NewItems[0];
                sendList.Rows[e.NewStartingIndex].Cells[0].Value = pair.Key;
                sendList.Rows[e.NewStartingIndex].Cells[1].Value = pair.Value.ToString();
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                KeyValuePair<string, FieldSendParam> pair = (KeyValuePair<string, FieldSendParam>)e.NewItems[0];
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell textcell = new DataGridViewTextBoxCell();
                textcell.Value = pair.Key;
                row.Cells.Add(textcell);
                DataGridViewTextBoxCell textcell2 = new DataGridViewTextBoxCell();
                textcell2.Value = pair.Value.ToString();
                row.Cells.Add(textcell2);
                sendList.Rows.Add(row);
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                sendList.Rows.RemoveAt(e.OldStartingIndex);
            }
        }

        private void sendList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Project.param.sendMap.CollectionChanged -= SendMap_CollectionChanged;
            if (e.RowIndex < Project.param.sendMap.Count)
            {
                string s = Project.param.sendMap.Keys.ElementAt(e.RowIndex);
                if (Project.param.sendMap.ContainsKey(s))
                {
                    Project.param.sendMap.Remove(s);
                }
            }
            Project.param.sendMap.CollectionChanged += SendMap_CollectionChanged;
        }

        private void sendList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Project.param.sendMap.CollectionChanged -= SendMap_CollectionChanged;
            try
            {
                if (e.ColumnIndex == 0) // 更改名称
                {
                    if (e.RowIndex >= Project.param.sendMap.Count)// 增加
                    {
                        string s = (string)sendList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (Project.param.sendMap.ContainsKey(s))
                        {
                            sendList.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            Project.param.sendMap.Add(s, new FieldSendParam("0"));
                        }
                    }
                    else // 更改
                    {
                        string key = Project.param.sendMap.ElementAt(e.RowIndex).Key;
                        string newKey = (string)sendList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        Dictionary<string, FieldSendParam> temp = Project.param.sendMap.ToDictionary(k => k.Key == key ? newKey : k.Key, k => k.Value);
                        Project.param.sendMap.Clear();
                        foreach (KeyValuePair<string, FieldSendParam> k in temp)
                        {
                            Project.param.sendMap.Add(k.Key, k.Value);
                        }
                    }
                }
                else if (e.ColumnIndex == 1) // 更改数值
                {
                    if (e.RowIndex >= Project.param.sendMap.Count)// 增加
                    {
                        Project.param.sendMap.Add(" ", new FieldSendParam((string)sendList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
                    }
                    else // 更改
                    {
                        string key = Project.param.sendMap.ElementAt(e.RowIndex).Key;
                        Project.param.sendMap[key].setStrValue((string)sendList.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue);
                    }
                }
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
            finally
            {
                Project.param.sendMap.CollectionChanged += SendMap_CollectionChanged;
            }

            //parse.cmd_send_upgrade();

        }
        #endregion

        #region cmdList

        private void cmdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.RowIndex >= Project.param.cmdSend.Count) // 新增
                {
                    CmdSendStruct cmdStruct = new CmdSendStruct();
                    cmdStruct.Show();
                }
                else
                {
                    CmdSendStruct cmdStruct = new CmdSendStruct(e.RowIndex);
                    cmdStruct.Show();
                }
            }
        }
        public System.Windows.Forms.DataGridView getCmdList()
        {
            return cmdList;
        }

        private void cmdList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (e.RowIndex < Project.param.cmdSend.Count)
            {
                Project.param.cmdSend.RemoveAt(e.RowIndex);
            }
        }

        private void cmdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //点击button按钮事件
            if (cmdList.Columns[e.ColumnIndex].Name == "cmdSend" && Project.param.cmdSend.Count > 0 && e.RowIndex >= 0 && e.RowIndex < Project.param.cmdSend.Count)
            {
                //说明点击的列是DataGridViewButtonColumn列
                Project.param.cmdSend[e.RowIndex].Send();
                //parse.sendCmd(((CmdObj)parse.cmdObjs[e.RowIndex]), 高位在前ToolStripMenuItem.Checked);
                //if (((CmdObj)parse.cmdObjs[e.RowIndex]).timerNeed)
                //{
                //    if (((CmdObj)parse.cmdObjs[e.RowIndex]).timerIsStart == false)
                //    {
                //        ((CmdObj)parse.cmdObjs[e.RowIndex]).cmdTimer.Start();
                //    }
                //}
            }
            else if (cmdList.Columns[e.ColumnIndex].Name == "cmdTimer" && Project.param.cmdSend.Count > 0 && e.RowIndex >= 0 && e.RowIndex < Project.param.cmdSend.Count)
            {
                //说明点击的列是DataGridViewButtonColumn列
                cmdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(bool)cmdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                Project.param.cmdSend[e.RowIndex].autoSend = (bool)cmdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }


        #endregion

        #region  曲线操作

        private void chart_init()
        {
            //option.ToolTip.Visible = true;
            //option.Title = null;
            //option.XAxis.AxisLabel.DecimalCount = 1;
            //option.XAxis.AxisLabel.AutoFormat = false;
            //option.YAxis.AxisLabel.DecimalCount = 1;
            //option.YAxis.AxisLabel.AutoFormat = false;
            //option.Grid.Bottom = 30;
            //option.Grid.Top = 30;
            //option.Grid.Left = 30;
            //option.Grid.Right = 30;
            //option.XAxis.Min = 0;
            //option.XAxis.Max = 220;
            //option.XAxis.MaxAuto = false;
            //option.XAxis.MinAuto = false;
            //LineChart.SetOption(option);
        }
        private void LineChart_MouseEnter(object sender, EventArgs e)
        {
            MouseWheel += new MouseEventHandler(chart1_MouseEnter);//调用滚轮事件
        }
        private void chart_add_series(string name)
        {
            if (LineChart.Series.IndexOf(name) < 0)
            {
                Series ser = new Series(name);
                ser.ChartType = SeriesChartType.Line;
                LineChart.Series.Add(ser);
            }
        }
        private void chart_del_series(string str)
        {
            if (LineChart.Series.IndexOf(str) >= 0)
            {
                Series series = LineChart.Series[str];
                LineChart.Series.Remove(series);
            }
        }
        private void chart_add_point(string str, decimal value)
        {
            if (LineChart.Series.IndexOf(str) >= 0)
            {
                chart_add_series(str);
            }
            Series series = LineChart.Series[str];
            if (series != null)
            {
                UIControl.AddSeriesPoint(LineChart, str, value);
            }
        }

        private void chart_clear()
        {
            foreach (Series series in LineChart.Series)
            {
                series.Points.Clear();
            }
            UIControl.SeriesClear();
            LineChart.ChartAreas[0].AxisX.Minimum = 0;
            LineChart.ChartAreas[0].AxisX.Maximum = 220;
            LineChart.Refresh();
        }

        private void chart1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)//鼠标向上
            {
                if (UIControl.index > 200 && UIControl.index > UIControl.show)
                {
                    UIControl.show += 1;
                    LineChart.ChartAreas[0].AxisX.Maximum += 1;
                    LineChart.ChartAreas[0].AxisX.Minimum += 1;
                }
            }
            else//鼠标向下滚动
            {
                if (UIControl.index > 200 && UIControl.show > 200)
                {
                    UIControl.show -= 1;
                    LineChart.ChartAreas[0].AxisX.Maximum -= 1;
                    LineChart.ChartAreas[0].AxisX.Minimum -= 1;
                }
            }
            LineChart.Refresh();
        }

        private void 移至开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIControl.show = 0;
            LineChart.ChartAreas[0].AxisX.Minimum = 0;
            LineChart.ChartAreas[0].AxisX.Maximum = 220;
        }
        private void 移至最新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIControl.show = UIControl.index;
        }
        private void 缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LineChart.ZoomBack();
        }
        private void 正常大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LineChart.ZoomNormal();
        }
        #endregion

        private void baudCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project.param.baud = baudCombo.Text;
        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project.param.com = cmbPort.Text;
        }

        private void 单元测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnitTest(Project.param.unitTests).Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (tcpClient != null)
                {
                    tcpClient.Stop();
                }
                if (tcpServer != null)
                {
                    tcpServer.Stop();
                }
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        private void 开始保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!needSave)
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
                    sw = File.AppendText(dataSavePath);
                    needSave = true;
                    开始保存ToolStripMenuItem.Text = "停止保存日志";
                }

            }
            else
            {
                needSave = false;
                开始保存ToolStripMenuItem.Text = "开始保存日志";
                sw.Close();
            }
        }
        /// 将DataTable中数据写入到CSV文件中
        /// </summary>
        /// <param name="dt">提供保存数据的DataTable</param>
        /// <param name="fileName">CSV的文件路径</param>
        public void SaveDataTableCSV(string path, DataTable dt)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            StringBuilder sb = new StringBuilder();
            fs.SetLength(0);
            sb.Clear();

            //写出列名称
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sb.Append(dt.Columns[i].ColumnName.ToString());
                if (i < dt.Columns.Count - 1)
                {
                    sb.Append("\t");
                }
            }
            sw.WriteLine(sb.ToString());

            //写出各行数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.Clear();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    sb.Append(dt.Rows[i][j].ToString());
                    if (j < dt.Columns.Count - 1)
                    {
                        sb.Append("\t");
                    }
                }
                sw.WriteLine(sb.ToString());
            }

            sw.Close();
            fs.Close();
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
                foreach (Series key in LineChart.Series)
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

                foreach (Series key in LineChart.Series)
                {
                    for (int i = 0; i < key.Points.Count; i++)
                    {
                        int x = (int)key.Points[i].YValues[0];
                        dt.Rows[(int)key.Points[i].XValue - 1][key.Name] = x;
                    }
                }

                SaveDataTableCSV(sfd.FileName.ToString(), dt);
            }
        }

        // 发送按钮
        private void button2_Click(object sender, EventArgs e)
        {
            string hex = sendBox.Text.Trim(' ');
            if (string.IsNullOrEmpty(hex))
            {
                return;
            }
            string[] hexarray = hex.Split(' ');
            List<byte> bs = new List<byte>();
            try
            {
                foreach (string a in hexarray)
                {
                    bs.Add(Convert.ToByte(a, 16));
                }
                sendData(bs.ToArray());
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        // 清空接收
        private void Clear_Click(object sender, EventArgs e)
        {
            UIControl.ClearTextBoxValue(recBox);
        }

        private void 接收协议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Protocols().Show();
        }

        private void tcpTimeout_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tcpTimeout.Text))
            {
                return;
            }
            dataRec.set_timeout(Convert.ToUInt32(tcpTimeout.Text));
        }
        private void tcpCliIP_TextChanged(object sender, EventArgs e)
        {
            Project.param.cIP = tcpCliIP.Text;
        }

        private void tcpCliPort_TextChanged(object sender, EventArgs e)
        {
            Project.param.cPort = tcpCliPort.Text;
        }

        private void serIP_TextChanged(object sender, EventArgs e)
        {
            Project.param.sIP = serIP.Text;
        }

        private void serPort_TextChanged(object sender, EventArgs e)
        {
            Project.param.sPort = serPort.Text;
        }

        #region 界面配置

        private void 清空图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart_clear();
        }

        private void 清空配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recList.Rows.Clear();
            sendList.Rows.Clear();
            cmdList.Rows.Clear();
            chart_clear();
            Project.param = new ProjectParam();
            ParamInit();
        }

        private void 串口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.param.portChoose = 0;
            serialPanel.Visible = true;
            socketSerPanel.Visible = false;
            socketCliPanel.Visible = false;
            串口ToolStripMenuItem.Checked = true;
            tCP服务端ToolStripMenuItem.Checked = false;
            tCP客户端ToolStripMenuItem.Checked = false;
        }
        private void tCP服务端ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.param.portChoose = 1;
            serialPanel.Visible = false;
            socketSerPanel.Visible = true;
            socketCliPanel.Visible = false;
            串口ToolStripMenuItem.Checked = false;
            tCP服务端ToolStripMenuItem.Checked = true;
            tCP客户端ToolStripMenuItem.Checked = false;
        }
        private void tCP客户端ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.param.portChoose = 2;
            serialPanel.Visible = false;
            socketSerPanel.Visible = false;
            socketCliPanel.Visible = true;
            串口ToolStripMenuItem.Checked = false;
            tCP服务端ToolStripMenuItem.Checked = false;
            tCP客户端ToolStripMenuItem.Checked = true;
        }

        private void menuUpdata(object sender, EventArgs e)
        {
            int x = 200;
            if (!曲线ToolStripMenuItem.Checked)
            {
                x -= 100;
                tableLayoutPanel1.ColumnStyles[0].Width = 0;
            }
            if (!命令ToolStripMenuItem.Checked)
            {
                x -= 50;
                tableLayoutPanel1.ColumnStyles[1].Width = 0;
            }
            if (!设置参数ToolStripMenuItem.Checked)
            {
                x -= 25;
                tableLayoutPanel1.ColumnStyles[2].Width = 0;
            }
            if (!接收参数ToolStripMenuItem.Checked)
            {
                x -= 25;
                tableLayoutPanel1.ColumnStyles[3].Width = 0;
            }
            if (x == 0)
            {
                splitContainer1.Panel1Collapsed = true;
                return;
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
            }

            if (曲线ToolStripMenuItem.Checked)
            {
                tableLayoutPanel1.ColumnStyles[0].Width = tableLayoutPanel1.Width * 100 / x;
            }
            if (命令ToolStripMenuItem.Checked)
            {
                tableLayoutPanel1.ColumnStyles[1].Width = tableLayoutPanel1.Width * 50 / x;
            }
            if (设置参数ToolStripMenuItem.Checked)
            {
                tableLayoutPanel1.ColumnStyles[2].Width = tableLayoutPanel1.Width * 25 / x;
            }
            if (接收参数ToolStripMenuItem.Checked)
            {
                tableLayoutPanel1.ColumnStyles[3].Width = tableLayoutPanel1.Width * 25 / x;
            }

        }

        private void cmdList_Resize(object sender, EventArgs e)
        {
            cmdList.Columns[0].Width = (int)(0.3 * cmdList.Width);
            cmdList.Columns[1].Width = (int)(0.3 * cmdList.Width);
            cmdList.Columns[2].Width = (int)(0.2 * cmdList.Width);
            cmdList.Columns[3].Width = (int)(0.2 * cmdList.Width);

        }
        private void sendList_Resize(object sender, EventArgs e)
        {
            sendList.Columns[0].Width = (int)(0.5 * sendList.Width);
            sendList.Columns[1].Width = (int)(0.49 * sendList.Width);
        }

        private void recList_Resize(object sender, EventArgs e)
        {
            recList.Columns[0].Width = (int)(0.4 * recList.Width);
            recList.Columns[1].Width = (int)(0.3 * recList.Width);
            recList.Columns[2].Width = (int)(0.3 * recList.Width);
        }

        private void 收发配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (收发配置ToolStripMenuItem.Checked)
            {
                收发配置ToolStripMenuItem.Checked = false;
                splitContainer1.Panel2Collapsed = true;
            }
            else
            {
                收发配置ToolStripMenuItem.Checked = true;
                splitContainer1.Panel2Collapsed = false;
            }
            Project.param.configUI = 收发配置ToolStripMenuItem.Checked;
        }
        private void 曲线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            曲线ToolStripMenuItem.Checked = !曲线ToolStripMenuItem.Checked;
            Project.param.chartUI = 曲线ToolStripMenuItem.Checked;

        }
        private void 命令ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            命令ToolStripMenuItem.Checked = !命令ToolStripMenuItem.Checked;
            Project.param.cmdUI = 命令ToolStripMenuItem.Checked;
        }
        private void 设置参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            设置参数ToolStripMenuItem.Checked = !设置参数ToolStripMenuItem.Checked;
            Project.param.setUI = 设置参数ToolStripMenuItem.Checked;
        }

        private void 接收参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            接收参数ToolStripMenuItem.Checked = !接收参数ToolStripMenuItem.Checked;
            Project.param.recUI = 接收参数ToolStripMenuItem.Checked;
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

        #endregion

        #region 数据匹配
        private int recData(byte[] vs, int len)
        {

            string bs = byteArrayToString(vs, len);
            StringBuilder sb = new StringBuilder();
            if (Project.param.addTimestamp)
            {
                sb.Append(DateTime.Now.ToString("HH:mm:ss.fff"));
            }
            sb.Append("收:");
            sb.Append(bs);
            UIControl.AddTextBoxValue(recBox, sb.ToString());
            if (needSave)
            {
                writeFile(sb.ToString());
            }

            return parse.dataParsing(vs, len);

        }

        #endregion

        #region 端口选择

        #region TCP相关


        AsyncSocketTCPServer tcpServer;
        AsyncTCPClient tcpClient;
        #region tcp服务器
        // 服务端
        private void uiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (uiButton3.Text.Equals("侦听"))
                {

                    IPAddress ip;
                    if (IPAddress.TryParse(serIP.Text, out ip))
                    {
                        tcpServer = new AsyncSocketTCPServer(ip, Convert.ToInt32(serPort.Text), 1024);
                        tcpServer.DataReceived += TcpServer_DataReceived;
                        tcpServer.Start();
                        uiButton3.Text = "断开";

                    }
                    else
                    {
                        throw new Exception("非法IP");
                    }

                }
                else if (uiButton3.Text.Equals("断开"))
                {
                    //
                    if (tcpServer != null)
                    {
                        tcpServer.Stop();
                    }
                    uiButton3.Text = "侦听";
                }
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        private void TcpServer_DataReceived(object sender, AsyncSocketEventArgs e)
        {
            byte[] b = e._state.RecvDataBuffer.Take(e._state.recvLen).ToArray();
            dataRec.Rec(b, e._state.recvLen);
        }
        #endregion
        //客户端
        private void uiButton5_Click(object sender, EventArgs e)
        {
            if (uiButton5.Text.Equals("连接"))
            {
                IPAddress ip;
                try
                {
                    if (IPAddress.TryParse(tcpCliIP.Text, out ip))
                    {
                        tcpClient = new AsyncTCPClient(ip, Convert.ToInt32(tcpCliPort.Text));
                        tcpClient.ConnectedChanged += TcpClient_ConnectedChanged;
                        tcpClient.dataReceived += TCP_DataRecv;
                        tcpClient.Start();
                    }
                    else
                    {
                        throw new Exception("非法IP");
                    }
                }
                catch (Exception exp)
                {
                    System.Windows.Forms.MessageBox.Show(exp.Message);
                }
            }
            else
            {
                if (tcpClient != null)
                {
                    tcpClient.Stop();
                }
            }

        }
        private void TCP_DataRecv(byte[] vs, int len)
        {
            dataRec.Rec(vs, len);
        }
        private void TcpClient_ConnectedChanged(object sender, ConnctedChangedArg e)
        {
            if (e.Connected)
            {
                UIControl.SetText(uiButton5, "断开");
            }
            else
            {
                UIControl.SetText(uiButton5, "连接");
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            button2_Click(null, new EventArgs());
        }
        private void uiButton6_Click(object sender, EventArgs e)
        {
            button2_Click(null, new EventArgs());
        }

        #endregion

        #region 串口操作

        /// <summary>
        /// 从注册表获取系统串口列表
        /// </summary>
        public void GetComList()
        {
            Microsoft.Win32.RegistryKey keyCom = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (keyCom != null)
            {
                string[] sSubKeys = keyCom.GetValueNames();
                string[] str = new string[sSubKeys.Length];
                for (int i = 0; i < sSubKeys.Length; i++)
                {
                    str[i] = (string)keyCom.GetValue(sSubKeys[i]);
                }
                cmbPort.Items.Clear();
                for (int i = 0; i < str.Length; i++)
                {
                    cmbPort.Items.Add(str[i]);
                }
            }

        }
        bool isReceiving = false;/*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
        /// <summary>
        /// 开关串口
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {

                cmbPort.Enabled = true;
                baudCombo.Enabled = true;
                button1.Text = "打开串口";

                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();

                while (isReceiving)
                {
                    Application.DoEvents();
                }
                serialPort.Close();

            }
            else
            {
                try
                {
                    serialPort.PortName = cmbPort.Text;
                    serialPort.BaudRate = Convert.ToInt32(baudCombo.Text);
                    serialPort.Open();
                    isReceiving = false;
                    cmbPort.Enabled = false;
                    baudCombo.Enabled = false;
                    //serialPort.ReadTimeout = -1;
                    button1.Text = "关闭串口";
                }
                catch (Exception exp)
                {
                    System.Windows.Forms.MessageBox.Show(exp.Message);
                }

            }
        }
        UartMore um;
        private void uart_more_Click(object sender, EventArgs e)
        {
            um = new UartMore(serialPort);

            um.TopMost = true;
            um.TopMost = false;

            um.ShowDialog();
            if (serialPort.IsOpen) //如果串口已经打开
            {
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();

                while (isReceiving)
                {
                    Application.DoEvents();
                }
                serialPort.Close();
                serialPort.Open();//重新打开串口
            }
        }
        string byteArrayToString(byte[] vs, int len)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                sb.Append(vs[i].ToString("X2"));
                sb.Append(' ');
            }
            sb.AppendLine();
            return sb.ToString();
        }
        StreamWriter sw;
        void writeFile(string data)
        {
            sw.Write(data);
        }
        /**
         *  数据接收
         */
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                int len = serialPort.BytesToRead;

                if (len <= 0)
                {
                    return;
                }
                byte[] vs = new byte[len];
                serialPort.Read(vs, 0, len);
                dataRec.Rec(vs, len);
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
            finally
            {
                isReceiving = false;/*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
            }
        }

        private void 刷新端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectStr = cmbPort.Text;
            GetComList();
            if (cmbPort.Items.Contains(selectStr) == false)
            {
                if (cmbPort.Items.Count > 0)
                {
                    cmbPort.SelectedIndex = 0;
                }
                else
                {
                    cmbPort.SelectedIndex = -1;
                }
            }
            else
            {
                cmbPort.Text = selectStr;
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="vs"></param>
        public void sendData(byte[] vs)
        {
            switch (Project.param.portChoose)
            {
                case 0:
                    if (serialPort.IsOpen)
                    {
                        serialPort?.Write(vs, 0, vs.Length);
                    }
                    break;
                case 1:
                    tcpServer?.SendAll(vs);
                    break;
                case 2:
                    tcpClient?.Send(vs);
                    break;
            }


            string bs = byteArrayToString(vs, vs.Length);
            StringBuilder sb = new StringBuilder();
            if (Project.param.addTimestamp) // 启用时间戳
            {
                sb.Append(DateTime.Now.ToString("HH:mm:ss.fff"));
            }
            sb.Append("发:");
            sb.Append(bs);
            UIControl.AddTextBoxValue(recBox, sb.ToString());//发送窗口显示
            if (needSave)
            {
                writeFile(sb.ToString());
            }

        }




        #endregion

        #endregion


        /*************sendlist******************/
        private void uiContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (sendList.SelectedRows[0].Index > -1)
            {
                十六进制ToolStripMenuItem1.Checked = Project.param.sendMap[(string)sendList.Rows[sendList.SelectedRows[0].Index].Cells[0].Value].isHex;
            }
        }

        private void 十六进制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sendList.SelectedRows[0].Index > -1)
            {
                十六进制ToolStripMenuItem1.Checked = !十六进制ToolStripMenuItem1.Checked;
                sendList.Rows[sendList.SelectedRows[0].Index].Cells[1].Value = Project.param.sendMap[(string)sendList.Rows[sendList.SelectedRows[0].Index].Cells[0].Value].toHex(十六进制ToolStripMenuItem1.Checked);
            }
        }
        private void sendList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if ((sender as DataGridView).Rows[e.RowIndex].Selected == false)
                {
                    (sender as DataGridView).CurrentRow.Selected = false;
                    (sender as DataGridView).Rows[e.RowIndex].Selected = true;
                    (sender as DataGridView).CurrentCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
                if ((sender as DataGridView).SelectedRows.Count > 0)
                {
                    uiContextMenuStrip1.Show(MousePosition);
                }
            }
        }
        /*************reclist********************/
        private void uiContextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (recList.SelectedRows[0].Index > -1)
            {
                十六进制ToolStripMenuItem.Checked = Project.param.recvMap[(string)recList.Rows[recList.SelectedRows[0].Index].Cells[0].Value].isHex;
            }
        }

        private void 十六进制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recList.SelectedRows[0].Index > -1)
            {
                十六进制ToolStripMenuItem.Checked = !十六进制ToolStripMenuItem.Checked;
                recList.Rows[recList.SelectedRows[0].Index].Cells[1].Value = Project.param.recvMap[(string)recList.Rows[recList.SelectedRows[0].Index].Cells[0].Value].toHex(十六进制ToolStripMenuItem.Checked);
            }
        }

        private void recList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if ((sender as DataGridView).Rows[e.RowIndex].Selected == false)
                {
                    (sender as DataGridView).CurrentRow.Selected = false;
                    (sender as DataGridView).Rows[e.RowIndex].Selected = true;
                    (sender as DataGridView).CurrentCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
                if ((sender as DataGridView).SelectedRows.Count > 0)
                {
                    uiContextMenuStrip2.Show(MousePosition);
                }
            }
        }
    }
}
