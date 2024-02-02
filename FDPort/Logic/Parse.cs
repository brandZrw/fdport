using System;
using System.Collections.Generic;
using System.Linq;
using FDPort.Class;
using FDPort.Communication;
using System.Net;
using FDPort.FieldModuleClass;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FDPort.Logic
{
    public class Parse
    {
        public delegate void DataBitParse(FieldModule name);
        public DataBitParse DataBitParsed;
        public delegate void DataNotBitParse(FieldModule name);
        public DataNotBitParse DataNotBitParsed;

        /// <summary>
        /// 接收匹配数据
        /// </summary>
        /// <param name="from">来自哪个端口</param>
        /// <param name="data"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public int dataParsing(PortBase from,byte[] indata, int len, IPEndPoint point)
        {
            if(Project.param.cmdRecv.Count == 0)//没有接收协议就全部抛弃
            {
                return len;
            }
            
            for(int i = 0; i < indata.Length;i++)
            {
                byte[] data = common.SkipBuffer(indata,i);
                foreach (CmdRecv obj in Project.param.cmdRecv)
                {
                    int index = 0;
                    bool parsed = true;

                    // 轮询匹配
                    foreach (FieldModule m in obj.list)
                    {

                        int useLen = 0;

                        // 函数的话需要传入整段数据
                        parsed = m.type == FieldModule.CM_Type.CM_FUNC ? m.IsParse(data, ref useLen, common.SkipBuffer(data, index)) : m.IsParse(common.SkipBuffer(data, index), ref useLen );
    
                        if (parsed == true)//匹配成功
                        {
                            index += useLen;
                        }
                        else
                        {
                            break;
                        }
                    }

                    //if (parsed == true && index + i == len)// 匹配成功且没有多余数组空余
                    if (parsed == true)
                    {
                        foreach (FieldModule m in obj.list)// 先更新所有数据
                        {
                            if (m.type != FieldModule.CM_Type.CM_BIT)
                            {
                                DataNotBitParsed?.Invoke(m);
                            }
                        }

                        foreach (FieldModule m in obj.list)
                        {
                            if (m.type == FieldModule.CM_Type.CM_BIT)//更新位域数据
                            {
                                DataBitParsed?.Invoke(m);
                            }
                        }
                        // 需要回复
                        if (obj.needReply)
                        {
                            CmdSend cmd = Project.param.cmdSend.FirstOrDefault(t => t.name.Equals(obj.replyName));
                            cmd?.Send(common.GetPort(from), point);
                        }
                        return index + i;
                    }
                }
            }
            
            return 0;
        }
    }
}
