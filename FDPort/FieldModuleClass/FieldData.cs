using FDPort.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FDPort.FieldModuleClass
{
    /// <summary>
    /// 参数匹配类
    /// </summary>
    public class FieldData : FieldModule
    {
        public string link { get; set; }
        public enum DataType
        {
            NUM = 0,
            STRING
        };
        public DataType dataType;
        public override object List2Value(byte[] t)
        {
            throw new NotImplementedException();
        }
        public override byte[] Value2List(object v)
        {
            byte[] vs = null;
            if (dataType == DataType.NUM)
            {
                decimal t = 0;
                if (decimal.TryParse((string)v, out t))
                {
                    if (t == (int)t)//整数
                    {
                        vs = CopyTo(BitConverter.GetBytes(Decimal.ToInt64((int)t)));
                    }
                    else
                    {
                        vs = CopyTo(BitConverter.GetBytes(Decimal.ToDouble((decimal)t)));
                    }
                }
            }
            else
            {
                vs = System.Text.Encoding.UTF8.GetBytes((string)v.ToString());
                List<byte> ls = new List<byte>(vs);
                ls.Add(0);
                if (len == 0) // 长度为0时直接返回字符串数组
                {
                    return ls.ToArray();
                }
                else
                {
                    if (ls.Count >= len)
                    {
                        return ls.Take(len).ToArray();
                    }
                    else
                    {
                        byte[] temp = new byte[len];
                        ls.CopyTo(temp, 0);
                        return temp;
                    }
                }
            }
            return vs;
        }

        public override bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            useLen = len;
            object res = calc(link);

            byte[] s = Value2List(res.ToString());
            if (s != null)
            {
                return common.ByteEquals(b, s);
            }
            return false;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("绑定字段:");
            sb.Append(link);
            sb.Append(" len:");
            sb.Append(len.ToString());
            return sb.ToString();
        }
    }

}
