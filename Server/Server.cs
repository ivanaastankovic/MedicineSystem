using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        Socket serverSocket;
        List<Socket> clients = new List<Socket>();
        public static List<Korisnik> PrijavljeniKorisnici { get; set; } = new List<Korisnik>();
        public Server()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9001);
            serverSocket.Bind(iPEndPoint);
            serverSocket.Listen(5);
        }

        public void Start()
        {
            try
            {
                while (true)
                {
                    Socket connectedClient = serverSocket.Accept();
                    clients.Add(connectedClient);
                    ClientHandler clientHandler = new ClientHandler(connectedClient,clients);
                    Thread clientThread = new Thread(clientHandler.StartHandler);
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(">>>"+ex.Message);
                return;
            }
        }

        public bool Stop()
        {
            if (PrijavljeniKorisnici.Count != 0)
            {
                return false;
            }
            else
            {
                serverSocket.Close();
                foreach (Socket client in clients)
                {
                    client.Close();
                }
                clients.Clear();
                return true; 
            }
        }
    }
}
