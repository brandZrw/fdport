
namespace FDPort.Controls
{
    partial class FieldFuncControl
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
            this.CmdFuncName = new FDPort.Controls.WaterTextBox();
            this.CmdFuncParam = new FDPort.Controls.WaterTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLabel2 = new System.Windows.Forms.Label();
            this.CmdFuncLen = new System.Windows.Forms.NumericUpDown();
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmdFuncLen)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdFuncName
            // 
            this.CmdFuncName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CmdFuncName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdFuncName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CmdFuncName.Location = new System.Drawing.Point(4, 5);
            this.CmdFuncName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdFuncName.MinimumSize = new System.Drawing.Size(4, 4);
            this.CmdFuncName.Name = "CmdFuncName";
            this.CmdFuncName.Size = new System.Drawing.Size(781, 34);
            this.CmdFuncName.TabIndex = 0;
            this.CmdFuncName.WaterText = "函数名";
            // 
            // CmdFuncParam
            // 
            this.CmdFuncParam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CmdFuncParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdFuncParam.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CmdFuncParam.Location = new System.Drawing.Point(4, 55);
            this.CmdFuncParam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdFuncParam.MinimumSize = new System.Drawing.Size(4, 4);
            this.CmdFuncParam.Name = "CmdFuncParam";
            this.CmdFuncParam.Size = new System.Drawing.Size(781, 34);
            this.CmdFuncParam.TabIndex = 1;
            this.CmdFuncParam.WaterText = "函数参数，比如1,3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CmdFuncName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CmdFuncParam, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uiLabel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 346);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.uiLabel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CmdFuncLen, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 102);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(543, 34);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(3, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(221, 34);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "返回值占用长度";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmdFuncLen
            // 
            this.CmdFuncLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdFuncLen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CmdFuncLen.Location = new System.Drawing.Point(231, 5);
            this.CmdFuncLen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdFuncLen.MinimumSize = new System.Drawing.Size(100, 0);
            this.CmdFuncLen.Name = "CmdFuncLen";
            this.CmdFuncLen.Size = new System.Drawing.Size(308, 34);
            this.CmdFuncLen.TabIndex = 1;
            this.CmdFuncLen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 180);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(783, 161);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "函数参数如果为数字则直接传入，带字母则会去查找字段，并带入字段的值。参数之间用逗号分隔。\r\npython脚本固定参数为一个byte数值，为当前接收或发送的数组，从" +
    "头开始到该字段之间的数据。\r\npython脚本需要放置在可执行文件下的function文件夹下\r\n";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FieldFuncControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FieldFuncControl";
            this.Size = new System.Drawing.Size(789, 346);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CmdFuncLen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WaterTextBox CmdFuncName;
        private WaterTextBox CmdFuncParam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label uiLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label uiLabel2;
        private System.Windows.Forms.NumericUpDown CmdFuncLen;
    }
}
