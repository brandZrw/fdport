﻿using DynamicExpresso;
using FDPort.Communication;
using FDPort.FieldModuleClass;
using FDPort.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using static FDPort.FieldModuleClass.FieldByte;

namespace FDPort.Class
{

    /// <summary>
    /// 接收参数
    /// </summary>
    public class FieldRecvParam
    {
        public CM_BYTE_TYPE valueType { get; set; }
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
        #region 操作符
        public static FieldRecvParam operator +(FieldRecvParam t, decimal num)
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
        #endregion

        public string ToHex(bool hex)
        {
            isHex = hex;
            return ShowValue();
        }
        public void Apply() => objValue = tempValue;
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
                        return objValue?.ToString();
                    }
                default:
                    return objValue?.ToString();
            }
        }
    }

    /// <summary>
    /// 发送参数
    /// </summary>
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
        public string ToHex(bool hex)
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
        public void SetStrValue(string s)=>value = s;
        public void SetValue(decimal t)=>value =isHex? String.Format("0x{0:X}", (UInt64)t):((Int64)t).ToString();
        public override string ToString()=>value;
        public decimal GetNumValue()
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
        
    }
    public class CmdRecv : CmdItem
    {
        public Dictionary<FieldModule, FieldRecvParam> fields { get; set; }
        public bool needReply { get; set; }
        public string replyName { get; set; }
    }

    public class CmdSendQueueObj
    {
        public CmdSend cmd;
        public PortBase port;
        public IPEndPoint point = null;
        public CmdSendQueueObj(CmdSend a,PortBase b,IPEndPoint c)
        {
            cmd = a;
            port = b;
            point = c;
        }
    }
    public class CmdSend : CmdItem
    {
        private bool _autoSend;
        private int _sendTime;
        public bool autoSend
        {
            get => _autoSend;
            set
            {
                _autoSend = value;
            }
        }

        public void SetAutoSend(bool enable)
        {
            _autoSend = enable;
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

        public int sendTime
        {
            get { return _sendTime; }
            set
            {
                _sendTime = value;
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
            if(Project.param.portNow.Connected())
            {
                Send(common.GetPort(Project.param.portNow));
            }
            cmdTimer.Start();
        }
        private void RangeAdd(List<byte> vs,byte[] b)
        {
            if (b != null)
            {
                vs.AddRange(b);
            }
        }
        public void Send(PortBase port, IPEndPoint point = null)//发送该条命令
        {
           Project.mainForm.commonArea.AddSendCmd(new CmdSendQueueObj(this, port, point));
        }


        private decimal UnitTestDo(string varStr)
        {
            decimal t = Project.param.sendMap[varStr].GetNumValue();
            UnitTestObject temp = Project.param.unitTests.FirstOrDefault(v => v.cmdName.Equals(varStr));
            if (temp != null)//存在单元测试
            {
                temp.cal(ref t);
                Project.param.sendMap[varStr].SetValue(t);

                for (int i = 0; i < Project.param.sendMap.Keys.Count; i++)
                {
                    if (Project.param.sendMap.Keys.ElementAt(i).Equals(varStr))
                    {
                        Project.mainForm.sendListDock.SendList_Change(i, Project.param.sendMap[varStr].ToString());
                        break;
                    }
                }
            }
            return t;
        }
        public void SendDo(PortBase port, IPEndPoint point = null)//发送该条命令
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
                        b = field.Value2List(field.Value2List(Project.param.sendMap.ContainsKey(field.name) ? Project.param.sendMap[field.name] : (object)((UInt64)0)));
                        RangeAdd(vs, b);
                        break;
                    case FieldModule.CM_Type.CM_DATA:
                        FieldData data = (FieldData)field;
                        b = null;
                        if (data.dataType == FieldData.DataType.NUM)
                        {
                            var interpreter = new Interpreter();
                            var variable = interpreter.DetectIdentifiers(((FieldData)field).link);
                            List<Parameter> param = new List<Parameter>();
                            foreach (string varStr in variable.UnknownIdentifiers)// 存在变量
                            {
                                if (Project.param.sendMap.ContainsKey(varStr))
                                {
                                    param.Add(new Parameter(varStr, UnitTestDo(varStr)));
                                }
                                else if (Project.param.recvMap.ContainsKey(varStr))
                                {
                                    FieldRecvParam l = Project.param.recvMap[varStr];
                                    param.Add(new Parameter(varStr, Convert.ToInt32(l.GetValue())));
                                }
                            }

                            object res = interpreter.Eval(((FieldData)field).link, param.ToArray());
                            b = field.Value2List(res.ToString());
                        }
                        else
                        {
                            if (Project.param.sendMap.ContainsKey(((FieldData)field).link))
                            {
                                b = field.Value2List(Project.param.sendMap[((FieldData)field).link]);
                            }
                            else if (Project.param.recvMap.ContainsKey(((FieldData)field).link))
                            {
                                b = field.Value2List(Project.param.recvMap[((FieldData)field).link].GetValue());
                            }
                        }
                        RangeAdd(vs, b);
                        break;
                    case FieldModule.CM_Type.CM_FUNC:
                        b = ((FieldFunc)field).Value2List(vs.ToArray());
                        RangeAdd(vs, b);
                        break;
                    case FieldModule.CM_Type.CM_STATIC:
                        b = field.Value2List(null);
                        RangeAdd(vs, b);
                        break;
                    case FieldModule.CM_Type.CM_REGEX:
                        b = field.Value2List(null);
                        RangeAdd(vs, b);
                        break;
                }
            }
            Project.mainForm.commonArea.SendData(vs.ToArray(), port, point);

        }
    }
}
