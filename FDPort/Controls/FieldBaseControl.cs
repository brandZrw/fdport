using FDPort.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
