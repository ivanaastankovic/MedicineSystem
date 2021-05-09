using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.LekSO
{
    public class DeleteLekSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            Lek lek = (Lek)entity;
            foreach (JacinaLeka jacina in lek.JacineLeka)
            {
                jacina.SelectWhere = $"where jacinalekaid={jacina.JacinaLekaId}";
                broker.Delete(jacina);
            }
            broker.Delete(lek);
            return true;
        }
    }
}
