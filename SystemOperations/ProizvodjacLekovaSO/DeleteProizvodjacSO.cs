using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProizvodjacLekovaSO
{
    public class DeleteProizvodjacSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            try
            {
                ProizvodjacLekova proizvodjac = (ProizvodjacLekova)entity;
                if (broker.Delete(proizvodjac) == 1)
                {
                    return true;
                }
                return false;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
