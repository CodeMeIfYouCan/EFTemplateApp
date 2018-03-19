//using EFTemplateCore.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Modules.NorthWind.BusinessLogic
//{
//    public class BaseBusinessLogic
//    {
//        readonly IBaseUnitOfWork baseUnitOfWork;
//        public BaseBusinessLogic(IBaseUnitOfWork baseUnitOfWork)
//        {
//            this.baseUnitOfWork = baseUnitOfWork;
//        }

//        public void Execute(Action action)
//        {
//            try
//            {
//                baseUnitOfWork.BeginTransaction();
//                action.Invoke();
//                baseUnitOfWork.RollbackTransaction();
//            }
//            catch
//            {
//                baseUnitOfWork.RollbackTransaction();
//            }
//            finally
//            {
//                baseUnitOfWork.Dispose();
//            }
//        }
//    }
//}
