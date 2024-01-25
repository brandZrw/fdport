﻿using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FDPort.Forms;
using FDPort.Class;
using FDPort.Communication;
using System.Net;

namespace FDPort.Logic
{
    public class Parse
    {
        public delegate void DataIsParse(string name);
        public DataIsParse DataParsed;

        /// <summary>
        /// 接收匹配数据
        /// </summary>
        /// <param name="from">来自哪个端口</param>
        /// <param name="data"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public int dataParsing(PortBase from,byte[] data, int len, IPEndPoint point)
        {

            foreach (CmdRecv obj in Project.param.cmdRecv)
            {
                int index = 0;
                bool parsed = true;

                // 轮询匹配
                foreach (FieldModule m in obj.list)
                {
                    int useLen = 0;
                    if (m.type == FieldModule.CM_Type.CM_FUNC) // 函数的话需要传入整段数据
                    {
                        parsed = m.IsParse(data, ref useLen);
                    }
                    else
                    {
                        parsed = m.IsParse(data.Skip(index).ToArray(), ref useLen);
                    }
                    if (parsed == true)//匹配成功
                    {
                        index += useLen;
                    }
                    else
                    {
                        break;
                    }
                }
                if (parsed == true && index == len)// 匹配成功且没有多余数组空余
                {
                    foreach (FieldModule m in obj.list)// 先更新所有数据
                    {
                        if (Project.param.recvMap.ContainsKey(m.name))
                        {
                            Project.param.recvMap[m.name].Apply();
                            if (m.type != FieldModule.CM_Type.CM_BIT)
                            {
                                DataParsed?.Invoke(m.name);
                            }
                        }
                    }

                    foreach (FieldModule m in obj.list)
                    {
                        if (m.type == FieldModule.CM_Type.CM_BIT)//更新位域数据
                        {
                            if (Project.param.recvMap.ContainsKey(m.name))
                            {
                                FieldBit bit = (FieldBit)m;
                                KeyValuePair<string, FieldRecvParam> temp = Project.param.recvMap.FirstOrDefault(t => t.Key.Equals(bit.parent));
                                object tempValue = temp.Value.GetValue();
                                UInt64 res = bit.GetBitValue(Convert.ToDecimal(tempValue));
                                Project.param.recvMap[m.name].tempValue = (decimal)res;
                                Project.param.recvMap[m.name].Apply();//数据更新
                                DataParsed?.Invoke(m.name);
                            }
                        }
                    }

                    // 需要回复
                    if (obj.needReply)
                    {
                        CmdSend cmd = Project.param.cmdSend.FirstOrDefault(t => t.name.Equals(obj.replyName));
                        if (cmd != null)
                        {
                            cmd.Send(common.GetPort(from), point);
                        }
                    }
                }
            }
            return 0;
        }
    }
}
