using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FDPort.Class
{
    class ThreadQueue<T>
    {
        private BlockingCollection<T> queue = new BlockingCollection<T>();
        private Thread thread;
        public delegate void Deal(T t);
        public Deal OnDeal;
        public ThreadQueue(Deal deal)
        {
            thread = new Thread(ThreadLoop);
            OnDeal = deal;
            thread.Start();
        }
        public void Add(T t)
        {
            queue.Add(t);
        }

        public void Close()
        {
            queue.CompleteAdding();
            thread.Abort();
        }
        private void ThreadLoop()
        {
            foreach (var item in queue.GetConsumingEnumerable())
            {
                OnDeal?.Invoke(item);
            }
        }
    }
}
