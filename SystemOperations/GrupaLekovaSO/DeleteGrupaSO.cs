using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GrupaLekovaSO
{
    public class DeleteGrupaSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            try
            {
                GrupaLekova grupa = (GrupaLekova)entity;
                if (broker.Delete(grupa) == 1)
                {
                    return true;
                }
                return false;
            }
            catch (SqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
