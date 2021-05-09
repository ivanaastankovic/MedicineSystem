using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IEntity
    {
        string TableName { get; }
        string InsertValues { get; set; }
        string SelectWhere { get; set; }
        string JoinTable { get; }
        string JoinCondition { get; }
        string AliasName { get; }
        string Id { get; }
        string UpdateValue { get; set; }

        List<IEntity> ReturnReaderResult(SqlDataReader reader);
    }
}
