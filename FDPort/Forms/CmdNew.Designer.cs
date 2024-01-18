
using FDPort.Controls;

namespace FDPort.Forms
{
    partial class CmdNew
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
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.cmdTypeChoose = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uiButton1 = new System.Windows.Forms.Button();
            this.cmdByte1 = new FDPort.Controls.FieldByteControl();
            this.cmdStatic1 = new FDPort.Controls.FieldStaticControl();
            this.cmdDataControl1 = new FDPort.Controls.FieldDataControl();
            this.cmdFuncControl1 = new FDPort.Controls.FieldFuncControl();
            this.cmdBitControl1 = new FDPort.Controls.FieldBitControl();
            this.cmdName = new FDPort.Controls.WaterTextBox();
            this.panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(4, 5);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(76, 42);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "字段名";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdTypeChoose
            // 
            this.cmdTypeChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdTypeChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdTypeChoose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdTypeChoose.Items.AddRange(new object[] {
            "固定数值",
            "byte数组",
            "位域（必须先定义一个整型）",
            "函数",
            "设置的参数"});
            this.cmdTypeChoose.Location = new System.Drawing.Point(247, 5);
            this.cmdTypeChoose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdTypeChoose.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmdTypeChoose.Name = "cmdTypeChoose";
            this.cmdTypeChoose.Size = new System.Drawing.Size(525, 35);
            this.cmdTypeChoose.TabIndex = 2;
            this.cmdTypeChoose.SelectedIndexChanged += new System.EventHandler(this.cmdTypeChoose_SelectedIndexChanged);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cmdByte1);
            this.panel.Controls.Add(this.cmdStatic1);
            this.panel.Controls.Add(this.cmdDataControl1);
            this.panel.Controls.Add(this.cmdFuncControl1);
            this.panel.Controls.Add(this.cmdBitControl1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 58);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(933, 398);
            this.panel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 458);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.cmdName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdTypeChoose, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiButton1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiLabel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(933, 52);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(780, 5);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(149, 42);
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "确定";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // cmdByte1
            // 
            this.cmdByte1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdByte1.Location = new System.Drawing.Point(0, 0);
            this.cmdByte1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdByte1.Name = "cmdByte1";
            this.cmdByte1.Size = new System.Drawing.Size(933, 398);
            this.cmdByte1.TabIndex = 1;
            // 
            // cmdStatic1
            // 
            this.cmdStatic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdStatic1.Location = new System.Drawing.Point(0, 0);
            this.cmdStatic1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdStatic1.Name = "cmdStatic1";
            this.cmdStatic1.Size = new System.Drawing.Size(933, 398);
            this.cmdStatic1.TabIndex = 0;
            // 
            // cmdDataControl1
            // 
            this.cmdDataControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDataControl1.Location = new System.Drawing.Point(0, 0);
            this.cmdDataControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdDataControl1.Name = "cmdDataControl1";
            this.cmdDataControl1.Size = new System.Drawing.Size(933, 398);
            this.cmdDataControl1.TabIndex = 5;
            // 
            // cmdFuncControl1
            // 
            this.cmdFuncControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdFuncControl1.Location = new System.Drawing.Point(0, 0);
            this.cmdFuncControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdFuncControl1.Name = "cmdFuncControl1";
            this.cmdFuncControl1.Size = new System.Drawing.Size(933, 398);
            this.cmdFuncControl1.TabIndex = 3;
            // 
            // cmdBitControl1
            // 
            this.cmdBitControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdBitControl1.Location = new System.Drawing.Point(0, 0);
            this.cmdBitControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBitControl1.Name = "cmdBitControl1";
            this.cmdBitControl1.Size = new System.Drawing.Size(933, 398);
            this.cmdBitControl1.TabIndex = 2;
            // 
            // cmdName
            // 
            this.cmdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmdName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdName.Location = new System.Drawing.Point(88, 5);
            this.cmdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdName.MinimumSize = new System.Drawing.Size(4, 4);
            this.cmdName.Name = "cmdName";
            this.cmdName.Size = new System.Drawing.Size(151, 34);
            this.cmdName.TabIndex = 0;
            this.cmdName.WaterText = "字段名称";
            // 
            // CmdNew
            // 
            this.AcceptButton = this.uiButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 458);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CmdNew";
            this.TabText = "CmdNew";
            this.Text = "CmdNew";
            this.Activated += new System.EventHandler(this.CmdNew_Activated);
            this.panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uiLabel1;
        private WaterTextBox cmdName;
        private System.Windows.Forms.ComboBox cmdTypeChoose;
        private System.Windows.Forms.Panel panel;
        private Controls.FieldStaticControl cmdStatic1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button uiButton1;
        private Controls.FieldByteControl cmdByte1;
        private Controls.FieldBitControl cmdBitControl1;
        private Controls.FieldFuncControl cmdFuncControl1;
        private Controls.FieldDataControl cmdDataControl1;
    }
}