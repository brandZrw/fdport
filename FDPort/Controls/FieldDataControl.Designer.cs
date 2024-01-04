
namespace FDPort.Controls
{
    partial class FieldDataControl
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLabel2 = new System.Windows.Forms.Label();
            this.CmdDataLen = new System.Windows.Forms.NumericUpDown();
            this.CmdDataBind = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLabel3 = new System.Windows.Forms.Label();
            this.SelectType = new System.Windows.Forms.ComboBox();
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmdDataLen)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CmdDataBind, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uiLabel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(592, 277);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // tableLayoutPanel2
            //
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.uiLabel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CmdDataLen, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 39);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(588, 36);
            this.tableLayoutPanel2.TabIndex = 6;
            //
            // uiLabel2
            //
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(2, 0);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(118, 36);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "占用长度";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // CmdDataLen
            //
            this.CmdDataLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdDataLen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CmdDataLen.Location = new System.Drawing.Point(125, 4);
            this.CmdDataLen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdDataLen.MinimumSize = new System.Drawing.Size(75, 0);
            this.CmdDataLen.Name = "CmdDataLen";
            this.CmdDataLen.Size = new System.Drawing.Size(460, 29);
            this.CmdDataLen.TabIndex = 1;
            this.CmdDataLen.Value = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            //
            // CmdDataBind
            //
            this.CmdDataBind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CmdDataBind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdDataBind.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CmdDataBind.Location = new System.Drawing.Point(3, 4);
            this.CmdDataBind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdDataBind.MinimumSize = new System.Drawing.Size(4, 4);
            this.CmdDataBind.Name = "CmdDataBind";
            this.CmdDataBind.Size = new System.Drawing.Size(586, 29);
            this.CmdDataBind.TabIndex = 0;
            //
            // tableLayoutPanel3
            //
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.94508F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.05492F));
            this.tableLayoutPanel3.Controls.Add(this.uiLabel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.SelectType, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 79);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(588, 38);
            this.tableLayoutPanel3.TabIndex = 8;
            //
            // uiLabel3
            //
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(2, 0);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(119, 38);
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "绑定的数据类型";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // SelectType
            //
            this.SelectType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.SelectType.Items.AddRange(new object[]
            {
                "数字",
                "字符串"
            });
            this.SelectType.Location = new System.Drawing.Point(126, 4);
            this.SelectType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectType.MinimumSize = new System.Drawing.Size(48, 0);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(459, 29);
            this.SelectType.TabIndex = 1;
            //
            // uiLabel1
            //
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(2, 119);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(587, 138);
            this.uiLabel1.TabIndex = 7;
            this.uiLabel1.Text = "1、自动寻找绑定的字段名并带入相应数字。字符串类型，当长度设置为0时，则不受长度限制，占多少byte就会添加多少byte,并且末尾以0x00结束。\r\n2、优先绑定" +
                                 "设置区的字段，如果设置区找不到就会寻找接收区的字段。\r\n3、字段可以进行运算，比如绑定了字段ID，但是所需的内容是ID+1，则可以直接填入字段名ID+1。\r\n\r" +
                                 "\n";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // FieldDataControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FieldDataControl";
            this.Size = new System.Drawing.Size(592, 277);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CmdDataLen)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox CmdDataBind;
        private System.Windows.Forms.Label uiLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label uiLabel2;
        private System.Windows.Forms.NumericUpDown CmdDataLen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label uiLabel3;
        private System.Windows.Forms.ComboBox SelectType;
    }
}
