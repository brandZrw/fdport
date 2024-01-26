using FDPort.FieldModuleClass;
using static FDPort.FieldModuleClass.FieldByte;

namespace FDPort.Controls
{
    public partial class FieldByteControl : FieldBaseControl
    {
        public FieldByteControl()
        {
            InitializeComponent();
            uiComboBox1.SelectedIndex = 0;
        }
        public override void SetModule(FieldModule field)
        {
            FieldByte cmd = (FieldByte)field;
            cmdByteLen.Value = cmd.len;
            uiComboBox1.SelectedIndex = (int)cmd.byteType;
        }
        public override FieldModule GetModule(string name)
        {
            FieldByte cmd = new FieldByte();
            cmd.name = name;
            cmd.len = decimal.ToInt32(cmdByteLen.Value);
            cmd.type = FieldModule.CM_Type.CM_BYTE;
            cmd.byteType = (CM_BYTE_TYPE)uiComboBox1.SelectedIndex;
            return cmd;
        }
    }
}
