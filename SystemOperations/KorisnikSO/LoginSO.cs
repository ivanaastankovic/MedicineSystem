using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.KorisnikSO
{
    public class LoginSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {
            Korisnik k = (Korisnik)entity;
            List<Korisnik> korisnici = broker.Select(entity).OfType<Korisnik>().ToList();
            foreach (Korisnik korisnik in korisnici)
            {
                if(korisnik.KorisnickoIme == k.KorisnickoIme && korisnik.Lozinka == k.Lozinka)
                {
                    return korisnik;
                }
            }
            return null;
        }
    }
}
