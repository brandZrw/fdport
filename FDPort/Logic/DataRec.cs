using FDPort.Communication;
using System;
using System.Collections.Generic;
using System.Net;

namespace FDPort.Logic
{
    public class DataRecParam
    {
        System.Threading.Timer timer;
        public DateTime dtLast;
        public bool needDeal;
        public List<byte> dataCache = new List<byte>();
        public PortBase from;
        public IPEndPoint point;
        private DataRec parent;
        public DataRecParam(DataRec parent)
        {
            this.parent = parent;
            timer = new System.Threading.Timer((state) =>
            {
                if (needDeal)
                {
                    TimeSpan ts = DateTime.Now - dtLast;
                    if (ts.TotalMilliseconds >= parent.timeout)
                    {
                        needDeal = false;
                        int? len;
                        if (dataCache != null)
                        {
                            do
                            {
                                len = parent.dataDealFunc?.Invoke(from, dataCache.ToArray(), dataCache.Count, point);
                                if (len != null && len > 0)
                                {
                                    dataCache = dataCache.GetRange((int)len, dataCache.Count - (int)len);
                                }
                            } while (len != null && len > 0 && dataCache.Count > 0);
                            
                        }
                    }
                }
            }, "timer event", 0, 1);
        }
    }
    public class DataRec
    {
        Dictionary<PortBase, DataRecParam> map = new Dictionary<PortBase, DataRecParam>();
        public delegate int DataDealCb(PortBase from,byte[] b, int len,IPEndPoint point);
        public DataDealCb dataDealFunc;
        public UInt32 timeout = 20;
        

        public DataRec()
        {
            
        }
        /// <summary>
        /// 设置超时时间，超过这些时间算一帧
        /// </summary>
        /// <param name="t"></param>
        public void set_timeout(UInt32 t)=> timeout = t;
        

        /// <summary>
        /// 接收到数据进行处理
        /// </summary>
        /// <param name="data"></param>
        /// <param name="len"></param>
        public void Rec(object sender, PortBase from,byte[] data, int len)
        {
            if(!map.ContainsKey(from))
            {
                map.Add(from,new DataRecParam(this));
            }
            if(sender != null)
            {
                map[from].point = (IPEndPoint)sender;
            }
            
            map[from].from = from;
            map[from].needDeal = true;
            map[from].dtLast = DateTime.Now;
            map[from].dataCache.AddRange(data);
            //if (map[from].dataCache == null)
            //{
            //    map[from].dataCache = data;
            //}
            //else
            //{
            //    byte[] temp = new byte[map[from].dataCache.Length + len];
            //    map[from].dataCache.CopyTo(temp, 0);
            //    data.CopyTo(temp, map[from].dataCache.Length);
            //    map[from].dataCache = temp;//包拼接
            //}
        }
    }
}