using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProizvodjacLekovaSO
{
    public class FindLekoviProizvodjacaSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            Lek lek = (Lek)entity;
            return broker.Select(lek).OfType<Lek>().ToList();
        }
    }
}
