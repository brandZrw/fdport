using FDPort.Class;
using FDPort.Communication;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace FDPort.Logic
{
    public class DataRecParam
    {
        public List<byte> dataCache = new List<byte>();
        public PortBase from;
        public IPEndPoint point;
    }
    public class DataRecQueueObj
    {
        public object sender;
        public PortBase from;
        public byte[] data;
        public int len;
        public DataRecQueueObj(object s,PortBase a,byte[] b,int c)
        {
            sender = s;
            from = a;
            data = b;
            len = c;
        }
    }
    public class DataRec
    {
        Dictionary<PortBase, DataRecParam> map = new Dictionary<PortBase, DataRecParam>();
        public delegate int DataDealCb(PortBase from,byte[] b, int len,IPEndPoint point);
        public DataDealCb dataDealFunc;

        public delegate int DataRecCb(PortBase from, byte[] b, int len, IPEndPoint point);
        public DataRecCb dataRecFunc;

        ThreadQueue<DataRecQueueObj> dataRecQueue;

        public DataRec()
        {
            dataRecQueue = new ThreadQueue<DataRecQueueObj>(RecDeal);
        }
        public void Close()
        {
            dataRecQueue.Close();
        }
        /// <summary>
        /// 接收到数据进行处理
        /// </summary>
        /// <param name="data"></param>
        /// <param name="len"></param>
        public void Rec(object sender, PortBase from, byte[] data, int len)
        {
            dataRecQueue.Add(new DataRecQueueObj(sender, from, data, len));
        }

        /// <summary>
        /// 接收线程处理
        /// </summary>
        /// <param name="item"></param>
        private void RecDeal(DataRecQueueObj item)
        {
            if (!map.ContainsKey(item.from))
            {
                map.Add(item.from, new DataRecParam());
            }
            if (item.sender != null)
            {
                map[item.from].point = (IPEndPoint)item.sender;
            }
            dataRecFunc?.BeginInvoke(map[item.from].from, item.data, item.len, map[item.from].point, null, null);
            map[item.from].from = item.from;
            map[item.from].dataCache.AddRange(item.data);

            int? dealLen;
            do
            {
                dealLen = dataDealFunc?.Invoke(map[item.from].from, map[item.from].dataCache.ToArray(), map[item.from].dataCache.Count, map[item.from].point);

                if (dealLen != null && dealLen > 0)
                {
                    map[item.from].dataCache.RemoveRange(0, (int)dealLen);
                }
                else
                {
                    break;
                }
                if (map[item.from].dataCache.Count >= Project.param.DataCacheLen)
                {
                    map[item.from].dataCache.Clear();
                    break;
                }
            } while (map[item.from].dataCache.Count > 0);
            
        }
    }
}