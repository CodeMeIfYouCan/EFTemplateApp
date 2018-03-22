using EFTemplateCore.Interfaces;
using EFTemplateCore.Logging;
using EFTemplateCore.ServiceLocator;
using Microsoft.Extensions.Logging;
using System;

namespace EFTemplateCore.TransactionManager
{
    //public delegate IResponseMessage Exec(IRequestMessage request);
    public static class TransactionProcessor<TContext>
        where TContext : EFContext, new()
    {
        //public static IResponseMessage Execute(Exec action, IRequestMessage request, IUnitOfWork<TContext> unitOfWork)
        public static TResponse Execute<TRequest, TResponse>(Func<TRequest, TResponse> action, TRequest request, IUnitOfWork<TContext> unitOfWork)
           where TRequest : IRequestMessage, new()
           where TResponse : IResponseMessage, new()
        {
            TResponse responseMessage;
            LogRequest(request);
            try 
            {
                unitOfWork.BeginTransaction();
                responseMessage = action(request);
                LogResponse(responseMessage);
                unitOfWork.CommitTransaction();
                return responseMessage;
            }
            catch(Exception ex)
            {
                unitOfWork.RollbackTransaction();
                Services.Create<ILog>().LogFormat("Exception in Transaciton Execution!Exception:{0}", LogLevel.Error, ex);
                throw;
            }
            finally 
            {
                unitOfWork.Dispose();
                Services.Create<ILog>().LogFormat("Transaction Execution is completed!", LogLevel.Debug);
            }
        }
        static void LogRequest(IRequestMessage request)
        {
            if (Services.IsRegistered(typeof(ILogQueue))) {
                Services.Create<ILogQueue>().LogQueueMessage(request);
            }
        }
        static void LogResponse(IResponseMessage response)
        {
            if (Services.IsRegistered(typeof(ILogQueue))) {
                Services.Create<ILogQueue>().LogQueueMessage(response);
            }
        }
    }
}
