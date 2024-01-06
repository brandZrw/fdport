
namespace FDPort.DockPanel
{
    partial class ChartDock
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.移至开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移至最新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正常大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LineChart
            // 
            chartArea1.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea1);
            this.LineChart.ContextMenuStrip = this.contextMenuStrip1;
            this.LineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LineChart.Location = new System.Drawing.Point(0, 0);
            this.LineChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.LineChart.Name = "LineChart";
            this.LineChart.Size = new System.Drawing.Size(1067, 562);
            this.LineChart.TabIndex = 8;
            this.LineChart.MouseEnter += new System.EventHandler(this.LineChart_MouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.移至开始ToolStripMenuItem,
            this.移至最新ToolStripMenuItem,
            this.缩小ToolStripMenuItem,
            this.正常大小ToolStripMenuItem,
            this.清空图像ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 164);
            // 
            // 移至开始ToolStripMenuItem
            // 
            this.移至开始ToolStripMenuItem.Name = "移至开始ToolStripMenuItem";
            this.移至开始ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.移至开始ToolStripMenuItem.Text = "移至开始";
            this.移至开始ToolStripMenuItem.Click += new System.EventHandler(this.移至开始ToolStripMenuItem_Click);
            // 
            // 移至最新ToolStripMenuItem
            // 
            this.移至最新ToolStripMenuItem.Name = "移至最新ToolStripMenuItem";
            this.移至最新ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.移至最新ToolStripMenuItem.Text = "移至最新";
            this.移至最新ToolStripMenuItem.Click += new System.EventHandler(this.移至最新ToolStripMenuItem_Click);
            // 
            // 缩小ToolStripMenuItem
            // 
            this.缩小ToolStripMenuItem.Name = "缩小ToolStripMenuItem";
            this.缩小ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.缩小ToolStripMenuItem.Text = "缩小";
            this.缩小ToolStripMenuItem.Click += new System.EventHandler(this.缩小ToolStripMenuItem_Click);
            // 
            // 正常大小ToolStripMenuItem
            // 
            this.正常大小ToolStripMenuItem.Name = "正常大小ToolStripMenuItem";
            this.正常大小ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.正常大小ToolStripMenuItem.Text = "正常大小";
            this.正常大小ToolStripMenuItem.Click += new System.EventHandler(this.正常大小ToolStripMenuItem_Click);
            // 
            // 清空图像ToolStripMenuItem
            // 
            this.清空图像ToolStripMenuItem.Name = "清空图像ToolStripMenuItem";
            this.清空图像ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.清空图像ToolStripMenuItem.Text = "清空图像";
            this.清空图像ToolStripMenuItem.Click += new System.EventHandler(this.清空图像ToolStripMenuItem_Click);
            // 
            // ChartDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.LineChart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChartDock";
            this.TabText = "ChartDock";
            this.Text = "ChartDock";
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 移至开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移至最新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正常大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空图像ToolStripMenuItem;
    }
}