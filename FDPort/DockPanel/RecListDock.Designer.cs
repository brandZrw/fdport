
namespace FDPort.DockPanel
{
    partial class RecListDock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.recList = new System.Windows.Forms.DataGridView();
            this.recName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recIsShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uiContextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.十六进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.recList)).BeginInit();
            this.uiContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
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
            this.recList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recName,
            this.recValue,
            this.recIsShow});
            this.recList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recList.EnableHeadersVisualStyles = false;
            this.recList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.recList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.recList.Location = new System.Drawing.Point(0, 0);
            this.recList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.recList.Size = new System.Drawing.Size(341, 562);
            this.recList.TabIndex = 4;
            this.recList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recList_CellContentClick);
            this.recList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.recList_CellEndEdit);
            this.recList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.recList_CellMouseClick);
            this.recList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.recList_RowsRemoved);
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
            // uiContextMenuStrip2
            // 
            this.uiContextMenuStrip2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.十六进制ToolStripMenuItem});
            this.uiContextMenuStrip2.Name = "uiContextMenuStrip2";
            this.uiContextMenuStrip2.Size = new System.Drawing.Size(165, 36);
            this.uiContextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.uiContextMenuStrip2_Opening);
            // 
            // 十六进制ToolStripMenuItem
            // 
            this.十六进制ToolStripMenuItem.Name = "十六进制ToolStripMenuItem";
            this.十六进制ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.十六进制ToolStripMenuItem.Text = "十六进制";
            this.十六进制ToolStripMenuItem.Click += new System.EventHandler(this.十六进制ToolStripMenuItem_Click);
            // 
            // RecListDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 562);
            this.Controls.Add(this.recList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecListDock";
            this.TabText = "RecCmd";
            this.Text = "RecCmd";
            ((System.ComponentModel.ISupportInitialize)(this.recList)).EndInit();
            this.uiContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn recName;
        private System.Windows.Forms.DataGridViewTextBoxColumn recValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recIsShow;
        private System.Windows.Forms.ContextMenuStrip uiContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 十六进制ToolStripMenuItem;
        public System.Windows.Forms.DataGridView recList;
    }
}