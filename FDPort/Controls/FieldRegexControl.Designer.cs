
namespace FDPort.Controls
{
    partial class FieldRegexControl
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
            this.RegexStr = new FDPort.Controls.WaterTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.RegexStr, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 346);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RegexStr
            // 
            this.RegexStr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegexStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegexStr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RegexStr.Location = new System.Drawing.Point(4, 5);
            this.RegexStr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegexStr.MinimumSize = new System.Drawing.Size(4, 4);
            this.RegexStr.Multiline = true;
            this.RegexStr.Name = "RegexStr";
            this.RegexStr.Size = new System.Drawing.Size(781, 93);
            this.RegexStr.TabIndex = 1;
            this.RegexStr.WaterText = "正则表达式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 243);
            this.label1.TabIndex = 2;
            this.label1.Text = "使用正则表达式进行匹配，需要匹配的参数使用分组命名\r\n\r\n例子：接收到数据为power:32V\r\n\r\n正则表达式为power:(?<volt>\\d*)V\r\n\r\n在" +
    "接收区域的volt参数就会更改为32(字符串类型)\r\n\r\n具体正则表达式的规则请自行查询\r\n";
            // 
            // FieldRegexControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FieldRegexControl";
            this.Size = new System.Drawing.Size(789, 346);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private WaterTextBox RegexStr;
        private System.Windows.Forms.Label label1;
    }
}
