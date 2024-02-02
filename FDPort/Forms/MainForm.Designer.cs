
namespace FDPort.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.图像配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加时间戳ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存图像数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单元测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.端口转发ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.端口选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.是否转发ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.dockPanel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.dockPanel1.ShowAutoHideContentOnHover = false;
            this.dockPanel1.Size = new System.Drawing.Size(1249, 600);
            this.dockPanel1.TabIndex = 0;
            this.dockPanel1.Theme = this.vS2015LightTheme1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口配置ToolStripMenuItem,
            this.配置ToolStripMenuItem,
            this.协议配置ToolStripMenuItem,
            this.图像配置ToolStripMenuItem,
            this.数据保存ToolStripMenuItem,
            this.单元测试ToolStripMenuItem,
            this.端口转发ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1249, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 串口配置ToolStripMenuItem
            // 
            this.串口配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新端口ToolStripMenuItem,
            this.串口ToolStripMenuItem,
            this.tCP服务端ToolStripMenuItem,
            this.tCP客户端ToolStripMenuItem});
            this.串口配置ToolStripMenuItem.Name = "串口配置ToolStripMenuItem";
            this.串口配置ToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.串口配置ToolStripMenuItem.Text = "端口配置";
            // 
            // 刷新端口ToolStripMenuItem
            // 
            this.刷新端口ToolStripMenuItem.Name = "刷新端口ToolStripMenuItem";
            this.刷新端口ToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.刷新端口ToolStripMenuItem.Text = "刷新端口";
            this.刷新端口ToolStripMenuItem.Click += new System.EventHandler(this.刷新端口ToolStripMenuItem_Click);
            // 
            // 串口ToolStripMenuItem
            // 
            this.串口ToolStripMenuItem.Checked = true;
            this.串口ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.串口ToolStripMenuItem.Name = "串口ToolStripMenuItem";
            this.串口ToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.串口ToolStripMenuItem.Text = "串口";
            this.串口ToolStripMenuItem.Click += new System.EventHandler(this.串口ToolStripMenuItem_Click);
            // 
            // tCP服务端ToolStripMenuItem
            // 
            this.tCP服务端ToolStripMenuItem.Name = "tCP服务端ToolStripMenuItem";
            this.tCP服务端ToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.tCP服务端ToolStripMenuItem.Text = "TCP服务端";
            this.tCP服务端ToolStripMenuItem.Click += new System.EventHandler(this.tCP服务端ToolStripMenuItem_Click);
            // 
            // tCP客户端ToolStripMenuItem
            // 
            this.tCP客户端ToolStripMenuItem.Name = "tCP客户端ToolStripMenuItem";
            this.tCP客户端ToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.tCP客户端ToolStripMenuItem.Text = "TCP客户端";
            this.tCP客户端ToolStripMenuItem.Click += new System.EventHandler(this.tCP客户端ToolStripMenuItem_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.清空配置ToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.配置ToolStripMenuItem.Text = "导入导出";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.导入ToolStripMenuItem.Text = "导入";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.导入ToolStripMenuItem_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // 清空配置ToolStripMenuItem
            // 
            this.清空配置ToolStripMenuItem.Name = "清空配置ToolStripMenuItem";
            this.清空配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.清空配置ToolStripMenuItem.Text = "清空配置";
            this.清空配置ToolStripMenuItem.Click += new System.EventHandler(this.清空配置ToolStripMenuItem_Click);
            // 
            // 协议配置ToolStripMenuItem
            // 
            this.协议配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.接收协议ToolStripMenuItem,
            this.大小端ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.协议配置ToolStripMenuItem.Name = "协议配置ToolStripMenuItem";
            this.协议配置ToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.协议配置ToolStripMenuItem.Text = "协议配置";
            // 
            // 接收协议ToolStripMenuItem
            // 
            this.接收协议ToolStripMenuItem.Name = "接收协议ToolStripMenuItem";
            this.接收协议ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.接收协议ToolStripMenuItem.Text = "接收协议";
            this.接收协议ToolStripMenuItem.Click += new System.EventHandler(this.接收协议ToolStripMenuItem_Click);
            // 
            // 大小端ToolStripMenuItem
            // 
            this.大小端ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.高位在前ToolStripMenuItem,
            this.低位在前ToolStripMenuItem});
            this.大小端ToolStripMenuItem.Name = "大小端ToolStripMenuItem";
            this.大小端ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.大小端ToolStripMenuItem.Text = "大小端";
            // 
            // 高位在前ToolStripMenuItem
            // 
            this.高位在前ToolStripMenuItem.Checked = true;
            this.高位在前ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.高位在前ToolStripMenuItem.Name = "高位在前ToolStripMenuItem";
            this.高位在前ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.高位在前ToolStripMenuItem.Text = "高位在前";
            // 
            // 低位在前ToolStripMenuItem
            // 
            this.低位在前ToolStripMenuItem.Name = "低位在前ToolStripMenuItem";
            this.低位在前ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.低位在前ToolStripMenuItem.Text = "低位在前";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 26);
            this.toolStripMenuItem1.Text = "接收缓存最大值";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox2.Text = "1024";
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
            // 
            // 图像配置ToolStripMenuItem
            // 
            this.图像配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加时间戳ToolStripMenuItem,
            this.还原界面ToolStripMenuItem});
            this.图像配置ToolStripMenuItem.Name = "图像配置ToolStripMenuItem";
            this.图像配置ToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.图像配置ToolStripMenuItem.Text = "界面配置";
            // 
            // 添加时间戳ToolStripMenuItem
            // 
            this.添加时间戳ToolStripMenuItem.Checked = true;
            this.添加时间戳ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.添加时间戳ToolStripMenuItem.Name = "添加时间戳ToolStripMenuItem";
            this.添加时间戳ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.添加时间戳ToolStripMenuItem.Text = "添加时间戳";
            this.添加时间戳ToolStripMenuItem.Click += new System.EventHandler(this.添加时间戳ToolStripMenuItem_Click);
            // 
            // 还原界面ToolStripMenuItem
            // 
            this.还原界面ToolStripMenuItem.Name = "还原界面ToolStripMenuItem";
            this.还原界面ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.还原界面ToolStripMenuItem.Text = "还原界面";
            this.还原界面ToolStripMenuItem.Click += new System.EventHandler(this.还原界面ToolStripMenuItem_Click);
            // 
            // 数据保存ToolStripMenuItem
            // 
            this.数据保存ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始保存ToolStripMenuItem,
            this.保存图像数据ToolStripMenuItem});
            this.数据保存ToolStripMenuItem.Name = "数据保存ToolStripMenuItem";
            this.数据保存ToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.数据保存ToolStripMenuItem.Text = "数据保存";
            // 
            // 开始保存ToolStripMenuItem
            // 
            this.开始保存ToolStripMenuItem.Name = "开始保存ToolStripMenuItem";
            this.开始保存ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.开始保存ToolStripMenuItem.Text = "开始保存日志";
            this.开始保存ToolStripMenuItem.Click += new System.EventHandler(this.开始保存ToolStripMenuItem_Click);
            // 
            // 保存图像数据ToolStripMenuItem
            // 
            this.保存图像数据ToolStripMenuItem.Name = "保存图像数据ToolStripMenuItem";
            this.保存图像数据ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.保存图像数据ToolStripMenuItem.Text = "保存图像数据";
            this.保存图像数据ToolStripMenuItem.Click += new System.EventHandler(this.保存图像数据ToolStripMenuItem_Click);
            // 
            // 单元测试ToolStripMenuItem
            // 
            this.单元测试ToolStripMenuItem.Name = "单元测试ToolStripMenuItem";
            this.单元测试ToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.单元测试ToolStripMenuItem.Text = "单元测试";
            this.单元测试ToolStripMenuItem.Click += new System.EventHandler(this.单元测试ToolStripMenuItem_Click);
            // 
            // 端口转发ToolStripMenuItem
            // 
            this.端口转发ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.端口选择ToolStripMenuItem,
            this.是否转发ToolStripMenuItem});
            this.端口转发ToolStripMenuItem.Name = "端口转发ToolStripMenuItem";
            this.端口转发ToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.端口转发ToolStripMenuItem.Text = "端口转发";
            // 
            // 端口选择ToolStripMenuItem
            // 
            this.端口选择ToolStripMenuItem.Name = "端口选择ToolStripMenuItem";
            this.端口选择ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.端口选择ToolStripMenuItem.Text = "端口选择";
            this.端口选择ToolStripMenuItem.Click += new System.EventHandler(this.端口选择ToolStripMenuItem_Click);
            // 
            // 是否转发ToolStripMenuItem
            // 
            this.是否转发ToolStripMenuItem.Name = "是否转发ToolStripMenuItem";
            this.是否转发ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.是否转发ToolStripMenuItem.Text = "是否转发";
            this.是否转发ToolStripMenuItem.Click += new System.EventHandler(this.是否转发ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dockPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 600);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 串口配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新端口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 串口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCP服务端ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCP客户端ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 协议配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 接收协议ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大小端ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高位在前ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 低位在前ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加时间戳ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存图像数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单元测试ToolStripMenuItem;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 端口转发ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 端口选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 是否转发ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}