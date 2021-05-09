using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProizvodjacLekovaSO
{
    public class FindProizvodjaciSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            ProizvodjacLekova proizvodjacLekova = (ProizvodjacLekova)entity;
            return broker.Select(proizvodjacLekova).OfType<ProizvodjacLekova>().ToList();
        }
    }
}
