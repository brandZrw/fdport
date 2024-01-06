
namespace FDPort.DockPanel
{
    partial class SendListDock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sendList = new System.Windows.Forms.DataGridView();
            this.sendName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.十六进制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sendList)).BeginInit();
            this.uiContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.sendList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sendList.BackgroundColor = System.Drawing.Color.White;
            this.sendList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sendList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sendList.ColumnHeadersHeight = 32;
            this.sendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sendList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sendName,
            this.sendValue});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sendList.DefaultCellStyle = dataGridViewCellStyle4;
            this.sendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendList.EnableHeadersVisualStyles = false;
            this.sendList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sendList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.sendList.Location = new System.Drawing.Point(0, 0);
            this.sendList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendList.Name = "sendList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sendList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sendList.RowHeadersVisible = false;
            this.sendList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 8F);
            this.sendList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.sendList.RowTemplate.Height = 23;
            this.sendList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sendList.Size = new System.Drawing.Size(284, 562);
            this.sendList.TabIndex = 3;
            this.sendList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.sendList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sendList_CellMouseClick);
            this.sendList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.sendList_RowsRemoved);
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
            dataGridViewCellStyle3.NullValue = "0";
            this.sendValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.sendValue.FillWeight = 40F;
            this.sendValue.HeaderText = "数值";
            this.sendValue.MinimumWidth = 6;
            this.sendValue.Name = "sendValue";
            this.sendValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.十六进制ToolStripMenuItem1});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(165, 36);
            this.uiContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.uiContextMenuStrip1_Opening);
            // 
            // 十六进制ToolStripMenuItem1
            // 
            this.十六进制ToolStripMenuItem1.Name = "十六进制ToolStripMenuItem1";
            this.十六进制ToolStripMenuItem1.Size = new System.Drawing.Size(164, 32);
            this.十六进制ToolStripMenuItem1.Text = "十六进制";
            this.十六进制ToolStripMenuItem1.Click += new System.EventHandler(this.十六进制ToolStripMenuItem1_Click);
            // 
            // SendListDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(284, 562);
            this.Controls.Add(this.sendList);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SendListDock";
            this.TabText = "SendMap";
            this.Text = "SendMap";
            ((System.ComponentModel.ISupportInitialize)(this.sendList)).EndInit();
            this.uiContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn sendName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendValue;
        private System.Windows.Forms.ContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 十六进制ToolStripMenuItem1;
        public System.Windows.Forms.DataGridView sendList;
    }
}