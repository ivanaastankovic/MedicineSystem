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
    public class JacinaLeka : IEntity
    {
        [Browsable(false)]
        public int JacinaLekaId { get; set; }
        public int Jacina { get; set; }
        public JedinicaMere Jedinica { get; set; }
        public string Boja { get; set; }
        [Browsable(false)]
        public Lek Lek { get; set; }
        public OblikLeka Oblik { get; set; }
        [Browsable(false)]
        public string TableName => "JacinaLeka";
        [Browsable(false)]
        public string InsertValues { get; set; }
        //public string InsertValues => $"{Lek.LekId},{Oblik.OblikLekaId},{Jacina},{(int)Jedinica},'{Boja}'";
        [Browsable(false)]
        public string JoinTable => $"join Lek l on (l.lekid={AliasName}.lekid) join " +
            $"OblikLeka o on (o.obliklekaid={AliasName}.oblikid)";
        [Browsable(false)]
        public string JoinCondition { get; }
        [Browsable(false)]
        public string AliasName => "j";
        [Browsable(false)]
        public string Id => "JacinaLekaID";

        [Browsable(false)]
        public string SelectWhere { get; set; }
        [Browsable(false)]
        public string UpdateValue { get; set; }


        public List<IEntity> ReturnReaderResult(SqlDataReader reader)
        {
            List<IEntity> jacine = new List<IEntity>();
            while (reader.Read())
            {
                JacinaLeka jacinaLeka = new JacinaLeka
                {
                    JacinaLekaId = reader.GetInt32(0),
                    Lek = new Lek
                    {
                        LekId = reader.GetInt32(1),
                        NazivLeka = reader.GetString(7),
                        MehanizamDejstva = reader.GetString(8),
                        TrajanjeTerapije = reader.GetDouble(9)
                    },
                    Oblik = new OblikLeka
                    {
                        OblikLekaId = reader.GetInt32(2),
                        NazivOblika = reader.GetString(13)
                    },
                    Jacina = reader.GetInt32(3),
                    Jedinica = (JedinicaMere)reader.GetInt32(4),
                    Boja = reader.GetString(5)
                };
                jacine.Add(jacinaLeka);
            }
            return jacine;
        }
    }
}
