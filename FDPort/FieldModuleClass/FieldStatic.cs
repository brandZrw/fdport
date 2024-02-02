using FDPort.Class;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FDPort.FieldModuleClass
{
    /// <summary>
    /// 固定数值类
    /// </summary>
    public class FieldStatic : FieldModule
    {
        public bool isString { get; set; }
        private byte[] _array = new byte[0];
        public byte[] array { get => _array; set { _array = value; } }
        public override object List2Value(byte[] t)
        {
            return array;
        }
        public override byte[] Value2List(object v)
        {
            return array;
        }
        public override bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            if (common.ByteEquals(b, array))
            {
                useLen = array.Length;
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
                sb.Append(System.Text.Encoding.UTF8.GetString(array));
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
