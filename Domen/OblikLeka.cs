using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class OblikLeka : IEntity
    {
        public int OblikLekaId { get; set; }
        public string NazivOblika { get; set; }

        public string TableName => "OblikLeka";

        public string InsertValues { get; set; }
        public string SelectWhere { get; set; }

        public string JoinTable { get; set; }

        public string JoinCondition { get; set; }

        public string AliasName => "o";

        public string  Id => "OblikLekaID";

        public string UpdateValue { get; set; }

        public List<IEntity> ReturnReaderResult(SqlDataReader reader)
        {
            List<IEntity> oblici = new List<IEntity>();
            while (reader.Read())
            {
                OblikLeka oblik = new OblikLeka
                {
                    OblikLekaId = reader.GetInt32(0),
                    NazivOblika = reader.GetString(1)
                };
                oblici.Add(oblik);
            }
            return oblici;
        }
        public override string ToString()
        {
            return $"{NazivOblika}";
        }
    }
}
