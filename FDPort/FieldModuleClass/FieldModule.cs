using DynamicExpresso;
using FDPort.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace FDPort.FieldModuleClass
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

        public virtual object List2Value(byte[] t)
        {
            return null;
        }
        public virtual byte[] Value2List(object v)
        {
            return null;
        }
        public virtual bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            return false;
        }

        /// <summary>
        /// 计算表达式
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public object calc(string link)
        {
            var interpreter = new Interpreter();
            var variable = interpreter.DetectIdentifiers(link);
            List<Parameter> param = new List<Parameter>();
            foreach (string varStr in variable.UnknownIdentifiers)
            {
                if (Project.param.sendMap.ContainsKey(varStr))
                {
                    param.Add(new Parameter(varStr, Project.param.sendMap[varStr].GetNumValue()));
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
        public byte[] CopyTo(byte[] temp)
        {
            byte[] res = ByteArrChangeLen(temp, len, false);
            return res;
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
            return Project.RunPython("function\\" + funcName + ".py", b, temp.ToArray());
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

    

    
}
