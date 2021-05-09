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
    public class Lek : IEntity
    {
        public int LekId { get; set; }
        public string NazivLeka { get; set; }
        public string MehanizamDejstva { get; set; }
        public double TrajanjeTerapije { get; set; }
        public string NazivGrupe => $"{Grupa.NazivGrupe}";
        public string NazivProizvodjaca => $"{Proizvodjac.NazivProizvodjaca}";
        [Browsable(false)]
        public GrupaLekova Grupa { get; set; }
        //public string GrupaNaziv { get; set; }
        [Browsable(false)]
        public ProizvodjacLekova Proizvodjac { get; set; }
        //public string ProizvodjacNaziv { get; set; }
        public List<JacinaLeka> JacineLeka { get; set; }
        [Browsable(false)]
        public List<JacinaLeka> IzmenjeneJacine { get; set; }
        [Browsable(false)]
        public List<JacinaLeka> IzbrisaneJacine { get; set; }
        [Browsable(false)]
        public List<JacinaLeka> DodateJacine { get; set; }
        [Browsable(false)]
        public string TableName => "Lek";
        [Browsable(false)]
        public string InsertValues { get { return $"{LekId},'{NazivLeka}','{MehanizamDejstva}',{TrajanjeTerapije},{Grupa.GrupaLekovaId},{Proizvodjac.ProizvodjacId}"; } set { } }

        [Browsable(false)]
        public string JoinTable => $"join GrupaLekova g on ({AliasName}.grupaid=g.grupaid) join proizvodjaclekova p on ({AliasName}.proizvodjacid=p.proizvodjacid)";

        [Browsable(false)]
        public string AliasName => "l";
        [Browsable(false)]
        public string SelectWhere { get; set; }

        [Browsable(false)]
        public string JoinCondition { get; }

        [Browsable(false)]
        public string Id => "LekId";
        [Browsable(false)]
        public string UpdateValue { get; set; }

        public List<IEntity> ReturnReaderResult(SqlDataReader reader)
        {
            List<IEntity> lekovi = new List<IEntity>();
            while (reader.Read())
            {
                Lek lek = new Lek
                {
                    LekId = reader.GetInt32(0),
                    NazivLeka = reader.GetString(1),
                    MehanizamDejstva = reader.GetString(2),
                    TrajanjeTerapije = reader.GetDouble(3),
                    Grupa = new GrupaLekova
                    {
                        GrupaLekovaId = reader.GetInt32(4),
                        NazivGrupe = reader.GetString(7)
                    },
                    Proizvodjac = new ProizvodjacLekova
                    {
                        ProizvodjacId = reader.GetInt32(5),
                        NazivProizvodjaca = reader.GetString(9)
                    }
                };
                lekovi.Add(lek);
            }
            return lekovi;
        }

    }
}
