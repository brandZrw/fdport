using DynamicExpresso;
using FDPort.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FDPort.Class.FieldByte;

namespace FDPort.Class
{
    public class FieldRecvParam
    {
        private CM_BYTE_TYPE valueType { get; set; }
        public bool isShow { get; set; }
        public object objValue { get; set; }
        public object tempValue { get; set; }
        public bool isHex { get; set; }

        public object GetValue()
        {
            return objValue;
        }
        public void SetValueType(CM_BYTE_TYPE type)
        {
            valueType = type;
            switch (type)
            {
                case CM_BYTE_TYPE.CM_BYTE_UINT:
                    objValue = new UInt64();
                    tempValue = new UInt64();
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT16:
                    objValue = new Int16();
                    tempValue = new Int16();
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT32:
                    objValue = new Int32();
                    tempValue = new Int32();
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT64:
                    objValue = new Int64();
                    tempValue = new Int64();
                    break;
                case CM_BYTE_TYPE.CM_BYTE_INT8:
                    objValue = new byte();
                    tempValue = new byte();
                    break;
                case CM_BYTE_TYPE.CM_BYTE_DOUBLE:
                    objValue = new double();
                    tempValue = new double();
                    break;
                case CM_BYTE_TYPE.CM_BYTE_STRING:
                    objValue = new String(String.Empty.ToCharArray());
                    tempValue = new String(String.Empty.ToCharArray());
                    break;
            }
        }
        public static FieldRecvParam operator+(FieldRecvParam t, decimal num)
        {
            switch (t.valueType)
            {
                case CM_BYTE_TYPE.CM_BYTE_DOUBLE:
                    t.objValue = (double)t.objValue + (double)num;
                    return t;
                case CM_BYTE_TYPE.CM_BYTE_UINT:
                    t.objValue = (UInt64)t.objValue + (UInt64)num;
                    return t;
                case CM_BYTE_TYPE.CM_BYTE_INT16:
                    t.objValue = (Int16)t.objValue + (Int16)num;
                    return t;
                case CM_BYTE_TYPE.CM_BYTE_INT32:
                    t.objValue = (Int32)t.objValue + (Int32)num;
                    return t;
                case CM_BYTE_TYPE.CM_BYTE_INT64:
                    t.objValue = (Int64)t.objValue + (Int64)num;
                    return t;
                case CM_BYTE_TYPE.CM_BYTE_INT8:
                    t.objValue = (byte)t.objValue + (byte)num;
                    return t;
                default:
                    return t;
            }
        }
        public static FieldRecvParam operator -(FieldRecvParam t, decimal num)
        {
            switch (t.valueType)
            {
                case CM_BYTE_TYPE.CM_BYTE_DOUBLE:
                    t.objValue = (double)t.objValue - (double)num;
                    return t;
                case CM_BYTE_TYPE.CM_BYTE_UINT:
                    t.objValue = (UInt64)t.objValue - (UInt64)num;
                    return t;
                case CM_BYTE_TYPE.CM_BYTE_INT16:
                    t.objValue = (Int16)t.objValue - (Int16)num;
                    return t;
                case CM_BYTE_TYPE.CM_BYTE_INT32:
                    t.objValue = (Int32)t.objValue - (Int32)num;
                    return t;
                case CM_BYTE_TYPE.CM_BYTE_INT64:
                    t.objValue = (Int64)t.objValue - (Int64)num;
                    return t;
                case CM_BYTE_TYPE.CM_BYTE_INT8:
                    t.objValue = (byte)t.objValue - (byte)num;
                    return t;
                default:
                    return t;
            }
        }

        public string toHex(bool hex)
        {
            isHex = hex;

            return ShowValue();
        }
        public void apply()
        {
            objValue = tempValue;
        }
        public string ShowValue()
        {
            switch (valueType)
            {
                case CM_BYTE_TYPE.CM_BYTE_UINT:
                case CM_BYTE_TYPE.CM_BYTE_INT16:
                case CM_BYTE_TYPE.CM_BYTE_INT32:
                case CM_BYTE_TYPE.CM_BYTE_INT64:
                case CM_BYTE_TYPE.CM_BYTE_INT8:
                    if (isHex)
                    {
                        return String.Format("0x{0:X}", objValue);
                    }
                    else
                    {
                        return objValue.ToString();
                    }
                default:
                    return objValue.ToString();
            }
        }
    }
    public class FieldSendParam
    {
        public string value { get; set; }
        public bool isHex { get; set; }

        public static FieldSendParam operator +(FieldSendParam t, decimal num)
        {
            if (t.isHex)
            {
                Int64 temp = 0;
                if (Int64.TryParse(t.value, out temp))
                {
                    t.value = String.Format("0x{0:X}", temp + num);
                }
            }
            else
            {
                Int64 temp = Convert.ToInt64(t.value, 16);
                temp = (long)(temp + num);
                t.value = temp.ToString();
            }
            return t;
        }
        public static FieldSendParam operator -(FieldSendParam t, decimal num)
        {
            if (t.isHex)
            {
                Int64 temp = 0;
                if (Int64.TryParse(t.value, out temp))
                {
                    t.value = String.Format("0x{0:X}", temp - num);
                }
            }
            else
            {
                Int64 temp = Convert.ToInt64(t.value, 16);
                temp = (long)(temp - num);
                t.value = temp.ToString();
            }
            return t;
        }
        public FieldSendParam(string x)
        {
            value = x;
            isHex = false;
        }
        public string toHex(bool hex)
        {
            isHex = hex;
            if (hex)
            {
                Int64 t = 0;
                if (Int64.TryParse(value, out t))
                {
                    value = String.Format("0x{0:X}", t);
                }
            }
            else
            {
                Int64 t = Convert.ToInt64(value, 16);
                value = t.ToString();
            }
            return value;
        }
        public void setStrValue(string s)
        {
            value = s;
        }
        public void setValue(decimal t)
        {
            if (isHex)
            {
                value = String.Format("0x{0:X}", (UInt64)t);
            }
            else
            {
                value = ((Int64)t).ToString();
            }
        }
        public decimal getNumc()
        {
            if (isHex)
            {
                return (decimal)Convert.ToInt64(value, 16);
            }
            else
            {
                decimal t = 0;
                decimal.TryParse(value, out t);
                return t;
            }
        }
        public override string ToString()
        {
            return value;
        }
    }
    public class CmdRecv : CmdItem
    {
        public Dictionary<FieldModule, FieldRecvParam> fields { get; set; }
        public bool needReply { get; set; }
        public string replyName { get; set; }
    }

