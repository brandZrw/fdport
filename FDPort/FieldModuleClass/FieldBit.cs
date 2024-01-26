using System;
using System.Text;
namespace FDPort.FieldModuleClass
{
    /// <summary>
    /// bit字段类
    /// </summary>
    public class FieldBit : FieldModule
    {
        public string parent { get; set; }
        public int startIndex { get; set; }

        public UInt64 GetBitValue(decimal value)
        {
            UInt64 t = (UInt64)value;
            return ((t >> startIndex) & ((UInt64)(1 << len) - 1));
        }
        public override object List2Value(byte[] t)
        {
            UInt64 value = BitConverter.ToUInt64(t, 0);
            return GetBitValue(value);
        }
        public override byte[] Value2List(object v)
        {
            return null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(parent);
            sb.Append("的位域[");
            sb.Append(startIndex.ToString());
            sb.Append(',');
            sb.Append(len.ToString());
            sb.Append("]");
            return sb.ToString();
        }
        public override bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            useLen = 0;
            return true;
        }
    }
}
