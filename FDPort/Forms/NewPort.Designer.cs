
namespace FDPort.Forms
{
    partial class NewPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.serialPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.uart_more = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.baudCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.socketSerPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.uiButton3 = new System.Windows.Forms.Button();
            this.uiLabel2 = new System.Windows.Forms.Label();
            this.serIP = new System.Windows.Forms.TextBox();
            this.serPort = new System.Windows.Forms.TextBox();
            this.socketCliPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLabel3 = new System.Windows.Forms.Label();
            this.tcpCliIP = new System.Windows.Forms.TextBox();
            this.uiLabel4 = new System.Windows.Forms.Label();
            this.tcpCliPort = new System.Windows.Forms.TextBox();
            this.uiButton5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.serialPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.socketSerPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.socketCliPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radioButton2);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton1);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.serialPanel);
            this.splitContainer1.Panel2.Controls.Add(this.socketSerPanel);
            this.splitContainer1.Panel2.Controls.Add(this.socketCliPanel);
            this.splitContainer1.Size = new System.Drawing.Size(477, 245);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 8);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "串口";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(177, 8);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "TCP客户端";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(337, 8);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "TCP服务端";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // serialPanel
            // 
            this.serialPanel.Controls.Add(this.tableLayoutPanel4);
            this.serialPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serialPanel.Location = new System.Drawing.Point(0, 0);
            this.serialPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serialPanel.Name = "serialPanel";
            this.serialPanel.Size = new System.Drawing.Size(477, 209);
            this.serialPanel.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 12;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.uart_more, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmbPort, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.baudCombo, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.button1, 6, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(477, 209);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uart_more
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.uart_more, 3);
            this.uart_more.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uart_more.Dock = System.Windows.Forms.DockStyle.Top;
            this.uart_more.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uart_more.Location = new System.Drawing.Point(0, 138);
            this.uart_more.Margin = new System.Windows.Forms.Padding(0);
            this.uart_more.MinimumSize = new System.Drawing.Size(1, 1);
            this.uart_more.Name = "uart_more";
            this.uart_more.Size = new System.Drawing.Size(117, 38);
            this.uart_more.TabIndex = 12;
            this.uart_more.Text = "详情";
            this.uart_more.Click += new System.EventHandler(this.uart_more_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label2, 5);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPort
            // 
            this.cmbPort.CausesValidation = false;
            this.tableLayoutPanel4.SetColumnSpan(this.cmbPort, 7);
            this.cmbPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPort.Location = new System.Drawing.Point(198, 2);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPort.MinimumSize = new System.Drawing.Size(43, 0);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(276, 29);
            this.cmbPort.TabIndex = 10;
            // 
            // baudCombo
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.baudCombo, 7);
            this.baudCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baudCombo.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baudCombo.Items.AddRange(new object[] {
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
            "256000"});
            this.baudCombo.Location = new System.Drawing.Point(198, 71);
            this.baudCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baudCombo.MinimumSize = new System.Drawing.Size(43, 0);
            this.baudCombo.Name = "baudCombo";
            this.baudCombo.Size = new System.Drawing.Size(276, 29);
            this.baudCombo.TabIndex = 11;
            // 
            // button1
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.button1, 6);
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(234, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 71);
            this.button1.TabIndex = 9;
            this.button1.Text = "打开串口";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // socketSerPanel
            // 
            this.socketSerPanel.Controls.Add(this.tableLayoutPanel3);
            this.socketSerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.socketSerPanel.Location = new System.Drawing.Point(0, 0);
            this.socketSerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.socketSerPanel.Name = "socketSerPanel";
            this.socketSerPanel.Size = new System.Drawing.Size(477, 209);
            this.socketSerPanel.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 12;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.Controls.Add(this.uiLabel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiButton3, 8, 2);
            this.tableLayoutPanel3.Controls.Add(this.uiLabel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.serIP, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.serPort, 6, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(477, 209);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // uiLabel1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.uiLabel1, 5);
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(189, 69);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "IP";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton3
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.uiButton3, 4);
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(315, 140);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(159, 67);
            this.uiButton3.TabIndex = 4;
            this.uiButton3.Text = "侦听";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiLabel2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.uiLabel2, 5);
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(3, 69);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(189, 69);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "port";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serIP
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.serIP, 6);
            this.serIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serIP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.serIP.Location = new System.Drawing.Point(234, 0);
            this.serIP.Margin = new System.Windows.Forms.Padding(0);
            this.serIP.MinimumSize = new System.Drawing.Size(4, 4);
            this.serIP.Name = "serIP";
            this.serIP.Size = new System.Drawing.Size(243, 34);
            this.serIP.TabIndex = 1;
            this.serIP.Text = "127.0.0.1";
            // 
            // serPort
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.serPort, 6);
            this.serPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serPort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serPort.Location = new System.Drawing.Point(237, 71);
            this.serPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serPort.MinimumSize = new System.Drawing.Size(4, 4);
            this.serPort.Name = "serPort";
            this.serPort.Size = new System.Drawing.Size(237, 34);
            this.serPort.TabIndex = 3;
            this.serPort.Text = "9000";
            // 
            // socketCliPanel
            // 
            this.socketCliPanel.Controls.Add(this.tableLayoutPanel5);
            this.socketCliPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.socketCliPanel.Location = new System.Drawing.Point(0, 0);
            this.socketCliPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.socketCliPanel.Name = "socketCliPanel";
            this.socketCliPanel.Size = new System.Drawing.Size(477, 209);
            this.socketCliPanel.TabIndex = 14;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 12;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.Controls.Add(this.uiLabel3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tcpCliIP, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiLabel4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tcpCliPort, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.uiButton5, 7, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(477, 209);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // uiLabel3
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.uiLabel3, 4);
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(3, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(150, 69);
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "IP";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcpCliIP
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.tcpCliIP, 7);
            this.tcpCliIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcpCliIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcpCliIP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tcpCliIP.Location = new System.Drawing.Point(198, 2);
            this.tcpCliIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcpCliIP.MinimumSize = new System.Drawing.Size(4, 4);
            this.tcpCliIP.Name = "tcpCliIP";
            this.tcpCliIP.Size = new System.Drawing.Size(276, 34);
            this.tcpCliIP.TabIndex = 1;
            this.tcpCliIP.Text = "127.0.0.1";
            // 
            // uiLabel4
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.uiLabel4, 4);
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(3, 69);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(150, 69);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "port";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcpCliPort
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.tcpCliPort, 7);
            this.tcpCliPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcpCliPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcpCliPort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcpCliPort.Location = new System.Drawing.Point(198, 71);
            this.tcpCliPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcpCliPort.MinimumSize = new System.Drawing.Size(4, 4);
            this.tcpCliPort.Name = "tcpCliPort";
            this.tcpCliPort.Size = new System.Drawing.Size(276, 34);
            this.tcpCliPort.TabIndex = 2;
            this.tcpCliPort.Text = "9000";
            // 
            // uiButton5
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.uiButton5, 5);
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton5.Location = new System.Drawing.Point(276, 140);
            this.uiButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.Size = new System.Drawing.Size(198, 67);
            this.uiButton5.TabIndex = 4;
            this.uiButton5.Text = "连接";
            this.uiButton5.Click += new System.EventHandler(this.uiButton5_Click);
            // 
            // NewPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 245);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewPort";
            this.Text = "NewPort";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.serialPanel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.socketSerPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.socketCliPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel serialPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uart_more;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ComboBox baudCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel socketCliPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label uiLabel3;
        private System.Windows.Forms.TextBox tcpCliIP;
        private System.Windows.Forms.Label uiLabel4;
        private System.Windows.Forms.TextBox tcpCliPort;
        private System.Windows.Forms.Button uiButton5;
        private System.Windows.Forms.Panel socketSerPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label uiLabel1;
        private System.Windows.Forms.Button uiButton3;
        private System.Windows.Forms.Label uiLabel2;
        private System.Windows.Forms.TextBox serIP;
        private System.Windows.Forms.TextBox serPort;
    }
}