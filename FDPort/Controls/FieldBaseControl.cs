using FDPort.FieldModuleClass;
using System.Windows.Forms;

namespace FDPort.Controls
{
    public class FieldBaseControl : UserControl
    {
        public virtual FieldModule GetModule(string name)
        {
            return null;
        }
        public virtual void SetModule(FieldModule field)
        {
            return;
        }
    }
}
