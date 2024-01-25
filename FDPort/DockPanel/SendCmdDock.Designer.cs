
namespace FDPort.DockPanel
{
    partial class SendCmdDock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmdTimer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmdTimerParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmdList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmdList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cmdList.BackgroundColor = System.Drawing.Color.White;
            this.cmdList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.cmdList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cmdList.ColumnHeadersHeight = 32;
            this.cmdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cmdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cmdSend,
            this.cmdTimer,
            this.cmdTimerParam});
            this.cmdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdList.EnableHeadersVisualStyles = false;
            this.cmdList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cmdList.Location = new System.Drawing.Point(0, 0);
            this.cmdList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdList.Name = "cmdList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.cmdList.RowHeadersVisible = false;
            this.cmdList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 8F);
            this.cmdList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.cmdList.RowTemplate.Height = 23;
            this.cmdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cmdList.Size = new System.Drawing.Size(435, 562);
            this.cmdList.TabIndex = 5;
            this.cmdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cmdList_CellContentClick);
            this.cmdList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cmdList_CellMouseDoubleClick);
            this.cmdList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.cmdList_RowsRemoved);
            this.cmdList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "发送";
            this.cmdSend.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.NullValue = "1000";
            this.cmdTimerParam.DefaultCellStyle = dataGridViewCellStyle4;
            this.cmdTimerParam.FillWeight = 20F;
            this.cmdTimerParam.HeaderText = " 间隔";
            this.cmdTimerParam.MinimumWidth = 6;
            this.cmdTimerParam.Name = "cmdTimerParam";
            this.cmdTimerParam.ReadOnly = true;
            // 
            // SendCmdDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 562);
            this.Controls.Add(this.cmdList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendCmdDock";
            this.TabText = "SendCmd";
            this.Text = "SendCmd";
            ((System.ComponentModel.ISupportInitialize)(this.cmdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn cmdSend;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmdTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdTimerParam;
        public System.Windows.Forms.DataGridView cmdList;
    }
}