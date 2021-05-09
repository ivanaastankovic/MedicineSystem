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
    public class ProizvodjacLekova : IEntity
    {
        public int ProizvodjacId { get; set; }
        public string NazivProizvodjaca { get; set; }
        public int GodinaOsnivanja { get; set; }
        public string ImePrezimeVlasnika { get; set; }
        public string Adresa { get; set; }
        [Browsable(false)]
        public string TableName => "ProizvodjacLekova";
        [Browsable(false)]
        public string InsertValues { get { return $"'{NazivProizvodjaca}',{GodinaOsnivanja},'{ImePrezimeVlasnika}','{Adresa}'"; } set { } }
        [Browsable(false)]
        public string SelectWhere { get; set; }
        [Browsable(false)]
        public string JoinTable { get; }
        [Browsable(false)]
        public string JoinCondition { get; }
        [Browsable(false)]
        public string AliasName => "p";
        [Browsable(false)]
        public string Id => "ProizvodjacId";
        [Browsable(false)]
        public string UpdateValue { get; set; }

        public List<IEntity> ReturnReaderResult(SqlDataReader reader)
        {
            List<IEntity> proizvodjaci = new List<IEntity>();
            while (reader.Read())
            {
                ProizvodjacLekova proizvodjac = new ProizvodjacLekova
                {
                    ProizvodjacId = reader.GetInt32(0),
                    NazivProizvodjaca = reader.GetString(1),
                    GodinaOsnivanja = reader.GetInt32(2),
                    ImePrezimeVlasnika = reader.GetString(3),
                    Adresa = reader.GetString(4)
                };
                proizvodjaci.Add(proizvodjac);
            }
            return proizvodjaci;
        }
        public override string ToString()
        {
            return $"{NazivProizvodjaca}";
        }
    }
}
