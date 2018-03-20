using System;

namespace EFTemplateCore.Logging.LogProviders.QueueLoggers
{
    /// <summary>
    /// todo:Not implemented!!!
    /// Send log messages to RabbitMQ.
    /// Implement another thread(s) process consume from RabbitMQ
    /// </summary>
    class RabbitMQProvider : ILogQueue
    {
        public void LogQueueMessage(object message)
        {
            throw new NotImplementedException();
        }
    }
}
