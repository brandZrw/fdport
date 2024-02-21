using FDPort.FieldModuleClass;
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
    public partial class FieldRegexControl : FieldBaseControl
    {
        public FieldRegexControl()
        {
            InitializeComponent();
        

        }
        public override void SetModule(FieldModule field)
        {
            FieldRegex cmd = (FieldRegex)field;
            RegexStr.Text = cmd.regexStr;
        }
        public override FieldModule GetModule(string name)
        {
            FieldRegex cmd = new FieldRegex();
            cmd.name = name;
            cmd.type = FieldModule.CM_Type.CM_REGEX;
            cmd.SetRegex(RegexStr.Text);
            return cmd;
        }
    }
}
