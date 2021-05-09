using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProizvodjacLekovaSO
{
    public class AddProizvodjacSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            ProizvodjacLekova proizvodjac = (ProizvodjacLekova)entity;
            if (broker.Insert(proizvodjac)==1)
            {
                return true;
            }
            return false;
        }
    }
}
