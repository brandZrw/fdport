
namespace FDPort.Controls
{
    partial class FieldByteControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLabel2 = new System.Windows.Forms.Label();
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.uiComboBox1 = new System.Windows.Forms.ComboBox();
            this.cmdByteLen = new System.Windows.Forms.NumericUpDown();
            this.uiLabel3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.uiLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdByteLen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uiComboBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uiLabel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 346);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // uiLabel2
            //
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(3, 39);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(214, 34);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "数据类型";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // uiLabel1
            //
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(214, 34);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "长度（占多少个byte）";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // uiComboBox1
            //
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox1.Items.AddRange(new object[]
            {
                "无符号整型",
                "INT8",
                "INT16",
                "INT32",
                "INT64",
                "浮点型",
                "字符串类型"
            });
            this.uiComboBox1.Location = new System.Drawing.Point(224, 44);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox1.TabIndex = 2;
            //
            // cmdByteLen
            //
            this.cmdByteLen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdByteLen.Location = new System.Drawing.Point(224, 5);
            this.cmdByteLen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdByteLen.MinimumSize = new System.Drawing.Size(100, 0);
            this.cmdByteLen.Name = "cmdByteLen";
            this.cmdByteLen.Size = new System.Drawing.Size(116, 29);
            this.cmdByteLen.TabIndex = 3;
            this.cmdByteLen.Text = null;
            this.cmdByteLen.Value = 1;
            //
            // uiLabel3
            //
            this.tableLayoutPanel1.SetColumnSpan(this.uiLabel3, 2);
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(3, 78);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(783, 99);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "按照长度自动匹配相对应的数组。如果类型为字符串类型则按UTF-8编码进行编解码，此时如果长度为0，则默认匹配到末尾或者出现0x00，如果长度不为0则按长度匹配";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // FieldByteControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FieldByteControl";
            this.Size = new System.Drawing.Size(789, 346);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label uiLabel1;
        private System.Windows.Forms.ComboBox uiComboBox1;
        private System.Windows.Forms.NumericUpDown cmdByteLen;
        private System.Windows.Forms.Label uiLabel2;
        private System.Windows.Forms.Label uiLabel3;
    }
}
