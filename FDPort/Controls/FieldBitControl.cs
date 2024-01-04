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
    public partial class FieldBitControl : FieldBaseControl
    {
        public FieldBitControl()
        {
            InitializeComponent();
        }
        public override void SetModule(FieldModule field)
        {
            FieldBit cmd = (FieldBit)field;
            cmdBitLen.Value = cmd.len;
            bindName.Text = cmd.parent;
            cmdStartIndex.Value = cmd.startIndex;
        }
        public override FieldModule GetModule(string name)
        {
            FieldBit cmd = new FieldBit();
            cmd.name = name;
            cmd.len = decimal.ToInt32(cmdBitLen.Value);
            cmd.type = FieldModule.CM_Type.CM_BIT;
            cmd.parent = bindName.Text;
            cmd.startIndex = decimal.ToInt32(cmdStartIndex.Value);
            return cmd;
        }
    }
}
