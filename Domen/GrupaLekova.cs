using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class GrupaLekova : IEntity
    {
        public int GrupaLekovaId { get; set; }
        public string NazivGrupe { get; set; }

        [Browsable(false)]
        public string TableName => "GrupaLekova";
        [Browsable(false)]
        public string InsertValues { get { return $"'{NazivGrupe}'"; } set { } }
        [Browsable(false)]
        public string SelectWhere { get; set; }
        [Browsable(false)]
        public string JoinTable { get; set; }
        [Browsable(false)]
        public string JoinCondition { get; set; }
        [Browsable(false)]
        public string AliasName => "g";
        [Browsable(false)]
        public string Id => "GrupaID";
        [Browsable(false)]
        public string UpdateValue { get; set; }

        public List<IEntity> ReturnReaderResult(SqlDataReader reader)
        {
            List<IEntity> grupe = new List<IEntity>();
            while (reader.Read())
            {
                GrupaLekova grupa = new GrupaLekova
                {
                    GrupaLekovaId = reader.GetInt32(0),
                    NazivGrupe = reader.GetString(1)
                };
                grupe.Add(grupa);
            }
            return grupe;
        }

        public override string ToString()
        {
            return $"{NazivGrupe}";
        }
    }
}
