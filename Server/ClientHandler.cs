using Common;
using Controller;
using Domen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket clientSocket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();
        private List<Socket> connectedClients;
        Korisnik noviKorisnik;
        public ClientHandler(Socket clientSocket, List<Socket> connectedClients)
        {
            this.clientSocket = clientSocket;
            stream = new NetworkStream(clientSocket);
            this.connectedClients = connectedClients;
        }

        public void StartHandler()
        {
            bool end = false;
            while (!end)
            {
                try
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response = new Response();
                    switch (request.Operation)
                    {
                        case Operation.Login:
                            noviKorisnik = (Korisnik)request.Object;
                            if (Server.PrijavljeniKorisnici.Any(k => k.KorisnickoIme == noviKorisnik.KorisnickoIme && k.Lozinka == noviKorisnik.Lozinka))
                            {
                                response.Message = Message.VecUlogovan;

                            }
                            else
                            {
                                noviKorisnik = Controller.Controller.Instance.Login(noviKorisnik);
                                response.Object = noviKorisnik;
                                response.PrijavljeniKorisnik = noviKorisnik;
                            }
                            if (response.Object != null)
                                Server.PrijavljeniKorisnici.Add(noviKorisnik);
                            break;
                        case Operation.AddGrupa:
                            response.Signal = Controller.Controller.Instance.SaveGrupa((GrupaLekova)request.Object);
                            break;
                        case Operation.GetGrupeWhere:
                            response.Object = Controller.Controller.Instance.GetGrupeWhere((GrupaLekova)request.Object);
                            break;
                        case Operation.GetGrupa:
                            response.Object = Controller.Controller.Instance.GetGrupa((GrupaLekova)request.Object);
                            break;
                        case Operation.GetLekoviGrupe:
                            response.Object = Controller.Controller.Instance.GetLekoviGrupe((Lek)request.Object);
                            break;
                        case Operation.DeleteGrupa:
                            response.Signal = (bool)Controller.Controller.Instance.DeleteGrupa((GrupaLekova)request.Object);
                            break;
                        case Operation.AddProizvodjac:
                            response.Signal = Controller.Controller.Instance.SaveProizvodjac((ProizvodjacLekova)request.Object);
                            break;
                        case Operation.GetProizvodjaciWhere:
                            response.Object = Controller.Controller.Instance.GetProizvodjaciWhere((ProizvodjacLekova)request.Object);
                            break;
                        case Operation.GetProizvodjac:
                            response.Object = Controller.Controller.Instance.GetProizvodjac((ProizvodjacLekova)request.Object);
                            break;
                        case Operation.GetLekoviProizvodjaca:
                            response.Object = Controller.Controller.Instance.GetLekoviProizvodjaca((Lek)request.Object);
                            break;
                        case Operation.DeleteProizvodjac:
                            response.Signal = (bool)Controller.Controller.Instance.DeleteProizvodjac((ProizvodjacLekova)request.Object);
                            break;
                        case Operation.GetOblici:
                            response.Object = Controller.Controller.Instance.GetOblici((OblikLeka)request.Object);
                            break;
                        case Operation.AddLek:
                            response.Signal = Controller.Controller.Instance.AddLek((Lek)request.Object);
                            break;
                        case Operation.GetLekovi:
                            response.Object = Controller.Controller.Instance.GetLekoviGrupe((Lek)request.Object);
                            break;
                        case Operation.GetObliciLeka:
                            response.Object = Controller.Controller.Instance.GetObliciLeka((JacinaLeka)request.Object);
                            break;
                        case Operation.ChangeLek:
                            response.Signal = Controller.Controller.Instance.UpdateLek((Lek)request.Object);
                            break;
                        case Operation.DeleteLek:
                            response.Signal = Controller.Controller.Instance.DeleteLek((Lek)request.Object);
                            break;
                        case Operation.LogOut:
                            Server.PrijavljeniKorisnici.Remove(noviKorisnik);
                            break;
                        default:
                            break;
                    }
                    formatter.Serialize(stream, response);
                }
                catch (SocketException)
                {
                    end = true;
                    connectedClients.Remove(clientSocket);
                }
                catch (IOException)
                {
                    end = true;
                    connectedClients.Remove(clientSocket);
                }
            }
        }
    }
}
