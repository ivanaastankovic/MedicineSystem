using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.LekSO
{
    public class UpdateLekSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            Lek lek = (Lek)entity;
            broker.Update(lek);
            foreach (JacinaLeka jacinaLeka in lek.DodateJacine)
            {
                jacinaLeka.JacinaLekaId = broker.GetNewId(jacinaLeka);
                jacinaLeka.InsertValues = $"{jacinaLeka.JacinaLekaId},{jacinaLeka.Lek.LekId},{jacinaLeka.Oblik.OblikLekaId},{jacinaLeka.Jacina},{(int)jacinaLeka.Jedinica},'{jacinaLeka.Boja}'";
                broker.Insert(jacinaLeka);
            }
            foreach (JacinaLeka jacina in lek.IzmenjeneJacine)
            {
                broker.Update(jacina);
            }
            foreach (JacinaLeka jacinaLeka1 in lek.IzbrisaneJacine)
            {
                broker.Delete(jacinaLeka1);
            }
            return true;
        }
    }
}
