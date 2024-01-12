
using FDPort.Controls;

namespace FDPort.Forms
{
    partial class CmdSendStruct
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
            this.uiButton1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.autoSendTime = new System.Windows.Forms.TextBox();
            this.autoSend = new System.Windows.Forms.CheckBox();
            this.CmdSendName = new FDPort.Controls.WaterTextBox();
            this.cmdDataGridList = new FDPort.Controls.MyDataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uiButton2 = new System.Windows.Forms.Button();
            this.uiButton3 = new System.Windows.Forms.Button();
            this.recObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDataGridList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recObjBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(856, 2);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(74, 42);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "新建";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdDataGridList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 458);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.autoSendTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiButton1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.autoSend, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.CmdSendName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(933, 46);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // autoSendTime
            // 
            this.autoSendTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.autoSendTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoSendTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.autoSendTime.Location = new System.Drawing.Point(136, 2);
            this.autoSendTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoSendTime.MinimumSize = new System.Drawing.Size(4, 4);
            this.autoSendTime.Name = "autoSendTime";
            this.autoSendTime.Size = new System.Drawing.Size(554, 34);
            this.autoSendTime.TabIndex = 7;
            this.autoSendTime.Text = "1000";
            // 
            // autoSend
            // 
            this.autoSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.autoSend.Location = new System.Drawing.Point(696, 2);
            this.autoSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.autoSend.Name = "autoSend";
            this.autoSend.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.autoSend.Size = new System.Drawing.Size(154, 42);
            this.autoSend.TabIndex = 6;
            this.autoSend.Text = "是否连发";
            // 
            // CmdSendName
            // 
            this.CmdSendName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CmdSendName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdSendName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CmdSendName.Location = new System.Drawing.Point(3, 2);
            this.CmdSendName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdSendName.MinimumSize = new System.Drawing.Size(4, 4);
            this.CmdSendName.Name = "CmdSendName";
            this.CmdSendName.Size = new System.Drawing.Size(127, 34);
            this.CmdSendName.TabIndex = 8;
            this.CmdSendName.WaterText = "命令名称";
            // 
            // cmdDataGridList
            // 
            this.cmdDataGridList.AllowDrop = true;
            this.cmdDataGridList.AllowUserToAddRows = false;
            this.cmdDataGridList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmdDataGridList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cmdDataGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cmdDataGridList.BackgroundColor = System.Drawing.Color.White;
            this.cmdDataGridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdDataGridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cmdDataGridList.ColumnHeadersHeight = 32;
            this.cmdDataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cmdDataGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.note,
            this.delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cmdDataGridList.DefaultCellStyle = dataGridViewCellStyle4;
            this.cmdDataGridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDataGridList.EnableHeadersVisualStyles = false;
            this.cmdDataGridList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdDataGridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cmdDataGridList.Location = new System.Drawing.Point(3, 52);
            this.cmdDataGridList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDataGridList.MultiSelect = false;
            this.cmdDataGridList.Name = "cmdDataGridList";
            this.cmdDataGridList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdDataGridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.cmdDataGridList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.cmdDataGridList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.cmdDataGridList.RowTemplate.Height = 27;
            this.cmdDataGridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cmdDataGridList.Size = new System.Drawing.Size(933, 354);
            this.cmdDataGridList.TabIndex = 2;
            this.cmdDataGridList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.cmdDataGridList_RowsRemoved);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name.FillWeight = 1F;
            this.name.HeaderText = "字段名称";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 120;
            // 
            // note
            // 
            this.note.FillWeight = 3F;
            this.note.HeaderText = "字段描述";
            this.note.MinimumWidth = 6;
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.NullValue = "删除";
            this.delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.delete.FillWeight = 1F;
            this.delete.HeaderText = "删除";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Text = "删除";
            this.delete.ToolTipText = "删除";
            this.delete.Width = 60;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.uiButton2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiButton3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(683, 410);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(253, 46);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(3, 2);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(88, 40);
            this.uiButton2.TabIndex = 0;
            this.uiButton2.Text = "取消";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uiButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton3.Location = new System.Drawing.Point(162, 2);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(88, 42);
            this.uiButton3.TabIndex = 1;
            this.uiButton3.Text = "确定";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // CmdSendStruct
            // 
            this.AcceptButton = this.uiButton3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 458);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CmdSendStruct";
            this.Text = "发送命令";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmdSendStruct_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDataGridList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recObjBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uiButton1;
        private System.Windows.Forms.BindingSource recObjBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox autoSend;
        private System.Windows.Forms.TextBox autoSendTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button uiButton2;
        private System.Windows.Forms.Button uiButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private MyDataGridView cmdDataGridList;
        private WaterTextBox CmdSendName;
    }
}