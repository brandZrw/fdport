
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiButton1 = new System.Windows.Forms.Button();
            this.cmdDataGridList = new FDPort.Controls.MyDataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.autoSendTime = new System.Windows.Forms.TextBox();
            this.autoSend = new System.Windows.Forms.CheckBox();
            this.CmdSendName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uiButton2 = new System.Windows.Forms.Button();
            this.uiButton3 = new System.Windows.Forms.Button();
            this.recObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmdDataGridList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recObjBindingSource)).BeginInit();
            this.SuspendLayout();
            //
            // uiButton1
            //
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(642, 2);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(56, 32);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "新建";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            //
            // cmdDataGridList
            //
            this.cmdDataGridList.AllowDrop = true;
            this.cmdDataGridList.AllowUserToAddRows = false;
            this.cmdDataGridList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmdDataGridList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.cmdDataGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cmdDataGridList.BackgroundColor = System.Drawing.Color.White;
            this.cmdDataGridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdDataGridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.cmdDataGridList.ColumnHeadersHeight = 32;
            this.cmdDataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cmdDataGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.name,
                this.note,
                this.delete
            });
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cmdDataGridList.DefaultCellStyle = dataGridViewCellStyle10;
            this.cmdDataGridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDataGridList.EnableHeadersVisualStyles = false;
            this.cmdDataGridList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdDataGridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cmdDataGridList.Location = new System.Drawing.Point(2, 42);
            this.cmdDataGridList.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDataGridList.MultiSelect = false;
            this.cmdDataGridList.Name = "cmdDataGridList";
            this.cmdDataGridList.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdDataGridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.cmdDataGridList.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.cmdDataGridList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.cmdDataGridList.RowTemplate.Height = 27;
            this.cmdDataGridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cmdDataGridList.Size = new System.Drawing.Size(700, 282);
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
            this.name.Width = 98;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.NullValue = "删除";
            this.delete.DefaultCellStyle = dataGridViewCellStyle9;
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
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdDataGridList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 366);
            this.tableLayoutPanel1.TabIndex = 3;
            //
            // tableLayoutPanel2
            //
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Controls.Add(this.autoSendTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiButton1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.autoSend, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.CmdSendName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(700, 36);
            this.tableLayoutPanel2.TabIndex = 4;
            //
            // autoSendTime
            //
            this.autoSendTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.autoSendTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoSendTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.autoSendTime.Location = new System.Drawing.Point(102, 2);
            this.autoSendTime.Margin = new System.Windows.Forms.Padding(2);
            this.autoSendTime.MinimumSize = new System.Drawing.Size(4, 4);
            this.autoSendTime.Name = "autoSendTime";
            this.autoSendTime.Size = new System.Drawing.Size(416, 29);
            this.autoSendTime.TabIndex = 7;
            this.autoSendTime.Text = "1000";
            //
            // autoSend
            //
            this.autoSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.autoSend.Location = new System.Drawing.Point(522, 2);
            this.autoSend.Margin = new System.Windows.Forms.Padding(2);
            this.autoSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.autoSend.Name = "autoSend";
            this.autoSend.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.autoSend.Size = new System.Drawing.Size(116, 32);
            this.autoSend.TabIndex = 6;
            this.autoSend.Text = "是否连发";
            //
            // CmdSendName
            //
            this.CmdSendName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CmdSendName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdSendName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CmdSendName.Location = new System.Drawing.Point(2, 2);
            this.CmdSendName.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSendName.MinimumSize = new System.Drawing.Size(4, 4);
            this.CmdSendName.Name = "CmdSendName";
            this.CmdSendName.Size = new System.Drawing.Size(96, 29);
            this.CmdSendName.TabIndex = 8;
            //
            // tableLayoutPanel3
            //
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.uiButton2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiButton3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(512, 328);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(190, 36);
            this.tableLayoutPanel3.TabIndex = 5;
            //
            // uiButton2
            //
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(2, 2);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(66, 32);
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
            this.uiButton3.Location = new System.Drawing.Point(122, 2);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(66, 32);
            this.uiButton3.TabIndex = 1;
            this.uiButton3.Text = "确定";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            //
            // CmdSendStruct
            //
            this.AcceptButton = this.uiButton3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CmdSendStruct";
            this.Text = "发送命令";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmdSendStruct_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cmdDataGridList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TextBox CmdSendName;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private MyDataGridView cmdDataGridList;
    }
}