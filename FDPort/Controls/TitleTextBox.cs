using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDPort.Controls
{
    public partial class TitleTextBox : UserControl
    {
        public TitleTextBox()
        {
            InitializeComponent();
        }
        [Category("扩展属性"), Description("Title")]
        public string Title
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        [Category("扩展属性"), Description("按键文本")]
        public string BtnText
        {
            get { return button.Text; }
            set { button.Text = value; }
        }

        [Category("扩展属性"), Description("按键按下事件")]
        public event EventHandler ButtonClick;
        private void button_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(sender,e);
        }
    }
}
