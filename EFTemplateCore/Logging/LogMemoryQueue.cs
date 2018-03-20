using EFTemplateCore.ServiceLocator;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFTemplateCore.Logging
{
    /// <summary>
    /// Class for sending messages over a memory queue async
    /// If memory queue size or timeout is reaches the limits,sends the messages
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LogMemoryQueue<T>
    {
        static internal ILog logger;
        //todo:queue size can be taken from json or any provider.
        BlockingCollection<T> queue = new BlockingCollection<T>(Constants.LogMemoryQueueSize);
        int timeout;
        int bufferSize;
        string queueName;
        string label;

        public LogMemoryQueue(int timeout, int bufferSize, string queueName, string label)
        {
            this.timeout = timeout;
            this.bufferSize = bufferSize;
            this.queueName = queueName;
            this.label = label;
            if (Services.IsRegistered(typeof(ILog))) {
                logger = Services.Create<ILog>(); 
            }
            Task.Factory.StartNew(() => { Consume(); });
        }

        void Log(List<T> list)
        {
            try {
                if (Services.IsRegistered(typeof(ILogQueue))) {
                    Services.Create<ILogQueue>().LogQueueMessage(list);
                }
            }
            catch (Exception ex) {
                logger.LogFormat("Error in sending LogQueueMessage! QueueName:{0},Label:{1},Exception:{3}", LogLevel.Error, queueName, label, ex);
            }
        }

        public void Add(T item)
        {
            queue.TryAdd(item, timeout);
        }

        void Consume()
        {
            List<T> list = new List<T>();
            while (!queue.IsCompleted) {
                T item;
                bool timeoutElapsed = false;
                if (queue.TryTake(out item, timeout)) {
                    if (item != null) {
                        list.Add(item);
                    }
                }
                else {
                    timeoutElapsed = true;
                }
                if (list.Count == 0) {
                    continue;
                }
                if (timeoutElapsed || list.Count >= bufferSize) {
                    Log(list);
                    list.Clear();
                }
            }
        }
    }
}
