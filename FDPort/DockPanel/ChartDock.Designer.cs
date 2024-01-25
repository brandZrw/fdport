
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
            this.lineChart = new ScottPlot.FormsPlot();
            this.DefaultRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autoAxisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openInNewWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detachLegendMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotObjectEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.DefaultRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineChart
            // 
            this.lineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineChart.Location = new System.Drawing.Point(0, 0);
            this.lineChart.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lineChart.Name = "lineChart";
            this.lineChart.Size = new System.Drawing.Size(1067, 562);
            this.lineChart.TabIndex = 1;
            this.lineChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lineChart_MouseMove);
            // 
            // DefaultRightClickMenu
            // 
            this.DefaultRightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DefaultRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenuItem,
            this.saveImageMenuItem,
            this.toolStripSeparator1,
            this.autoAxisMenuItem,
            this.清空图像ToolStripMenuItem,
            this.toolStripSeparator3,
            this.openInNewWindowMenuItem,
            this.detachLegendMenuItem,
            this.plotObjectEditorToolStripMenuItem});
            this.DefaultRightClickMenu.Name = "contextMenuStrip1";
            this.DefaultRightClickMenu.Size = new System.Drawing.Size(209, 184);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.Size = new System.Drawing.Size(236, 24);
            this.copyMenuItem.Text = "复制图像";
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // saveImageMenuItem
            // 
            this.saveImageMenuItem.Name = "saveImageMenuItem";
            this.saveImageMenuItem.Size = new System.Drawing.Size(236, 24);
            this.saveImageMenuItem.Text = "图像另存为";
            this.saveImageMenuItem.Click += new System.EventHandler(this.RightClickMenu_SaveImage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // autoAxisMenuItem
            // 
            this.autoAxisMenuItem.Name = "autoAxisMenuItem";
            this.autoAxisMenuItem.Size = new System.Drawing.Size(210, 24);
            this.autoAxisMenuItem.Text = "缩放至合适大小";
            this.autoAxisMenuItem.Click += new System.EventHandler(this.RightClickMenu_AutoAxis_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(233, 6);
            // 
            // openInNewWindowMenuItem
            // 
            this.openInNewWindowMenuItem.Name = "openInNewWindowMenuItem";
            this.openInNewWindowMenuItem.Size = new System.Drawing.Size(210, 24);
            this.openInNewWindowMenuItem.Text = "新页面显示";
            this.openInNewWindowMenuItem.Click += new System.EventHandler(this.RightClickMenu_OpenInNewWindow_Click);
            // 
            // detachLegendMenuItem
            // 
            this.detachLegendMenuItem.Name = "detachLegendMenuItem";
            this.detachLegendMenuItem.Size = new System.Drawing.Size(210, 24);
            this.detachLegendMenuItem.Text = "图例设置";
            this.detachLegendMenuItem.Click += new System.EventHandler(this.RightClickMenu_DetachLegend_Click);
            // 
            // plotObjectEditorToolStripMenuItem
            // 
            this.plotObjectEditorToolStripMenuItem.Name = "plotObjectEditorToolStripMenuItem";
            this.plotObjectEditorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.plotObjectEditorToolStripMenuItem.Text = "Plot Object Editor";
            this.plotObjectEditorToolStripMenuItem.Click += new System.EventHandler(this.RightClickMenu_PlotObjectEditor_Click);
            // 
            // 清空图像ToolStripMenuItem
            // 
            this.清空图像ToolStripMenuItem.Name = "清空图像ToolStripMenuItem";
            this.清空图像ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.清空图像ToolStripMenuItem.Text = "清空图像";
            this.清空图像ToolStripMenuItem.Click += new System.EventHandler(this.清空图像ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // ChartDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineChart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChartDock";
            this.TabText = "ChartDock";
            this.Text = "ChartDock";
            this.DefaultRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ScottPlot.FormsPlot lineChart;
        private System.Windows.Forms.ContextMenuStrip DefaultRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem autoAxisMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem openInNewWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detachLegendMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotObjectEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空图像ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}