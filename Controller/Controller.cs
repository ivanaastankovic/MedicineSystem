using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using SystemOperations.GrupaLekovaSO;
using SystemOperations.KorisnikSO;
using SystemOperations.LekSO;
using SystemOperations.OblikLekaSO;
using SystemOperations.ProizvodjacLekovaSO;

namespace Controller
{
    public class Controller
    {
        private static Controller controller;
        //public static Korisnik PrijavljeniKorisnik { get; set; }
        public static Controller Instance
        {
            get
            {
                if (controller == null)
                {
                    controller = new Controller();
                }
                return controller;
            }
        }

        private Controller()
        {

        }

        public Korisnik Login(Korisnik k)
        {
            SystemOperationBase operationBase = new LoginSO();
            return (Korisnik)operationBase.ExecuteTemplate(k);
        }

        public bool SaveGrupa(GrupaLekova grupa)
        {
            SystemOperationBase operationBase = new AddGrupaSO();
            if ((bool)operationBase.ExecuteTemplate(grupa))
            {
                return true;
            }
            return false;
        }

        public bool SaveProizvodjac(ProizvodjacLekova proizvodjac)
        {
            SystemOperationBase operationBase = new AddProizvodjacSO();
            if ((bool)operationBase.ExecuteTemplate(proizvodjac))
            {
                return true;
            }
            return false;
        }

        public object GetGrupeWhere(GrupaLekova grupaWhere)
        {
            SystemOperationBase operationBase = new FindGrupeSO();
            return operationBase.ExecuteTemplate(grupaWhere);
        }

        public object GetLekoviGrupe(Lek lek)
        {
            SystemOperationBase operationBase = new FindLekoviGrupeSO();
            return operationBase.ExecuteTemplate(lek);
        }

        public object GetGrupa(GrupaLekova grupa)
        {
            SystemOperationBase operationBase = new FindGrupaSO();
            return operationBase.ExecuteTemplate(grupa);
            
        }

        public object DeleteGrupa(GrupaLekova grupaDelete)
        {
            SystemOperationBase operationBase = new DeleteGrupaSO();
            return operationBase.ExecuteTemplate(grupaDelete);
        }

        public object GetProizvodjaciWhere(ProizvodjacLekova proizvodjac)
        {
            SystemOperationBase operationBase = new FindProizvodjaciSO();
            return operationBase.ExecuteTemplate(proizvodjac);
        }

        public object GetProizvodjac(ProizvodjacLekova proizvodjac)
        {
            SystemOperationBase operationBase = new FindProizvodjacSO();
            return operationBase.ExecuteTemplate(proizvodjac);
        }

        public object GetLekoviProizvodjaca(Lek lek)
        {
            SystemOperationBase operationBase = new FindLekoviProizvodjacaSO();
            return operationBase.ExecuteTemplate(lek);
        }

        public object DeleteProizvodjac(ProizvodjacLekova proizvodjac)
        {
            SystemOperationBase operationBase = new DeleteProizvodjacSO();
            return operationBase.ExecuteTemplate(proizvodjac);
        }

        public object GetOblici(OblikLeka oblikLeka)
        {
            SystemOperationBase operationBase = new FindObliciSO();
            return operationBase.ExecuteTemplate(oblikLeka);
        }

        public bool AddLek(Lek lek)
        {
            SystemOperationBase operationBase = new AddLekSO();
            return (bool)operationBase.ExecuteTemplate(lek);
        }

        public object GetObliciLeka(JacinaLeka obliciLeka)
        {
            SystemOperationBase operationBase = new FindObliciLekaSO();
            return operationBase.ExecuteTemplate(obliciLeka);
        }

        public bool UpdateLek(Lek lek)
        {
            SystemOperationBase operationBase = new UpdateLekSO();
            return (bool)operationBase.ExecuteTemplate(lek);
        }

        public bool DeleteLek(Lek lek)
        {
            SystemOperationBase operationBase = new DeleteLekSO();
            return (bool)operationBase.ExecuteTemplate(lek);
        }
    }
}
