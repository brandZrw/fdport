using FDPort.Class;
using System.Collections.Generic;
using System.Text;

namespace FDPort.FieldModuleClass
{
    /// <summary>
    /// 固定数值类
    /// </summary>
    public class FieldStatic : FieldModule
    {
        public bool isString { get; set; }
        private List<byte> _array = new List<byte>();
        public List<byte> array { get => _array; set { _array = value; } }
        public override object List2Value(byte[] t)
        {
            return array;
        }
        public override byte[] Value2List(object v)
        {
            return array.ToArray();
        }
        public override bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            if (common.ByteEquals(b, array.ToArray()))
            {
                useLen = array.Count;
                return true;
            }
            else
            {
                useLen = -1;
                return false;
            }

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("固定字符:");
            if (isString)
            {
                sb.Append(System.Text.Encoding.UTF8.GetString(array.ToArray()));
            }
            else
            {
                foreach (byte b in array)
                {
                    sb.Append(b.ToString("X2"));
                    sb.Append(" ");
                }
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
