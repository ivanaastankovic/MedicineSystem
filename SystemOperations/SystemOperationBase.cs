using DBBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected Broker broker = new Broker();
        object result = null;
        public object ExecuteTemplate(IEntity entity)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                result = ExecuteSO(entity);
                broker.Commit();
            }
            catch (Exception)
            {
                broker.RollBack();
            }
            finally
            {
                broker.CloseConnection();
            }
            return result;
        }

        protected abstract object ExecuteSO(IEntity entity);
    }
}