    public class CmdSend : CmdItem
    {
        private bool _autoSend;
        private int _sendTime;


        public bool autoSend { get => _autoSend;
                               set
        {
            _autoSend = value;
            if (_autoSend)
            {
                cmdTimer.Enabled = true;
                cmdTimer.Start();
            }
            else
            {
                cmdTimer.Enabled = false;
                cmdTimer.Stop();
            }
        }
                             }

        public int sendTime { get {return _sendTime; }
                              set { _sendTime = value;
                                    if (value == 0)
    {
        cmdTimer.Interval = 1000;
        _autoSend = false;
    }
    else
    {
        cmdTimer.Interval = value;
    }

                              }
                        }

    public System.Windows.Forms.Timer cmdTimer { get; set; }
    public CmdSend()
        {
            cmdTimer = new System.Windows.Forms.Timer();
            cmdTimer.Enabled = false;
            cmdTimer.Tick += new EventHandler(TimerUp);
        }
        private void TimerUp(object sender, EventArgs e)
        {
            cmdTimer.Stop();
            Send();
            cmdTimer.Start();
        }

        public void Send()//发送该条命令
        {
            List<byte> vs = new List<byte>();
            foreach (FieldModule field in list)
            {
                byte[] b = null;
                switch (field.type)
                {
                    case FieldModule.CM_Type.CM_BIT:
                        break;
                    case FieldModule.CM_Type.CM_BYTE:
                        b = field.value2list(field.value2list(Project.param.sendMap.ContainsKey(field.name) ? Project.param.sendMap[field.name] : (object)((UInt64)0)));
                        if (b != null)
                        {
                            vs.AddRange(b);
                        }
                        break;
                    case FieldModule.CM_Type.CM_DATA:
                        FieldData data = (FieldData)field;
                        b = null;
                        if (data.dataType == FieldData.DataType.NUM)
                        {
                            var interpreter = new Interpreter();
                            var variable = interpreter.DetectIdentifiers(((FieldData)field).link);
                            List<Parameter> param = new List<Parameter>();
                            foreach (string varStr in variable.UnknownIdentifiers)
                            {
                                if (Project.param.sendMap.ContainsKey(varStr))
                                {
                                    decimal t = Project.param.sendMap[varStr].getNumc();
                                    UnitTestObject temp = Project.param.unitTests.FirstOrDefault(v => v.cmdName.Equals(varStr));

                                    if (temp != null)//存在单元测试
                                    {
                                        if (temp.enable) // 单元测试使能
                                        {
                                            if (temp.dec)
                                            {
                                                t = t - temp.step;
                                            }
                                            else
                                            {
                                                t = t + temp.step;
                                            }
                                            if (t > temp.end)
                                            {
                                                t = temp.start;
                                            }
                                            else if (t < temp.start)
                                            {
                                                t = temp.end;
                                            }
                                            Project.param.sendMap[varStr].setValue(t);
                                            for (int i = 0; i < Project.param.sendMap.Keys.Count; i++)
                                            {
                                                if (Project.param.sendMap.Keys.ElementAt(i).Equals(varStr))
                                                {
                                                    Project.mainForm.SendList_Change(i, Project.param.sendMap[varStr].ToString());
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    param.Add(new Parameter(varStr, t));
                                }
                                else if (Project.param.recvMap.ContainsKey(varStr))
                                {
                                    FieldRecvParam l = Project.param.recvMap[varStr];
                                    param.Add(new Parameter(varStr, Convert.ToInt32(l.GetValue())));
                                }
                            }

                            object res = interpreter.Eval(((FieldData)field).link, param.ToArray());
                            b = field.value2list(res.ToString());
                        }
                        else
                        {
                            if (Project.param.sendMap.ContainsKey(((FieldData)field).link))
                            {
                                b = field.value2list(Project.param.sendMap[((FieldData)field).link]);
                            }
                            else if (Project.param.recvMap.ContainsKey(((FieldData)field).link))
                            {
                                b = field.value2list(Project.param.recvMap[((FieldData)field).link].GetValue());
                            }

                        }


                        if (b != null)
                        {
                            vs.AddRange(b);
                        }
                        break;
                    case FieldModule.CM_Type.CM_FUNC:
                        b = ((FieldFunc)field).value2list(vs.ToArray());
                        if (b != null)
                        {
                            vs.AddRange(b);
                        }
                        break;
                    case FieldModule.CM_Type.CM_STATIC:
                        b = field.value2list(null);
                        if (b != null)
                        {
                            vs.AddRange(b);
                        }
                        break;
                }
            }
            Project.mainForm.sendData(vs.ToArray());
        }
    }
}
