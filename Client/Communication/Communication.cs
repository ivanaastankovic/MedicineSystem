using Common;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Client.Communication
{
    public class Communication
    {
        private static Communication communication;
        private Socket client;
        private BinaryFormatter formatter = new BinaryFormatter();
        private NetworkStream stream;


        public static Korisnik PrijavljeniKorisnik { get; set; }
        
        public static Communication Instance
        {
            get
            {
                if (communication == null)
                {
                    communication = new Communication();
                }
                return communication;
            }
        }

        public Communication()
        {
        }


        public bool Connect()
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    client.Connect("127.0.0.1", 9001);
                    stream = new NetworkStream(client);
                }
                return true;
            }
            catch (SocketException)
            {
                return false;
            }

        }
        public void SendRequest(object obj, Operation o)
        {
            Request request = new Request()
            {
                Object = obj,
                Operation = o
            };
            formatter.Serialize(stream, request);
        }

        public bool AddGrupa(GrupaLekova grupa)
        {
            SendRequest(grupa, Operation.AddGrupa);
            Response response = (Response)formatter.Deserialize(stream);
            return response.Signal;
        }
        internal List<GrupaLekova> GetGrupe(GrupaLekova grupaWhere)
        {
            SendRequest(grupaWhere, Operation.GetGrupeWhere);
            Response response = (Response)formatter.Deserialize(stream);
            return (List<GrupaLekova>)response.Object;
        }
        internal List<Lek> GetLekovi(Lek lek)
        {
            SendRequest(lek, Operation.GetLekovi);
            Response response = (Response)formatter.Deserialize(stream);
            return (List<Lek>)response.Object;
        }

        internal List<JacinaLeka> GetObliciLeka(JacinaLeka obliciLeka)
        {
            SendRequest(obliciLeka, Operation.GetObliciLeka);
            Response response = (Response)formatter.Deserialize(stream);
            return (List<JacinaLeka>)response.Object;
        }



        internal bool DeleteGrupa(GrupaLekova grupaDelete)
        {
            SendRequest(grupaDelete, Operation.DeleteGrupa);
            Response response = (Response)formatter.Deserialize(stream);
            return response.Signal;
        }

        internal GrupaLekova GetGrupa(GrupaLekova grupaDGV)
        {
            SendRequest(grupaDGV, Operation.GetGrupa);
            Response response = (Response)formatter.Deserialize(stream);
            return (GrupaLekova)response.Object;
        }

        internal ProizvodjacLekova GetProizvodjac(ProizvodjacLekova proizvodjacDGV)
        {
            SendRequest(proizvodjacDGV, Operation.GetProizvodjac);
            Response response = (Response)formatter.Deserialize(stream);
            return (ProizvodjacLekova)response.Object;
        }

        internal bool ChangeLek(Lek lek)
        {
            SendRequest(lek, Operation.ChangeLek);
            Response response = (Response)formatter.Deserialize(stream);
            return response.Signal;
        }

        internal List<Lek> GetLekoviGrupe(Lek lek)
        {
            SendRequest(lek, Operation.GetLekoviGrupe);
            Response response = (Response)formatter.Deserialize(stream);
            return (List<Lek>)response.Object;
        }

        internal bool DeleteProizvodjac(ProizvodjacLekova proizvodjacDelete)
        {
            SendRequest(proizvodjacDelete, Operation.DeleteProizvodjac);
            Response response = (Response)formatter.Deserialize(stream);
            return response.Signal;
        }

        internal bool DeleteLek(Lek lekDelete)
        {
            SendRequest(lekDelete, Operation.DeleteLek);
            Response response = (Response)formatter.Deserialize(stream);
            return response.Signal;
        }

        internal bool AddLek(Lek lek)
        {
            SendRequest(lek, Operation.AddLek);
            Response response = (Response)formatter.Deserialize(stream);
            return response.Signal;
        }

        public bool Login(string username, string password)
        {
            Korisnik k = new Korisnik
            {
                KorisnickoIme = username,
                Lozinka = password
            };
            SendRequest(k, Operation.Login);
            Response response = (Response)formatter.Deserialize(stream);

            if ((Korisnik)response.Object != null)
            {
                PrijavljeniKorisnik = (Korisnik)response.PrijavljeniKorisnik;
                return true;
            }
            else
            {
                return false;
            }
        }


    
      
        internal bool AddProizvodjac(ProizvodjacLekova proizvodjac)
        {
            SendRequest(proizvodjac, Operation.AddProizvodjac);
            Response response = (Response)formatter.Deserialize(stream);
            return response.Signal;
        }

        internal List<Lek> GetLekoviProizvodjaca(Lek lek)
        {
            SendRequest(lek, Operation.GetLekoviProizvodjaca);
            Response response = (Response)formatter.Deserialize(stream);
            return (List<Lek>)response.Object;
        }

        
        internal List<ProizvodjacLekova> GetProizvodjaci(ProizvodjacLekova proizvodjacLekova)
        {
            SendRequest(proizvodjacLekova, Operation.GetProizvodjaciWhere);
            Response response = (Response)formatter.Deserialize(stream);
            return (List<ProizvodjacLekova>)response.Object;
        }
        internal List<OblikLeka> GetOblici(OblikLeka oblikLeka)
        {
            SendRequest(oblikLeka, Operation.GetOblici);
            Response response = (Response)formatter.Deserialize(stream);
            return (List<OblikLeka>)response.Object;
        }
        internal void LogOut()
        {
            SendRequest(null, Operation.LogOut);
        }
    }
}
