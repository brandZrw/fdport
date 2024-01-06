using System;

namespace FDPort.Logic
{
    public class DataRec
    {
        System.Threading.Timer timer;
        DateTime dtLast;
        bool needDeal;
        byte[] dataCache;
        public delegate int DataDealCb(byte[] b, int len);
        public DataDealCb dataDealFunc;
        UInt32 timeout = 20;

        public DataRec()
        {
            timer = new System.Threading.Timer((state) =>
            {
                if (needDeal)
                {
                    TimeSpan ts = DateTime.Now - dtLast;
                    if (ts.TotalMilliseconds >= timeout)
                    {
                        needDeal = false;
                        if (dataCache != null)
                        {

                            dataDealFunc?.Invoke(dataCache, dataCache.Length);
                            dataCache = null;

                        }
                    }
                }
            }, "timer event", 0, 1);
        }
        /// <summary>
        /// 设置超时时间，超过这些时间算一帧
        /// </summary>
        /// <param name="t"></param>
        public void set_timeout(UInt32 t)
        {
            timeout = t;
        }

        /// <summary>
        /// 接收到数据进行处理
        /// </summary>
        /// <param name="data"></param>
        /// <param name="len"></param>
        public void Rec(byte[] data, int len)
        {
            needDeal = true;
            dtLast = DateTime.Now;
            if (dataCache == null)
            {
                dataCache = data;
            }
            else
            {
                byte[] temp = new byte[dataCache.Length + len];
                dataCache.CopyTo(temp, 0);
                data.CopyTo(temp, dataCache.Length);
                dataCache = temp;//包拼接
            }
        }
    }
}