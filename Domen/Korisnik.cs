using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Korisnik :IEntity
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public string TableName => "Korisnik";

        public string InsertValues { get; set; }
        public string SelectWhere { get; set; }

        public string JoinTable { get; set; }

        public string JoinCondition { get; set; }
        public string AliasName { get; set; }

        public string Id => "KorisnikID";

        public string UpdateValue { get; set; }

        public List<IEntity> ReturnReaderResult(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Korisnik korisnik = new Korisnik
                {
                    KorisnikId = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    KorisnickoIme = reader.GetString(3),
                    Lozinka = reader.GetString(4)
                };
                entities.Add(korisnik);
            }
            return entities;
        }
    }
}
