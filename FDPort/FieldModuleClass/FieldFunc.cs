using FDPort.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDPort.FieldModuleClass
{
    /// <summary>
    /// python函数类
    /// </summary>
    public class FieldFunc : FieldModule
    {
        public string funcName { get; set; }
        public string[] funcParam { get; set; }
        public object returnValue { get; set; }
        public object run(byte[] b)
        {
            string[] temp = new string[funcParam.Length];
            for (int i = 0; i < funcParam.Length; i++)
            {
                temp[i] = calc(funcParam[i]).ToString();
            }
            return Project.RunPython("function\\" + funcName + ".py", b, temp);
        }
        public override object List2Value(byte[] t)
        {
            throw new NotImplementedException();
        }
        public override byte[] Value2List(object v)
        {
            byte[] b = (byte[])v;
            returnValue = run(b);
            if (returnValue == null)
            {
                return null;
            }
            int t = (int)returnValue;
            return CopyTo(BitConverter.GetBytes(t));

        }
        public override bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            useLen = len;
            returnValue = run(b);
            if (returnValue == null)
            {
                return false;
            }
            byte[] t = common.Object2Bytes(returnValue);
            return common.ByteEquals(CopyTo(t), vs);
            //return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("函数");
            sb.Append(funcName);
            sb.Append("(");
            sb.Append(string.Join(",", funcParam));
            sb.Append(");len:");
            sb.Append(len.ToString());
            return sb.ToString();
        }
    }
}
