using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.OblikLekaSO
{
    public class FindObliciSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            OblikLeka oblikLeka = (OblikLeka)entity;
            return broker.Select(oblikLeka).OfType<OblikLeka>().ToList();
        }
    }
}
