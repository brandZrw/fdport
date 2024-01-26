using FDPort.FieldModuleClass;


namespace FDPort.Controls
{
    public partial class FieldDataControl : FieldBaseControl
    {
        public FieldDataControl()
        {
            InitializeComponent();
            SelectType.SelectedIndex = 0;
        }
        public override void SetModule(FieldModule field)
        {
            FieldData cmd = (FieldData)field;
            CmdDataBind.Text = cmd.link;
            CmdDataLen.Value = cmd.len;
            SelectType.SelectedIndex = (int)cmd.dataType;
        }
        public override FieldModule GetModule(string name)
        {
            FieldData cmd = new FieldData();
            cmd.name = name;
            cmd.type = FieldModule.CM_Type.CM_DATA;
            cmd.link = CmdDataBind.Text;
            cmd.len = decimal.ToInt32(CmdDataLen.Value);
            cmd.dataType = (FieldData.DataType)SelectType.SelectedIndex;
            return cmd;
        }
    }
}
