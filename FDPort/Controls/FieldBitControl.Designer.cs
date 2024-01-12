
namespace FDPort.Controls
{
    partial class FieldBitControl
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
            this.bindName = new FDPort.Controls.WaterTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.cmdStartIndex = new System.Windows.Forms.NumericUpDown();
            this.cmdBitLen = new System.Windows.Forms.NumericUpDown();
            this.uiLabel2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdStartIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBitLen)).BeginInit();
            this.SuspendLayout();
            // 
            // bindName
            // 
            this.bindName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.bindName, 5);
            this.bindName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bindName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bindName.Location = new System.Drawing.Point(4, 5);
            this.bindName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bindName.MinimumSize = new System.Drawing.Size(4, 4);
            this.bindName.Name = "bindName";
            this.bindName.Size = new System.Drawing.Size(569, 34);
            this.bindName.TabIndex = 1;
            this.bindName.WaterText = "绑定的字段名";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.Controls.Add(this.bindName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiLabel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmdStartIndex, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmdBitLen, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.uiLabel2, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(577, 254);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(4, 45);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(118, 34);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "起始比特位";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdStartIndex
            // 
            this.cmdStartIndex.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdStartIndex.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdStartIndex.Location = new System.Drawing.Point(130, 45);
            this.cmdStartIndex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdStartIndex.MinimumSize = new System.Drawing.Size(100, 0);
            this.cmdStartIndex.Name = "cmdStartIndex";
            this.cmdStartIndex.Size = new System.Drawing.Size(118, 34);
            this.cmdStartIndex.TabIndex = 2;
            // 
            // cmdBitLen
            // 
            this.cmdBitLen.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdBitLen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmdBitLen.Location = new System.Drawing.Point(451, 45);
            this.cmdBitLen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBitLen.MinimumSize = new System.Drawing.Size(100, 0);
            this.cmdBitLen.Name = "cmdBitLen";
            this.cmdBitLen.Size = new System.Drawing.Size(122, 34);
            this.cmdBitLen.TabIndex = 4;
            this.cmdBitLen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(325, 45);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(118, 34);
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "字段长度";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FieldBitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FieldBitControl";
            this.Size = new System.Drawing.Size(577, 254);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdStartIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBitLen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown cmdStartIndex;
        private System.Windows.Forms.Label uiLabel1;
        private System.Windows.Forms.NumericUpDown cmdBitLen;
        private System.Windows.Forms.Label uiLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private WaterTextBox bindName;
    }
}
