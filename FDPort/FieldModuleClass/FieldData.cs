using FDPort.Class;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                vs = common.String2Byte(v.ToString(),len);
            }
            return vs;
        }

        public override bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            
            useLen = len;
            object res = calc(link);
            byte[] s = null;

            if (dataType == DataType.NUM)
            {
                decimal t = (decimal)res;
                Int64 temp = decimal.ToInt64(t);
                if (temp == t)//整数
                {
                    s = CopyTo(BitConverter.GetBytes(temp));
                }
                else
                {
                    s = CopyTo(BitConverter.GetBytes(Decimal.ToDouble(t)));
                }
            }
            else
            {
                s = common.String2Byte(res.ToString(),len);
            }
            if (s != null)
            {
                bool re = common.ByteEquals(b, s);
                return re;
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
