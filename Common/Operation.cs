using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public enum Operation
    {
        Login,
        AddGrupa,
        AddProizvodjac,
        LogOut,
        GetGrupeWhere,
        GetLekoviGrupe,
        GetGrupa,
        DeleteGrupa,
        GetProizvodjaciWhere,
        GetProizvodjac,
        GetLekoviProizvodjaca,
        DeleteProizvodjac,
        GetOblici,
        AddLek,
        GetLekovi,
        GetObliciLeka,
        ChangeLek,
        DeleteLek
    }
}
