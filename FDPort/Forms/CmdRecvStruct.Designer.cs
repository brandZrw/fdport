﻿
using FDPort.Controls;

namespace FDPort.Forms
{
    partial class CmdRecvStruct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiButton1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.autoReply = new System.Windows.Forms.CheckBox();
            this.CmdSendName = new System.Windows.Forms.TextBox();
            this.replyCmd = new System.Windows.Forms.ComboBox();
            this.recObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdDataGridList = new FDPort.Controls.MyDataGridView();
            this.uiButton3 = new System.Windows.Forms.Button();
            this.uiButton2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDataGridList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            //
            // uiButton1
            //
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(507, 2);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(53, 30);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "新建";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            //
            // tableLayoutPanel2
            //
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Controls.Add(this.uiButton1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.autoReply, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.CmdSendName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.replyCmd, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(700, 36);
            this.tableLayoutPanel2.TabIndex = 4;
            //
            // autoReply
            //
            this.autoReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoReply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoReply.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.autoReply.Location = new System.Drawing.Point(390, 2);
            this.autoReply.Margin = new System.Windows.Forms.Padding(2);
            this.autoReply.MinimumSize = new System.Drawing.Size(1, 1);
            this.autoReply.Name = "autoReply";
            this.autoReply.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.autoReply.Size = new System.Drawing.Size(113, 30);
            this.autoReply.TabIndex = 6;
            this.autoReply.Text = "是否回复";
            //
            // CmdSendName
            //
            this.CmdSendName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CmdSendName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdSendName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CmdSendName.Location = new System.Drawing.Point(2, 2);
            this.CmdSendName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdSendName.MinimumSize = new System.Drawing.Size(4, 4);
            this.CmdSendName.Name = "CmdSendName";
            this.CmdSendName.Size = new System.Drawing.Size(96, 29);
            this.CmdSendName.TabIndex = 8;
            //
            // replyCmd
            //
            this.replyCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replyCmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.replyCmd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.replyCmd.Location = new System.Drawing.Point(102, 2);
            this.replyCmd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.replyCmd.MinimumSize = new System.Drawing.Size(32, 0);
            this.replyCmd.Name = "replyCmd";
            this.replyCmd.Size = new System.Drawing.Size(284, 29);
            this.replyCmd.TabIndex = 9;
            //
            // cmdDataGridList
            //
            this.cmdDataGridList.AllowDrop = true;
            this.cmdDataGridList.AllowUserToAddRows = false;
            this.cmdDataGridList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmdDataGridList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.cmdDataGridList.BackgroundColor = System.Drawing.Color.White;
            this.cmdDataGridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdDataGridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.cmdDataGridList.ColumnHeadersHeight = 32;
            this.cmdDataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cmdDataGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.name,
                this.note,
                this.delete
            });
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cmdDataGridList.DefaultCellStyle = dataGridViewCellStyle28;
            this.cmdDataGridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDataGridList.EnableHeadersVisualStyles = false;
            this.cmdDataGridList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdDataGridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cmdDataGridList.Location = new System.Drawing.Point(2, 42);
            this.cmdDataGridList.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDataGridList.MultiSelect = false;
            this.cmdDataGridList.Name = "cmdDataGridList";
            this.cmdDataGridList.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdDataGridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.cmdDataGridList.RowHeadersWidth = 51;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            this.cmdDataGridList.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.cmdDataGridList.RowTemplate.Height = 27;
            this.cmdDataGridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cmdDataGridList.Size = new System.Drawing.Size(700, 282);
            this.cmdDataGridList.TabIndex = 2;
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
            // uiButton2
            //
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiButton2.Dock = System.Windows.Forms.DockStyle.Left;
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
            // tableLayoutPanel4
            //
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.cmdDataGridList, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(704, 366);
            this.tableLayoutPanel4.TabIndex = 5;
            //
            // name
            //
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 30F;
            this.name.HeaderText = "字段名称";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // note
            //
            this.note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.note.FillWeight = 60F;
            this.note.HeaderText = "字段描述";
            this.note.MinimumWidth = 6;
            this.note.Name = "note";
            this.note.ReadOnly = true;
            //
            // delete
            //
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle27.NullValue = "删除";
            this.delete.DefaultCellStyle = dataGridViewCellStyle27;
            this.delete.FillWeight = 10F;
            this.delete.HeaderText = "删除";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Text = "删除";
            this.delete.ToolTipText = "删除";
            //
            // CmdRecvStruct
            //
            this.AcceptButton = this.uiButton3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 366);
            this.Controls.Add(this.tableLayoutPanel4);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CmdRecvStruct";
            this.Text = "接收命令";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmdRecvStruct_KeyDown);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDataGridList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyDataGridView cmdDataGridList;
        private System.Windows.Forms.Button uiButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox autoReply;
        private System.Windows.Forms.TextBox CmdSendName;
        private System.Windows.Forms.BindingSource recObjBindingSource;
        private System.Windows.Forms.ComboBox replyCmd;
        private System.Windows.Forms.Button uiButton3;
        private System.Windows.Forms.Button uiButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}