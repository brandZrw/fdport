using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDPort.Class
{
    public class CmdItem: NotifyClass
    {
        ObservableCollection<FieldModule> _list = new ObservableCollection<FieldModule>();
        public ObservableCollection<FieldModule> list { get => _list; set { _list = value; OnPropertyChanged();} }
        private string _name;
        public string name { get => _name; set { _name = value; OnPropertyChanged(); } }
    }
    public class FieldModule: NotifyClass
    {
        public enum CM_Type
        {
            CM_STATIC = 0,   // 固定字符串
            CM_BYTE,     // 十六进制
            CM_BIT,      // bit类型
            CM_FUNC,     // 函数
            CM_DATA,     // 接收或发送的数据
        };
        public CM_Type type { get; set; } // 字段类型
        private int _len;
        public int len { get => _len; set { _len = value; OnPropertyChanged(); } } // 字段长度
        private string _name;
        public string name { get => _name; set { _name = value; OnPropertyChanged(); } }//字段名

        public virtual object list2value(byte[] t)
        {
            return null;
        }
        public virtual byte[] value2list(object v)
        {
            return null;
        }
        public virtual bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            return false;
        }

        public object calc(string link)
        {
            var interpreter = new Interpreter();
            var variable = interpreter.DetectIdentifiers(link);
            List<Parameter> param = new List<Parameter>();
            foreach (string varStr in variable.UnknownIdentifiers)
            {
                if (Project.param.sendMap.ContainsKey(varStr))
                {
                    param.Add(new Parameter(varStr, Project.param.sendMap[varStr].getNumc()));
                }
                else
                {
                    if (Project.param.recvMap.ContainsKey(varStr))
                    {
                        FieldRecvParam l = Project.param.recvMap[varStr];
                        param.Add(new Parameter(varStr, l.GetValue())) ;
                    }
                }
            }

            object res = interpreter.Eval(link, param.ToArray());
            if (res.GetType().Equals(typeof(bool)))
            {
                res = res.Equals(true) ? 1 : 0;
            }
            return res;
        }
        /// <summary>
        /// 改变数组长度
        /// </summary>
        /// <param name="m">数组</param>
        /// <param name="len">长度</param>
        /// <param name="proFrom">数组是否来自协议</param>
        /// <returns></returns>
        protected byte[] ByteArrChangeLen(byte[] m, int len, bool proFrom)
        {
            byte[] t = new byte[len];

            if (proFrom == false) // 非协议
            {
                if (BitConverter.IsLittleEndian == false) // 电脑高位在前则先翻转数组变为低位在前
                {
                    Array.Reverse(m);
                }
            }
            else // 来自协议
            {
                if (Project.param.isLittleEndian == false)// 都是低位在前则直接复制
                {
                    Array.Reverse(m);
                }
            }

            if (len >= m.Length)
            {
                m.CopyTo(t, 0); // 先复制进大数组，此时大数组低位在前
            }
            else
            {
                t = m.Take(len).ToArray(); // 截取小数组
            }


            if (proFrom == false) // 非协议
            {
                if (Project.param.isLittleEndian == false) // 电脑高位在前则先翻转数组变为低位在前
                {
                    Array.Reverse(t);
                }
            }
            else // 来自协议
            {
                if (BitConverter.IsLittleEndian == false)// 都是低位在前则直接复制
                {
                    Array.Reverse(t);
                }
            }

            return t;
        }

        /// <summary>
        /// 来自value的数组转换
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public byte[] copyto(byte[] temp)
        {
            byte[] res = ByteArrChangeLen(temp, len, false);
            return res;
        }
    }

    /// <summary>
    /// 固定数值类
    /// </summary>
    public class FieldStatic : FieldModule
    {
        public bool isString { get; set; }
        private List<byte> _array = new List<byte>();
        public List<byte> array { get => _array; set { _array = value; } }
        public override object list2value(byte[] t)
        {
            return array;
        }
        public override byte[] value2list(object v)
        {
            return array.ToArray();
        }
        public override bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            if (common.byteEquals(b, array.ToArray()))
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
            return ((t >> startIndex) & ((UInt64)(1 << len) - 1)) ;
        }
        public override object list2value(byte[] t)
        {
            UInt64 value = BitConverter.ToUInt64(t, 0);
            return GetBitValue(value);
        }
        public override byte[] value2list(object v)
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
            List<string> temp = new List<string>();
            foreach (string t in funcParam)
            {
                //if(common.IsNumeric(t))
                //{
                //    temp.Add(t);
                //}
                //else
                //{
                //    if( Project.param.sendMap.ContainsKey(t))
                //    {
                //        temp.Add(Project.param.sendMap[t].ToString());
                //    }
                //    else if(Project.param.recvMap.ContainsKey(t))
                //    {
                //        temp.Add(Project.param.recvMap[t].ShowValue());
                //    }
                //}
                temp.Add(calc(t).ToString());
            }
            return Project.python("function\\" + funcName + ".py", b, temp.ToArray());
        }
        public override object list2value(byte[] t)
        {
            throw new NotImplementedException();
        }
        public override byte[] value2list(object v)
        {
            byte[] b = (byte[])v;
            returnValue = run(b);
            if (returnValue == null)
            {
                return null;
            }
            int t = (int)returnValue;
            return copyto(BitConverter.GetBytes(t));

        }
        public override bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            useLen = len;
            returnValue = run(b);
            if (returnValue == null)
            {
                return false;
            }
            return true;
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
        public override object list2value(byte[] t)
        {
            throw new NotImplementedException();
        }
        public override byte[] value2list(object v)
        {
            byte[] vs = null;
            if (dataType == DataType.NUM)
            {
                decimal t = 0;
                if (decimal.TryParse((string)v, out t))
                {
                    if (t == (int)t)//整数
                    {
                        vs = copyto(BitConverter.GetBytes(Decimal.ToInt64((int)t)));
                    }
                    else
                    {
                        vs = copyto(BitConverter.GetBytes(Decimal.ToDouble((decimal)t)));
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

            byte[] s = value2list(res.ToString());
            if (s != null)
            {
                return common.byteEquals(b, s);
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

        public override byte[] value2list(object v)
        {
            switch (byteType)
            {
                case CM_BYTE_TYPE.CM_BYTE_UINT:
                    return copyto(BitConverter.GetBytes((UInt64)v));
                case CM_BYTE_TYPE.CM_BYTE_INT8:
                    return copyto(BitConverter.GetBytes((byte)v));
                case CM_BYTE_TYPE.CM_BYTE_INT16:
                    return copyto(BitConverter.GetBytes((Int16)v));
                case CM_BYTE_TYPE.CM_BYTE_INT32:
                    return copyto(BitConverter.GetBytes((Int32)v));
                case CM_BYTE_TYPE.CM_BYTE_INT64:
                    return copyto(BitConverter.GetBytes((Int64)v));
                case CM_BYTE_TYPE.CM_BYTE_DOUBLE:
                    return copyto(BitConverter.GetBytes((double)v));
                case CM_BYTE_TYPE.CM_BYTE_STRING:
                    return common.String2Byte((string)v, len);
            }
            return null;
        }

        // 补齐数组以保证conver可以正常进行
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
        public override object list2value(byte[] m)
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
                            Project.param.recvMap[this.name].tempValue = (UInt64)list2value(b.Take(len).ToArray());
                            break;
                        case CM_BYTE_TYPE.CM_BYTE_INT8:
                            Project.param.recvMap[this.name].tempValue = (byte)list2value(b.Take(len).ToArray());
                            break;
                        case CM_BYTE_TYPE.CM_BYTE_INT16:
                            Project.param.recvMap[this.name].tempValue = (Int16)list2value(b.Take(len).ToArray());
                            break;
                        case CM_BYTE_TYPE.CM_BYTE_INT32:
                            Project.param.recvMap[this.name].tempValue = (Int32)list2value(b.Take(len).ToArray());
                            break;
                        case CM_BYTE_TYPE.CM_BYTE_INT64:
                            Project.param.recvMap[this.name].tempValue = (Int64)list2value(b.Take(len).ToArray());
                            break;
                        case CM_BYTE_TYPE.CM_BYTE_DOUBLE:
                            Project.param.recvMap[this.name].tempValue = Convert.ToDecimal((double)list2value(b.Take(len).ToArray()));
                            break;
                    }
                }
            }

            return true;
        }
    }
}
