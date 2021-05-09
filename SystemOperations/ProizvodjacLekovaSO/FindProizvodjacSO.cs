using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProizvodjacLekovaSO
{
    public class FindProizvodjacSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            ProizvodjacLekova proizvodjac = (ProizvodjacLekova)entity;
            return broker.Select(proizvodjac).First();
        }
    }
}
