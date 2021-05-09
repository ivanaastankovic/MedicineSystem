using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.LekSO
{
    public class AddLekSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            try
            {
                Lek lek = (Lek)entity;
                lek.LekId = broker.GetNewId(lek);
                broker.Insert(lek);
                foreach (JacinaLeka jacinaLeka in lek.JacineLeka)
                {
                    jacinaLeka.Lek = lek;
                    jacinaLeka.JacinaLekaId = broker.GetNewId(jacinaLeka);
                    jacinaLeka.InsertValues = $"{jacinaLeka.JacinaLekaId},{jacinaLeka.Lek.LekId},{jacinaLeka.Oblik.OblikLekaId},{jacinaLeka.Jacina},{(int)jacinaLeka.Jedinica},'{jacinaLeka.Boja}'";
                    broker.Insert(jacinaLeka);
                }
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
