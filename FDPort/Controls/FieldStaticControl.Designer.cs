
namespace FDPort.Controls
{
    partial class FieldStaticControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdStaticValue = new FDPort.Controls.WaterTextBox();
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.cmdStaticIsString = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdStaticValue
            // 
            this.cmdStaticValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmdStaticValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdStaticValue.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdStaticValue.Location = new System.Drawing.Point(4, 5);
            this.cmdStaticValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdStaticValue.MinimumSize = new System.Drawing.Size(4, 4);
            this.cmdStaticValue.Name = "cmdStaticValue";
            this.cmdStaticValue.Size = new System.Drawing.Size(781, 34);
            this.cmdStaticValue.TabIndex = 0;
            this.cmdStaticValue.WaterText = "固定字符";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 79);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(380, 30);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "填入数据，十六进制类型需要用空格分隔";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdStaticIsString
            // 
            this.cmdStaticIsString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdStaticIsString.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdStaticIsString.Location = new System.Drawing.Point(3, 47);
            this.cmdStaticIsString.MinimumSize = new System.Drawing.Size(1, 1);
            this.cmdStaticIsString.Name = "cmdStaticIsString";
            this.cmdStaticIsString.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cmdStaticIsString.Size = new System.Drawing.Size(150, 29);
            this.cmdStaticIsString.TabIndex = 2;
            this.cmdStaticIsString.Text = "字符串类型";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cmdStaticIsString, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdStaticValue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiLabel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 346);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FieldStaticControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FieldStaticControl";
            this.Size = new System.Drawing.Size(789, 346);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WaterTextBox cmdStaticValue;
        private System.Windows.Forms.Label uiLabel1;
        private System.Windows.Forms.RadioButton cmdStaticIsString;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
