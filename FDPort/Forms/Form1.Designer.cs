
namespace FDPort.Forms
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源.
        /// </summary>
        /// <param name="disposing">如果应释放托管资源,为 true;否则为 false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.串口配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新端口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.串口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCP服务端ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCP客户端ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.协议配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.接收协议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大小端ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高位在前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.低位在前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.曲线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.命令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.接收参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收发配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加时间戳ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存图像数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单元测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.移至开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移至最新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正常大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recList = new System.Windows.Forms.DataGridView();
            this.sendList = new System.Windows.Forms.DataGridView();
            this.sendName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdList = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.serialPanel = new System.Windows.Forms.Panel();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.uart_more = new System.Windows.Forms.Button();
            this.baudCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.socketCliPanel = new System.Windows.Forms.Panel();
            this.tcpCliPort = new System.Windows.Forms.TextBox();
            this.uiButton5 = new System.Windows.Forms.Button();
            this.uiLabel3 = new System.Windows.Forms.Label();
            this.tcpCliIP = new System.Windows.Forms.TextBox();
            this.uiLabel4 = new System.Windows.Forms.Label();
            this.socketSerPanel = new System.Windows.Forms.Panel();
            this.serPort = new System.Windows.Forms.TextBox();
            this.uiLabel2 = new System.Windows.Forms.Label();
            this.serIP = new System.Windows.Forms.TextBox();
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.uiButton3 = new System.Windows.Forms.Button();
            this.tcpTimeout = new System.Windows.Forms.TextBox();
            this.uiButton1 = new System.Windows.Forms.Button();
            this.uiLabel5 = new System.Windows.Forms.Label();
            this.uiButton2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.recBox = new System.Windows.Forms.TextBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.uiContextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.十六进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.十六进制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.sendObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmdTimer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmdTimerParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recIsShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmdSendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.serialPanel.SuspendLayout();
            this.socketCliPanel.SuspendLayout();
            this.socketSerPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.uiContextMenuStrip2.SuspendLayout();
            this.uiContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSendBindingSource)).BeginInit();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.串口配置ToolStripMenuItem,
                this.配置ToolStripMenuItem,
                this.协议配置ToolStripMenuItem,
                this.图像配置ToolStripMenuItem,
                this.数据保存ToolStripMenuItem,
                this.单元测试ToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(1, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            //
            // 串口配置ToolStripMenuItem
            //
            this.串口配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.刷新端口ToolStripMenuItem,
                this.串口ToolStripMenuItem,
                this.tCP服务端ToolStripMenuItem,
                this.tCP客户端ToolStripMenuItem
            });
            this.串口配置ToolStripMenuItem.Name = "串口配置ToolStripMenuItem";
            this.串口配置ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.串口配置ToolStripMenuItem.Text = "端口配置";
            //
            // 刷新端口ToolStripMenuItem
            //
            this.刷新端口ToolStripMenuItem.Name = "刷新端口ToolStripMenuItem";
            this.刷新端口ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.刷新端口ToolStripMenuItem.Text = "刷新端口";
            this.刷新端口ToolStripMenuItem.Click += new System.EventHandler(this.刷新端口ToolStripMenuItem_Click);
            //
            // 串口ToolStripMenuItem
            //
            this.串口ToolStripMenuItem.Checked = true;
            this.串口ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.串口ToolStripMenuItem.Name = "串口ToolStripMenuItem";
            this.串口ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.串口ToolStripMenuItem.Text = "串口";
            this.串口ToolStripMenuItem.Click += new System.EventHandler(this.串口ToolStripMenuItem_Click);
            //
            // tCP服务端ToolStripMenuItem
            //
            this.tCP服务端ToolStripMenuItem.Name = "tCP服务端ToolStripMenuItem";
            this.tCP服务端ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tCP服务端ToolStripMenuItem.Text = "TCP服务端";
            this.tCP服务端ToolStripMenuItem.Click += new System.EventHandler(this.tCP服务端ToolStripMenuItem_Click);
            //
            // tCP客户端ToolStripMenuItem
            //
            this.tCP客户端ToolStripMenuItem.Name = "tCP客户端ToolStripMenuItem";
            this.tCP客户端ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tCP客户端ToolStripMenuItem.Text = "TCP客户端";
            this.tCP客户端ToolStripMenuItem.Click += new System.EventHandler(this.tCP客户端ToolStripMenuItem_Click);
            //
            // 配置ToolStripMenuItem
            //
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.导入ToolStripMenuItem,
                this.导出ToolStripMenuItem,
                this.清空配置ToolStripMenuItem
            });
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.配置ToolStripMenuItem.Text = "导入导出";
            //
            // 导入ToolStripMenuItem
            //
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导入ToolStripMenuItem.Text = "导入";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.导入ToolStripMenuItem_Click);
            //
            // 导出ToolStripMenuItem
            //
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            //
            // 清空配置ToolStripMenuItem
            //
            this.清空配置ToolStripMenuItem.Name = "清空配置ToolStripMenuItem";
            this.清空配置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空配置ToolStripMenuItem.Text = "清空配置";
            this.清空配置ToolStripMenuItem.Click += new System.EventHandler(this.清空配置ToolStripMenuItem_Click);
            //
            // 协议配置ToolStripMenuItem
            //
            this.协议配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.接收协议ToolStripMenuItem,
                this.大小端ToolStripMenuItem
            });
            this.协议配置ToolStripMenuItem.Name = "协议配置ToolStripMenuItem";
            this.协议配置ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.协议配置ToolStripMenuItem.Text = "协议配置";
            //
            // 接收协议ToolStripMenuItem
            //
            this.接收协议ToolStripMenuItem.Name = "接收协议ToolStripMenuItem";
            this.接收协议ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.接收协议ToolStripMenuItem.Text = "接收协议";
            this.接收协议ToolStripMenuItem.Click += new System.EventHandler(this.接收协议ToolStripMenuItem_Click);
            //
            // 大小端ToolStripMenuItem
            //
            this.大小端ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.高位在前ToolStripMenuItem,
                this.低位在前ToolStripMenuItem
            });
            this.大小端ToolStripMenuItem.Name = "大小端ToolStripMenuItem";
            this.大小端ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.大小端ToolStripMenuItem.Text = "大小端";
            //
            // 高位在前ToolStripMenuItem
            //
            this.高位在前ToolStripMenuItem.Checked = true;
            this.高位在前ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.高位在前ToolStripMenuItem.Name = "高位在前ToolStripMenuItem";
            this.高位在前ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.高位在前ToolStripMenuItem.Text = "高位在前";
            this.高位在前ToolStripMenuItem.Click += new System.EventHandler(this.高位在前ToolStripMenuItem_Click);
            //
            // 低位在前ToolStripMenuItem
            //
            this.低位在前ToolStripMenuItem.Name = "低位在前ToolStripMenuItem";
            this.低位在前ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.低位在前ToolStripMenuItem.Text = "低位在前";
            this.低位在前ToolStripMenuItem.Click += new System.EventHandler(this.低位在前ToolStripMenuItem_Click);
            //
            // 图像配置ToolStripMenuItem
            //
            this.图像配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.曲线ToolStripMenuItem,
                this.命令ToolStripMenuItem,
                this.设置参数ToolStripMenuItem,
                this.接收参数ToolStripMenuItem,
                this.收发配置ToolStripMenuItem,
                this.添加时间戳ToolStripMenuItem
            });
            this.图像配置ToolStripMenuItem.Name = "图像配置ToolStripMenuItem";
            this.图像配置ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.图像配置ToolStripMenuItem.Text = "界面配置";
            //
            // 曲线ToolStripMenuItem
            //
            this.曲线ToolStripMenuItem.Checked = true;
            this.曲线ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.曲线ToolStripMenuItem.Name = "曲线ToolStripMenuItem";
            this.曲线ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.曲线ToolStripMenuItem.Text = "曲线";
            this.曲线ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.menuUpdata);
            this.曲线ToolStripMenuItem.Click += new System.EventHandler(this.曲线ToolStripMenuItem_Click);
            //
            // 命令ToolStripMenuItem
            //
            this.命令ToolStripMenuItem.Checked = true;
            this.命令ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.命令ToolStripMenuItem.Name = "命令ToolStripMenuItem";
            this.命令ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.命令ToolStripMenuItem.Text = "命令";
            this.命令ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.menuUpdata);
            this.命令ToolStripMenuItem.Click += new System.EventHandler(this.命令ToolStripMenuItem_Click);
            //
            // 设置参数ToolStripMenuItem
            //
            this.设置参数ToolStripMenuItem.Checked = true;
            this.设置参数ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.设置参数ToolStripMenuItem.Name = "设置参数ToolStripMenuItem";
            this.设置参数ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.设置参数ToolStripMenuItem.Text = "设置参数";
            this.设置参数ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.menuUpdata);
            this.设置参数ToolStripMenuItem.Click += new System.EventHandler(this.设置参数ToolStripMenuItem_Click);
            //
            // 接收参数ToolStripMenuItem
            //
            this.接收参数ToolStripMenuItem.Checked = true;
            this.接收参数ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.接收参数ToolStripMenuItem.Name = "接收参数ToolStripMenuItem";
            this.接收参数ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.接收参数ToolStripMenuItem.Text = "接收参数";
            this.接收参数ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.menuUpdata);
            this.接收参数ToolStripMenuItem.Click += new System.EventHandler(this.接收参数ToolStripMenuItem_Click);
            //
            // 收发配置ToolStripMenuItem
            //
            this.收发配置ToolStripMenuItem.Checked = true;
            this.收发配置ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.收发配置ToolStripMenuItem.Name = "收发配置ToolStripMenuItem";
            this.收发配置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.收发配置ToolStripMenuItem.Text = "收发配置";
            this.收发配置ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.menuUpdata);
            this.收发配置ToolStripMenuItem.Click += new System.EventHandler(this.收发配置ToolStripMenuItem_Click);
            //
            // 添加时间戳ToolStripMenuItem
            //
            this.添加时间戳ToolStripMenuItem.Checked = true;
            this.添加时间戳ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.添加时间戳ToolStripMenuItem.Name = "添加时间戳ToolStripMenuItem";
            this.添加时间戳ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加时间戳ToolStripMenuItem.Text = "添加时间戳";
            this.添加时间戳ToolStripMenuItem.Click += new System.EventHandler(this.添加时间戳ToolStripMenuItem_Click);
            //
            // 数据保存ToolStripMenuItem
            //
            this.数据保存ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.开始保存ToolStripMenuItem,
                this.保存图像数据ToolStripMenuItem
            });
            this.数据保存ToolStripMenuItem.Name = "数据保存ToolStripMenuItem";
            this.数据保存ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.数据保存ToolStripMenuItem.Text = "数据保存";
            //
            // 开始保存ToolStripMenuItem
            //
            this.开始保存ToolStripMenuItem.Name = "开始保存ToolStripMenuItem";
            this.开始保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.开始保存ToolStripMenuItem.Text = "开始保存日志";
            this.开始保存ToolStripMenuItem.Click += new System.EventHandler(this.开始保存ToolStripMenuItem_Click);
            //
            // 保存图像数据ToolStripMenuItem
            //
            this.保存图像数据ToolStripMenuItem.Name = "保存图像数据ToolStripMenuItem";
            this.保存图像数据ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存图像数据ToolStripMenuItem.Text = "保存图像数据";
            this.保存图像数据ToolStripMenuItem.Click += new System.EventHandler(this.保存图像数据ToolStripMenuItem_Click);
            //
            // 单元测试ToolStripMenuItem
            //
            this.单元测试ToolStripMenuItem.Name = "单元测试ToolStripMenuItem";
            this.单元测试ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.单元测试ToolStripMenuItem.Text = "单元测试";
            this.单元测试ToolStripMenuItem.Click += new System.EventHandler(this.单元测试ToolStripMenuItem_Click);
            //
            // splitContainer1
            //
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(1, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(942, 475);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.Controls.Add(this.LineChart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.recList, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sendList, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdList, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 296);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // LineChart
            //
            chartArea1.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea1);
            this.LineChart.ContextMenuStrip = this.contextMenuStrip1;
            this.LineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LineChart.Location = new System.Drawing.Point(2, 2);
            this.LineChart.Margin = new System.Windows.Forms.Padding(2);
            this.LineChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.LineChart.Name = "LineChart";
            this.LineChart.Size = new System.Drawing.Size(354, 292);
            this.LineChart.TabIndex = 6;
            //
            // contextMenuStrip1
            //
            this.contextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.移至开始ToolStripMenuItem,
                this.移至最新ToolStripMenuItem,
                this.缩小ToolStripMenuItem,
                this.正常大小ToolStripMenuItem,
                this.清空图像ToolStripMenuItem
            });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 134);
            //
            // 移至开始ToolStripMenuItem
            //
            this.移至开始ToolStripMenuItem.Name = "移至开始ToolStripMenuItem";
            this.移至开始ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.移至开始ToolStripMenuItem.Text = "移至开始";
            this.移至开始ToolStripMenuItem.Click += new System.EventHandler(this.移至开始ToolStripMenuItem_Click);
            //
            // 移至最新ToolStripMenuItem
            //
            this.移至最新ToolStripMenuItem.Name = "移至最新ToolStripMenuItem";
            this.移至最新ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.移至最新ToolStripMenuItem.Text = "移至最新";
            this.移至最新ToolStripMenuItem.Click += new System.EventHandler(this.移至最新ToolStripMenuItem_Click);
            //
            // 缩小ToolStripMenuItem
            //
            this.缩小ToolStripMenuItem.Name = "缩小ToolStripMenuItem";
            this.缩小ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.缩小ToolStripMenuItem.Text = "缩小";
            this.缩小ToolStripMenuItem.Click += new System.EventHandler(this.缩小ToolStripMenuItem_Click);
            //
            // 正常大小ToolStripMenuItem
            //
            this.正常大小ToolStripMenuItem.Name = "正常大小ToolStripMenuItem";
            this.正常大小ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.正常大小ToolStripMenuItem.Text = "正常大小";
            this.正常大小ToolStripMenuItem.Click += new System.EventHandler(this.正常大小ToolStripMenuItem_Click);
            //
            // 清空图像ToolStripMenuItem
            //
            this.清空图像ToolStripMenuItem.Name = "清空图像ToolStripMenuItem";
            this.清空图像ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.清空图像ToolStripMenuItem.Text = "清空图像";
            this.清空图像ToolStripMenuItem.Click += new System.EventHandler(this.清空图像ToolStripMenuItem_Click);
            //
            // recList
            //
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.recList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.recList.BackgroundColor = System.Drawing.Color.White;
            this.recList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.recList.ColumnHeadersHeight = 32;
            this.recList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.recList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.recName,
                this.recValue,
                this.recIsShow
            });
            this.recList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recList.EnableHeadersVisualStyles = false;
            this.recList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.recList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.recList.Location = new System.Drawing.Point(763, 2);
            this.recList.Margin = new System.Windows.Forms.Padding(2);
            this.recList.Name = "recList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.recList.RowHeadersVisible = false;
            this.recList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 8F);
            this.recList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.recList.RowTemplate.Height = 23;
            this.recList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recList.Size = new System.Drawing.Size(177, 292);
            this.recList.TabIndex = 3;
            this.recList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recList_CellContentClick);
            this.recList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.recList_CellEndEdit);
            this.recList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.recList_CellMouseClick);
            this.recList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.recList_RowsRemoved);
            this.recList.Resize += new System.EventHandler(this.recList_Resize);
            //
            // sendList
            //
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sendList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.sendList.BackgroundColor = System.Drawing.Color.White;
            this.sendList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sendList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.sendList.ColumnHeadersHeight = 32;
            this.sendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sendList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.sendName,
                this.sendValue
            });
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sendList.DefaultCellStyle = dataGridViewCellStyle8;
            this.sendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendList.EnableHeadersVisualStyles = false;
            this.sendList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sendList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.sendList.Location = new System.Drawing.Point(629, 2);
            this.sendList.Margin = new System.Windows.Forms.Padding(2);
            this.sendList.Name = "sendList";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sendList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.sendList.RowHeadersVisible = false;
            this.sendList.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 8F);
            this.sendList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.sendList.RowTemplate.Height = 23;
            this.sendList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sendList.Size = new System.Drawing.Size(130, 292);
            this.sendList.TabIndex = 2;
            this.sendList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.sendList_CellEndEdit);
            this.sendList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sendList_CellMouseClick);
            this.sendList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.sendList_RowsRemoved);
            this.sendList.Resize += new System.EventHandler(this.sendList_Resize);
            //
            // sendName
            //
            this.sendName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sendName.DataPropertyName = "sendName";
            this.sendName.FillWeight = 60F;
            this.sendName.HeaderText = "数据名";
            this.sendName.MinimumWidth = 6;
            this.sendName.Name = "sendName";
            this.sendName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // sendValue
            //
            this.sendValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sendValue.DataPropertyName = "sendValue";
            dataGridViewCellStyle7.NullValue = "0";
            this.sendValue.DefaultCellStyle = dataGridViewCellStyle7;
            this.sendValue.FillWeight = 40F;
            this.sendValue.HeaderText = "数值";
            this.sendValue.MinimumWidth = 6;
            this.sendValue.Name = "sendValue";
            this.sendValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // cmdList
            //
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmdList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.cmdList.BackgroundColor = System.Drawing.Color.White;
            this.cmdList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.cmdList.ColumnHeadersHeight = 32;
            this.cmdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cmdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.dataGridViewTextBoxColumn1,
                this.cmdSend,
                this.cmdTimer,
                this.cmdTimerParam
            });
            this.cmdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdList.EnableHeadersVisualStyles = false;
            this.cmdList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cmdList.Location = new System.Drawing.Point(360, 2);
            this.cmdList.Margin = new System.Windows.Forms.Padding(2);
            this.cmdList.Name = "cmdList";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdList.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.cmdList.RowHeadersVisible = false;
            this.cmdList.RowHeadersWidth = 51;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 8F);
            this.cmdList.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.cmdList.RowTemplate.Height = 23;
            this.cmdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cmdList.Size = new System.Drawing.Size(265, 292);
            this.cmdList.TabIndex = 4;
            this.cmdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cmdList_CellContentClick);
            this.cmdList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cmdList_CellDoubleClick);
            this.cmdList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.cmdList_RowsRemoved);
            this.cmdList.Resize += new System.EventHandler(this.cmdList_Resize);
            //
            // splitContainer2
            //
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            //
            // splitContainer2.Panel1
            //
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            //
            // splitContainer2.Panel2
            //
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(942, 177);
            this.splitContainer2.SplitterDistance = 140;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            //
            // splitContainer4
            //
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer4.Panel1
            //
            this.splitContainer4.Panel1.Controls.Add(this.serialPanel);
            this.splitContainer4.Panel1.Controls.Add(this.socketCliPanel);
            this.splitContainer4.Panel1.Controls.Add(this.socketSerPanel);
            //
            // splitContainer4.Panel2
            //
            this.splitContainer4.Panel2.Controls.Add(this.tcpTimeout);
            this.splitContainer4.Panel2.Controls.Add(this.uiButton1);
            this.splitContainer4.Panel2.Controls.Add(this.uiLabel5);
            this.splitContainer4.Panel2.Controls.Add(this.uiButton2);
            this.splitContainer4.Size = new System.Drawing.Size(140, 177);
            this.splitContainer4.SplitterDistance = 95;
            this.splitContainer4.SplitterWidth = 2;
            this.splitContainer4.TabIndex = 7;
            //
            // serialPanel
            //
            this.serialPanel.Controls.Add(this.cmbPort);
            this.serialPanel.Controls.Add(this.uart_more);
            this.serialPanel.Controls.Add(this.baudCombo);
            this.serialPanel.Controls.Add(this.button1);
            this.serialPanel.Controls.Add(this.label1);
            this.serialPanel.Controls.Add(this.label2);
            this.serialPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serialPanel.Location = new System.Drawing.Point(0, 0);
            this.serialPanel.Margin = new System.Windows.Forms.Padding(2);
            this.serialPanel.Name = "serialPanel";
            this.serialPanel.Size = new System.Drawing.Size(140, 95);
            this.serialPanel.TabIndex = 12;
            //
            // cmbPort
            //
            this.cmbPort.CausesValidation = false;
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPort.Location = new System.Drawing.Point(51, 4);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPort.MinimumSize = new System.Drawing.Size(33, 0);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(83, 27);
            this.cmbPort.TabIndex = 10;
            this.cmbPort.SelectedIndexChanged += new System.EventHandler(this.cmbPort_SelectedIndexChanged);
            //
            // uart_more
            //
            this.uart_more.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uart_more.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uart_more.Location = new System.Drawing.Point(2, 67);
            this.uart_more.Margin = new System.Windows.Forms.Padding(2);
            this.uart_more.MinimumSize = new System.Drawing.Size(1, 1);
            this.uart_more.Name = "uart_more";
            this.uart_more.Size = new System.Drawing.Size(45, 26);
            this.uart_more.TabIndex = 12;
            this.uart_more.Text = "详情";
            this.uart_more.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uart_more.Click += new System.EventHandler(this.uart_more_Click);
            //
            // baudCombo
            //
            this.baudCombo.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baudCombo.Items.AddRange(new object[]
            {
                "1200",
                "2400",
                "4800",
                "9600",
                "14400",
                "19200",
                "38400",
                "56000",
                "57600",
                "115200",
                "128000",
                "256000"
            });
            this.baudCombo.Location = new System.Drawing.Point(51, 36);
            this.baudCombo.Margin = new System.Windows.Forms.Padding(2);
            this.baudCombo.MinimumSize = new System.Drawing.Size(33, 0);
            this.baudCombo.Name = "baudCombo";
            this.baudCombo.Size = new System.Drawing.Size(83, 27);
            this.baudCombo.TabIndex = 11;
            this.baudCombo.SelectedIndexChanged += new System.EventHandler(this.baudCombo_SelectedIndexChanged);
            //
            // button1
            //
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(65, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "打开串口";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口号";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            //
            // socketCliPanel
            //
            this.socketCliPanel.Controls.Add(this.tcpCliPort);
            this.socketCliPanel.Controls.Add(this.uiButton5);
            this.socketCliPanel.Controls.Add(this.uiLabel3);
            this.socketCliPanel.Controls.Add(this.tcpCliIP);
            this.socketCliPanel.Controls.Add(this.uiLabel4);
            this.socketCliPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.socketCliPanel.Location = new System.Drawing.Point(0, 0);
            this.socketCliPanel.Margin = new System.Windows.Forms.Padding(2);
            this.socketCliPanel.Name = "socketCliPanel";
            this.socketCliPanel.Size = new System.Drawing.Size(140, 95);
            this.socketCliPanel.TabIndex = 6;
            //
            // tcpCliPort
            //
            this.tcpCliPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcpCliPort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcpCliPort.Location = new System.Drawing.Point(62, 36);
            this.tcpCliPort.Margin = new System.Windows.Forms.Padding(2);
            this.tcpCliPort.MinimumSize = new System.Drawing.Size(4, 4);
            this.tcpCliPort.Name = "tcpCliPort";
            this.tcpCliPort.Size = new System.Drawing.Size(69, 29);
            this.tcpCliPort.TabIndex = 2;
            this.tcpCliPort.Text = "9000";
            this.tcpCliPort.TextChanged += new System.EventHandler(this.tcpCliPort_TextChanged);
            //
            // uiButton5
            //
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton5.Location = new System.Drawing.Point(77, 69);
            this.uiButton5.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.Size = new System.Drawing.Size(54, 24);
            this.uiButton5.TabIndex = 4;
            this.uiButton5.Text = "连接";
            this.uiButton5.Click += new System.EventHandler(this.uiButton5_Click);
            //
            // uiLabel3
            //
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(2, 6);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(39, 24);
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "IP";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // tcpCliIP
            //
            this.tcpCliIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcpCliIP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tcpCliIP.Location = new System.Drawing.Point(45, 4);
            this.tcpCliIP.Margin = new System.Windows.Forms.Padding(2);
            this.tcpCliIP.MinimumSize = new System.Drawing.Size(4, 4);
            this.tcpCliIP.Name = "tcpCliIP";
            this.tcpCliIP.Size = new System.Drawing.Size(86, 29);
            this.tcpCliIP.TabIndex = 1;
            this.tcpCliIP.Text = "127.0.0.1";
            this.tcpCliIP.TextChanged += new System.EventHandler(this.tcpCliIP_TextChanged);
            //
            // uiLabel4
            //
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(2, 33);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(43, 34);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "port";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // socketSerPanel
            //
            this.socketSerPanel.Controls.Add(this.serPort);
            this.socketSerPanel.Controls.Add(this.uiLabel2);
            this.socketSerPanel.Controls.Add(this.serIP);
            this.socketSerPanel.Controls.Add(this.uiLabel1);
            this.socketSerPanel.Controls.Add(this.uiButton3);
            this.socketSerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.socketSerPanel.Location = new System.Drawing.Point(0, 0);
            this.socketSerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.socketSerPanel.Name = "socketSerPanel";
            this.socketSerPanel.Size = new System.Drawing.Size(140, 95);
            this.socketSerPanel.TabIndex = 12;
            //
            // serPort
            //
            this.serPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serPort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serPort.Location = new System.Drawing.Point(62, 36);
            this.serPort.Margin = new System.Windows.Forms.Padding(2);
            this.serPort.MinimumSize = new System.Drawing.Size(4, 4);
            this.serPort.Name = "serPort";
            this.serPort.Size = new System.Drawing.Size(69, 29);
            this.serPort.TabIndex = 3;
            this.serPort.Text = "9000";
            this.serPort.TextChanged += new System.EventHandler(this.serPort_TextChanged);
            //
            // uiLabel2
            //
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(2, 33);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(43, 34);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "port";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // serIP
            //
            this.serIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serIP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.serIP.Location = new System.Drawing.Point(45, 4);
            this.serIP.Margin = new System.Windows.Forms.Padding(0);
            this.serIP.MinimumSize = new System.Drawing.Size(4, 4);
            this.serIP.Name = "serIP";
            this.serIP.Size = new System.Drawing.Size(86, 29);
            this.serIP.TabIndex = 1;
            this.serIP.Text = "127.0.0.1";
            this.serIP.TextChanged += new System.EventHandler(this.serIP_TextChanged);
            //
            // uiLabel1
            //
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(2, 6);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(39, 24);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "IP";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // uiButton3
            //
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(77, 69);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(54, 24);
            this.uiButton3.TabIndex = 4;
            this.uiButton3.Text = "侦听";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            //
            // tcpTimeout
            //
            this.tcpTimeout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcpTimeout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcpTimeout.Location = new System.Drawing.Point(83, 2);
            this.tcpTimeout.Margin = new System.Windows.Forms.Padding(2);
            this.tcpTimeout.MinimumSize = new System.Drawing.Size(4, 4);
            this.tcpTimeout.Name = "tcpTimeout";
            this.tcpTimeout.Size = new System.Drawing.Size(51, 23);
            this.tcpTimeout.TabIndex = 8;
            this.tcpTimeout.Text = "20";
            this.tcpTimeout.TextChanged += new System.EventHandler(this.tcpTimeout_TextChanged);
            //
            // uiButton1
            //
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(49, 28);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(85, 47);
            this.uiButton1.TabIndex = 7;
            this.uiButton1.Text = "发送";
            this.uiButton1.Click += new System.EventHandler(this.button2_Click);
            //
            // uiLabel5
            //
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(-4, 6);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(79, 20);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "超时时间";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // uiButton2
            //
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(2, 43);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(43, 25);
            this.uiButton2.TabIndex = 8;
            this.uiButton2.Text = "清空";
            this.uiButton2.Click += new System.EventHandler(this.Clear_Click);
            //
            // tableLayoutPanel2
            //
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.recBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.sendBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 177);
            this.tableLayoutPanel2.TabIndex = 1;
            //
            // recBox
            //
            this.recBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recBox.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recBox.Location = new System.Drawing.Point(402, 2);
            this.recBox.Margin = new System.Windows.Forms.Padding(2);
            this.recBox.MinimumSize = new System.Drawing.Size(4, 4);
            this.recBox.Multiline = true;
            this.recBox.Name = "recBox";
            this.recBox.Size = new System.Drawing.Size(396, 173);
            this.recBox.TabIndex = 1;
            //
            // sendBox
            //
            this.sendBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sendBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendBox.Font = new System.Drawing.Font("微软雅黑", 9.25F);
            this.sendBox.Location = new System.Drawing.Point(2, 2);
            this.sendBox.Margin = new System.Windows.Forms.Padding(2);
            this.sendBox.MinimumSize = new System.Drawing.Size(4, 4);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(396, 173);
            this.sendBox.TabIndex = 0;
            //
            // uiContextMenuStrip2
            //
            this.uiContextMenuStrip2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.十六进制ToolStripMenuItem
            });
            this.uiContextMenuStrip2.Name = "uiContextMenuStrip2";
            this.uiContextMenuStrip2.Size = new System.Drawing.Size(145, 30);
            this.uiContextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.uiContextMenuStrip2_Opening);
            //
            // 十六进制ToolStripMenuItem
            //
            this.十六进制ToolStripMenuItem.Name = "十六进制ToolStripMenuItem";
            this.十六进制ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.十六进制ToolStripMenuItem.Text = "十六进制";
            this.十六进制ToolStripMenuItem.Click += new System.EventHandler(this.十六进制ToolStripMenuItem_Click);
            //
            // uiContextMenuStrip1
            //
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.十六进制ToolStripMenuItem1
            });
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(145, 30);
            this.uiContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.uiContextMenuStrip1_Opening);
            //
            // 十六进制ToolStripMenuItem1
            //
            this.十六进制ToolStripMenuItem1.Name = "十六进制ToolStripMenuItem1";
            this.十六进制ToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.十六进制ToolStripMenuItem1.Text = "十六进制";
            this.十六进制ToolStripMenuItem1.Click += new System.EventHandler(this.十六进制ToolStripMenuItem1_Click);
            //
            // serialPort
            //
            this.serialPort.ReadTimeout = 50;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            //
            // dataGridViewTextBoxColumn1
            //
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.FillWeight = 35F;
            this.dataGridViewTextBoxColumn1.HeaderText = "命令名";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // cmdSend
            //
            this.cmdSend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = "发送";
            this.cmdSend.DefaultCellStyle = dataGridViewCellStyle13;
            this.cmdSend.FillWeight = 25F;
            this.cmdSend.HeaderText = "发送";
            this.cmdSend.MinimumWidth = 6;
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.ReadOnly = true;
            this.cmdSend.Text = "发送";
            this.cmdSend.ToolTipText = "发送";
            this.cmdSend.UseColumnTextForButtonValue = true;
            //
            // cmdTimer
            //
            this.cmdTimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmdTimer.DataPropertyName = "autoSend";
            this.cmdTimer.FillWeight = 20F;
            this.cmdTimer.HeaderText = "连发";
            this.cmdTimer.MinimumWidth = 6;
            this.cmdTimer.Name = "cmdTimer";
            this.cmdTimer.ReadOnly = true;
            //
            // cmdTimerParam
            //
            this.cmdTimerParam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmdTimerParam.DataPropertyName = "sendTime";
            dataGridViewCellStyle14.NullValue = "1000";
            this.cmdTimerParam.DefaultCellStyle = dataGridViewCellStyle14;
            this.cmdTimerParam.FillWeight = 20F;
            this.cmdTimerParam.HeaderText = " 间隔";
            this.cmdTimerParam.MinimumWidth = 6;
            this.cmdTimerParam.Name = "cmdTimerParam";
            this.cmdTimerParam.ReadOnly = true;
            //
            // recName
            //
            this.recName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recName.DataPropertyName = "recName";
            this.recName.FillWeight = 40F;
            this.recName.HeaderText = "数据名";
            this.recName.MinimumWidth = 6;
            this.recName.Name = "recName";
            this.recName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // recValue
            //
            this.recValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recValue.DataPropertyName = "recValue";
            this.recValue.FillWeight = 35F;
            this.recValue.HeaderText = "数值";
            this.recValue.MinimumWidth = 6;
            this.recValue.Name = "recValue";
            this.recValue.ReadOnly = true;
            this.recValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // recIsShow
            //
            this.recIsShow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recIsShow.DataPropertyName = "recIsShow";
            this.recIsShow.FalseValue = "false";
            this.recIsShow.FillWeight = 25F;
            this.recIsShow.HeaderText = "图像";
            this.recIsShow.MinimumWidth = 6;
            this.recIsShow.Name = "recIsShow";
            this.recIsShow.TrueValue = "true";
            //
            // cmdSendBindingSource
            //
            this.cmdSendBindingSource.DataSource = typeof(FDPort.Class.CmdSend);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "FDPort";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdList)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.serialPanel.ResumeLayout(false);
            this.serialPanel.PerformLayout();
            this.socketCliPanel.ResumeLayout(false);
            this.socketCliPanel.PerformLayout();
            this.socketSerPanel.ResumeLayout(false);
            this.socketSerPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.uiContextMenuStrip2.ResumeLayout(false);
            this.uiContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSendBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 串口配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新端口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 串口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCP服务端ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCP客户端ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 协议配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 接收协议ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ToolStripMenuItem 图像配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 曲线ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView sendList;
        private System.Windows.Forms.DataGridView recList;
        private System.Windows.Forms.ToolStripMenuItem 大小端ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高位在前ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 低位在前ToolStripMenuItem;
        private System.Windows.Forms.BindingSource sendObjBindingSource;
        private System.Windows.Forms.BindingSource recObjBindingSource;
        private System.Windows.Forms.ToolStripMenuItem 数据保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 命令ToolStripMenuItem;
        private System.Windows.Forms.Button uiButton1;
        private System.Windows.Forms.Button uiButton2;
        private System.Windows.Forms.ComboBox baudCombo;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox recBox;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.ToolStripMenuItem 设置参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 接收参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收发配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存图像数据ToolStripMenuItem;
        private System.Windows.Forms.Panel serialPanel;
        private System.Windows.Forms.Panel socketSerPanel;
        private System.Windows.Forms.Button uiButton3;
        private System.Windows.Forms.TextBox serPort;
        private System.Windows.Forms.Label uiLabel2;
        private System.Windows.Forms.TextBox serIP;
        private System.Windows.Forms.Label uiLabel1;
        private System.Windows.Forms.Panel socketCliPanel;
        private System.Windows.Forms.Button uiButton5;
        private System.Windows.Forms.Label uiLabel4;
        private System.Windows.Forms.TextBox tcpCliPort;
        private System.Windows.Forms.TextBox tcpCliIP;
        private System.Windows.Forms.Label uiLabel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 移至开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移至最新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正常大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空图像ToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label uiLabel5;
        private System.Windows.Forms.Button uart_more;
        private System.Windows.Forms.BindingSource cmdSendBindingSource;
        private System.Windows.Forms.DataGridView cmdList;
        private System.Windows.Forms.TextBox tcpTimeout;
        private System.Windows.Forms.ToolStripMenuItem 添加时间戳ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单元测试ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendValue;
        private System.Windows.Forms.ContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 十六进制ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip uiContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 十六进制ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn recName;
        private System.Windows.Forms.DataGridViewTextBoxColumn recValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recIsShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn cmdSend;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmdTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdTimerParam;
    }
}

