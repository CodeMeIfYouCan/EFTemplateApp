using System;

namespace EFTemplateCore.Logging.LogProviders.QueueLoggers
{
    /// <summary>
    /// todo:emrahdi Not implemented!!!
    /// Send log messages to RabbitMQ.
    /// Implement another thread(s) process consume from RabbitMQ
    /// </summary>
    class RabbitMQProvider : ILogQueue
    {
        public void LogQueueMessage(object message)
        {
            //todo:emrahdi try catch block must be added!
            throw new NotImplementedException();
        }
    }
}
