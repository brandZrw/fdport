using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDPort.Forms
{
    public class MyForm<T>: Form where T:Form
    {
        public static T instance;
        protected static object _lock = new object();
        public static T GetInstance(params object[] list)//一次性窗口
        {
            if (instance == null || instance.IsDisposed)
            {
                lock (_lock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = (T)Activator.CreateInstance(typeof(T),list);
                    }
                }
            }
            return instance;
        }
    }
}
