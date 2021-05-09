using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GrupaLekovaSO
{
    public class AddGrupaSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            GrupaLekova grupa = (GrupaLekova)entity;

            if (broker.Insert(grupa) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
