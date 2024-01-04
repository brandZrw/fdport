using FDPort.Class;
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
    public partial class FieldFuncControl : FieldBaseControl
    {
        public FieldFuncControl()
        {
            InitializeComponent();
        }
        public override void SetModule(FieldModule field)
        {
            FieldFunc cmd = field as FieldFunc;
            CmdFuncLen.Value = cmd.len;
            CmdFuncName.Text = cmd.funcName;
            if (cmd.funcParam != null)
            {
                CmdFuncParam.Text = string.Join(",", cmd.funcParam);
            }

        }
        public override FieldModule GetModule(string name)
        {
            FieldFunc cmd = new FieldFunc();
            cmd.name = name;
            cmd.type = FieldModule.CM_Type.CM_FUNC;
            cmd.len = decimal.ToInt32(CmdFuncLen.Value);
            cmd.funcName = CmdFuncName.Text;
            if (CmdFuncParam.Text != null)
            {
                cmd.funcParam = CmdFuncParam.Text.Replace("，", ",").Split(',');
            }

            return cmd;
        }
    }
}
