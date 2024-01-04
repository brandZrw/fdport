
namespace FDPort.Forms
{
    partial class UartMore
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
            this.uiLabel5 = new System.Windows.Forms.Label();
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.uiLabel2 = new System.Windows.Forms.Label();
            this.dataBits = new System.Windows.Forms.ComboBox();
            this.stopBits = new System.Windows.Forms.ComboBox();
            this.parity = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // uiLabel5
            //
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(2, 23);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(79, 26);
            this.uiLabel5.TabIndex = 11;
            this.uiLabel5.Text = "数据位";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // uiLabel1
            //
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(2, 56);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(79, 26);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "停止位";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // uiLabel2
            //
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(2, 89);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(79, 26);
            this.uiLabel2.TabIndex = 15;
            this.uiLabel2.Text = "校验方式";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // dataBits
            //
            this.dataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBits.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataBits.Items.AddRange(new object[]
            {
                "8",
                "7",
                "6",
                "5"
            });
            this.dataBits.Location = new System.Drawing.Point(85, 23);
            this.dataBits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataBits.MinimumSize = new System.Drawing.Size(34, 0);
            this.dataBits.Name = "dataBits";
            this.dataBits.Size = new System.Drawing.Size(129, 27);
            this.dataBits.TabIndex = 17;
            //
            // stopBits
            //
            this.stopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBits.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopBits.Items.AddRange(new object[]
            {
                "1",
                "1.5",
                "2"
            });
            this.stopBits.Location = new System.Drawing.Point(85, 58);
            this.stopBits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopBits.MinimumSize = new System.Drawing.Size(34, 0);
            this.stopBits.Name = "stopBits";
            this.stopBits.Size = new System.Drawing.Size(129, 27);
            this.stopBits.TabIndex = 18;
            //
            // parity
            //
            this.parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parity.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parity.Items.AddRange(new object[]
            {
                "None",
                "Odd",
                "Even",
                "Mark",
                "Space"
            });
            this.parity.Location = new System.Drawing.Point(85, 93);
            this.parity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parity.MinimumSize = new System.Drawing.Size(34, 0);
            this.parity.Name = "parity";
            this.parity.Size = new System.Drawing.Size(129, 27);
            this.parity.TabIndex = 18;
            //
            // button1
            //
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(138, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "确定";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // UartMore
            //
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parity);
            this.Controls.Add(this.stopBits);
            this.Controls.Add(this.dataBits);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel5);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UartMore";
            this.Text = "串口详情";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uiLabel5;
        private System.Windows.Forms.Label uiLabel1;
        private System.Windows.Forms.Label uiLabel2;
        private System.Windows.Forms.ComboBox dataBits;
        private System.Windows.Forms.ComboBox stopBits;
        private System.Windows.Forms.ComboBox parity;
        private System.Windows.Forms.Button button1;
    }
}