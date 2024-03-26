using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

namespace Server
{
    internal class Server
    {
        public static List<ClientHandler> clients = new List<ClientHandler>();
        Socket serverski;

        public Server()
        {
            serverski = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Start()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));
            serverski.Bind(endPoint);
            serverski.Listen(5);

            Thread thread = new Thread(Listen);
            thread.IsBackground = true;
            thread.Start();
        }
        public void Listen()
        {
            try
            {
                while (true)
                {
                    Socket klijentski = serverski.Accept();
                    ClientHandler handler = new ClientHandler(klijentski);
                    clients.Add(handler);
                    Thread klijentskaNit = new Thread(handler.Handle);
                    klijentskaNit.IsBackground = true;
                    klijentskaNit.Start();
                }
            }
            catch (SocketException)
            {
                foreach (ClientHandler c in clients)
                {
                    Stop();
                }

            }
        }

        public void Stop()
        {
            foreach (ClientHandler handler in clients) handler.Close();
            clients.Clear();
            serverski?.Close();
        }
    }
}


