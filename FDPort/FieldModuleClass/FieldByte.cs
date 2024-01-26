using FDPort.Class;
using System;
using System.Linq;
using System.Text;

namespace FDPort.FieldModuleClass
{
    /// <summary>
    /// byte数组匹配类
    /// </summary>
    public class FieldByte : FieldModule
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("byte数组:");
            switch (byteType)
            {
                case CM_BYTE_TYPE.CM_BYTE_UINT:
                    sb.Append("无符号整型");
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT8:
                    sb.Append("int8");
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT16:
                    sb.Append("int16");
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT32:
                    sb.Append("int32");
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT64:
                    sb.Append("int64");
                    break;
                case CM_BYTE_TYPE.CM_BYTE_DOUBLE:
                    sb.Append("浮点型");
                    break;
                case CM_BYTE_TYPE.CM_BYTE_STRING:
                    sb.Append("字符串");
                    break;
            }
            sb.Append(";len:");
            sb.Append(len.ToString());
            return sb.ToString();
        }

        public enum CM_BYTE_TYPE
        {
            CM_BYTE_UINT,
            CM_BYTE_INT8,
            CM_BYTE_INT16,
            CM_BYTE_INT32,
            CM_BYTE_INT64,
            CM_BYTE_DOUBLE,
            CM_BYTE_STRING,
        };
        public CM_BYTE_TYPE byteType { get; set; }

        public override byte[] Value2List(object v)
        {
            switch (byteType)
            {
                case CM_BYTE_TYPE.CM_BYTE_UINT:
                    return CopyTo(BitConverter.GetBytes((UInt64)v));
                case CM_BYTE_TYPE.CM_BYTE_INT8:
                    return CopyTo(BitConverter.GetBytes((byte)v));
                case CM_BYTE_TYPE.CM_BYTE_INT16:
                    return CopyTo(BitConverter.GetBytes((Int16)v));
                case CM_BYTE_TYPE.CM_BYTE_INT32:
                    return CopyTo(BitConverter.GetBytes((Int32)v));
                case CM_BYTE_TYPE.CM_BYTE_INT64:
                    return CopyTo(BitConverter.GetBytes((Int64)v));
                case CM_BYTE_TYPE.CM_BYTE_DOUBLE:
                    return CopyTo(BitConverter.GetBytes((double)v));
                case CM_BYTE_TYPE.CM_BYTE_STRING:
                    return common.String2Byte((string)v, len);
            }
            return null;
        }

        // 补齐数组以保证convert可以正常进行
        private byte[] byteArr2byteArr(byte[] m)
        {
            int len = 0;
            switch (byteType)
            {
                case CM_BYTE_TYPE.CM_BYTE_UINT:
                    len = sizeof(UInt64);
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT8:
                    len = sizeof(byte);
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT16:
                    len = sizeof(Int16);
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT32:
                    len = sizeof(Int32);
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT64:
                    len = sizeof(Int64);
                    break;
                case CM_BYTE_TYPE.CM_BYTE_DOUBLE:
                    len = sizeof(double);
                    break;
                case CM_BYTE_TYPE.CM_BYTE_STRING:
                    return null;
            }
            return ByteArrChangeLen(m, len, true);
        }
        public override object List2Value(byte[] m)
        {
            byte[] t = byteArr2byteArr(m);
            switch (byteType)
            {
                case CM_BYTE_TYPE.CM_BYTE_UINT:
                    return BitConverter.ToUInt64(t, 0);
                case CM_BYTE_TYPE.CM_BYTE_INT8:
                    return t[0];
                case CM_BYTE_TYPE.CM_BYTE_INT16:
                    return BitConverter.ToInt16(t, 0);
                case CM_BYTE_TYPE.CM_BYTE_INT32:
                    return BitConverter.ToInt32(t, 0);
                case CM_BYTE_TYPE.CM_BYTE_INT64:
                    return BitConverter.ToInt64(t, 0);
                case CM_BYTE_TYPE.CM_BYTE_DOUBLE:
                    return BitConverter.ToDouble(t, 0);
                case CM_BYTE_TYPE.CM_BYTE_STRING:
                    int u = 0;
                    return common.Byte2String(m, len, out u);
            }
            return null;
        }
        public override bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            if (b.Length < len)
            {
                return false;
            }
            if (byteType == CM_BYTE_TYPE.CM_BYTE_STRING)
            {
                string str = common.Byte2String(b, len, out useLen);
                if (Project.param.recvMap.ContainsKey(this.name))
                {
                    Project.param.recvMap[this.name].tempValue = str;
                }
            }
            else
            {
                useLen = len;
                if (Project.param.recvMap.ContainsKey(this.name))
                {
                    switch (byteType)
                    {
                        case CM_BYTE_TYPE.CM_BYTE_UINT:
                            Project.param.recvMap[this.name].tempValue = (UInt64)List2Value(b.Take(len).ToArray());
                            break;
                        case CM_BYTE_TYPE.CM_BYTE_INT8:
                            Project.param.recvMap[this.name].tempValue = (byte)List2Value(b.Take(len).ToArray());
                            break;
                        case CM_BYTE_TYPE.CM_BYTE_INT16:
                            Project.param.recvMap[this.name].tempValue = (Int16)List2Value(b.Take(len).ToArray());
                            break;
                        case CM_BYTE_TYPE.CM_BYTE_INT32:
                            Project.param.recvMap[this.name].tempValue = (Int32)List2Value(b.Take(len).ToArray());
                            break;
                        case CM_BYTE_TYPE.CM_BYTE_INT64:
                            Project.param.recvMap[this.name].tempValue = (Int64)List2Value(b.Take(len).ToArray());
                            break;
                        case CM_BYTE_TYPE.CM_BYTE_DOUBLE:
                            Project.param.recvMap[this.name].tempValue = Convert.ToDecimal((double)List2Value(b.Take(len).ToArray()));
                            break;
                    }
                }
            }

            return true;
        }
    }
}
