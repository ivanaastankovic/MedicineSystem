using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.LekSO
{
    public class FindObliciLekaSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            JacinaLeka jacinaLeka = (JacinaLeka)entity;
            return broker.Select(jacinaLeka).OfType<JacinaLeka>().ToList();
        }
    }
}
