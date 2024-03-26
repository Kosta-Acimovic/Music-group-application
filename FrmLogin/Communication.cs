using Commonn.Communication;
using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    public class Communication
    {
        private static Communication _instance;
        public static Communication Instance
        {
            get
            {
                if (_instance == null) _instance = new Communication();
                return _instance;
            }
        }
        private Communication() { }

        Socket socket;
        Sender sender;
        Receiver receiver;

        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
                sender = new Sender(socket);
                receiver = new Receiver(socket);
            }           
        }
        public void Close()
        {
            socket?.Close();
        }
        internal Korisnik Login(string username, string password)
        {
            Korisnik korisnik = new Korisnik
            {
                Username = username,
                Password = password
            };
            Request request = new Request(Operation.Login, korisnik);
            sender.Send(request);
            return (Korisnik)((Response)receiver.Receive()).Result;
        }
        internal void Logout(string k)
        {
            Request request = new Request(Operation.Logout, k);
            sender.Send(request);
            receiver.Receive();
        }
        internal Response SacuvajNastup(List<Nastup> termini)
        {
            Request request = new Request(Operation.CreateScene, termini);
            sender.Send(request);
            return (Response)receiver.Receive();
        }
        public Response DodajIzvodjaca(List<Izvodjac> izvodjaci)
        {
            Request request = new Request(Operation.CreateSinger, izvodjaci);
            sender.Send(request);
            return (Response)receiver.Receive();
        }
        internal Response IzmeniIzvodjaca(Izvodjac izvodjac)
        {
            Request request = new Request(Operation.UpdateSinger, izvodjac);
            sender.Send(request);
            return (Response)receiver.Receive();
        }
        public List<Izvodjac> PretraziSveIzvodjace()
        {
            Request request = new Request(Operation.GetAllSingers, null);
            sender.Send(request);
            return (List<Izvodjac>)((Response)receiver.Receive()).Result;
        }
        internal List<Izvodjac> PretraziPoImenuIzvodjace(string filter)
        {
            Request request = new Request(Operation.GetSingerByName, filter);
            sender.Send(request);
            return (List<Izvodjac>)((Response)receiver.Receive()).Result;
        }
        internal Izvodjac NadjiIzvodjacaPoId(int id)
        {
            Request request = new Request(Operation.GetSingerById, id);
            sender.Send(request);
            return (Izvodjac)((Response)receiver.Receive()).Result;
        }
        public Response DodajMuzickuGrupu(MuzickaGrupa grupa)
        {
            Request request = new Request(Operation.CreateMusicGroup, grupa);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal Response IzmeniMuzickuGrupu(MuzickaGrupa grupa)
        {
            Request request = new Request(Operation.UpdateMusicGroup, grupa);
            sender.Send(request);
            return (Response)receiver.Receive();
        }
        internal List<MuzickaGrupa> PretraziSveMuzickeGrupe()
        {
            Request request = new Request(Operation.GetAllMusicGroups, null);
            sender.Send(request);
            return (List<MuzickaGrupa>)((Response)receiver.Receive()).Result;
        }
        internal List<Koncert> PretraziSveKoncerte()
        {
            Request request = new Request(Operation.GetAllConcerts, null);
            sender.Send(request);
            return (List<Koncert>)((Response)receiver.Receive()).Result;
        }
        internal List<MuzickaGrupa> PretraziPoImenuMuzickeGrupe(string filter)
        {
            Request request = new Request(Operation.GetMusicGroupByName, filter);
            sender.Send(request);
            return (List<MuzickaGrupa>)((Response)receiver.Receive()).Result;
        }
        internal MuzickaGrupa NadjiMuzickuGrupuPoId(MuzickaGrupa m)
        {
            Request request = new Request(Operation.GetMusicGroupById, m);
            sender.Send(request);
            return (MuzickaGrupa)((Response)receiver.Receive()).Result;
        }
        public Response DodajNastup(List<Nastup> nastup)
        {
            Request request = new Request(Operation.CreateScene, nastup);
            sender.Send(request);
            return (Response)receiver.Receive();
        }
        internal Response IzmeniNastup(Nastup nastup)
        {
            Request request = new Request(Operation.UpdateScene, nastup);
            sender.Send(request);
            return (Response)receiver.Receive();
        }
        internal Nastup NadjiNastupPoId(int id)
        {
            Request request = new Request(Operation.GetSceneById, id);
            sender.Send(request);
            return (Nastup)((Response)receiver.Receive()).Result;
        }
        public List<Nastup> PretraziSveNastupe()
        {
            Request request = new Request(Operation.GetAllScenes, null);
            sender.Send(request);
            return (List<Nastup>)((Response)receiver.Receive()).Result;
        }
        internal List<Nastup> PretraziPoDatumuNastupa(string filter)
        {
            Request request = new Request(Operation.GetSceneByDate, filter);
            sender.Send(request);
            return (List<Nastup>)((Response)receiver.Receive()).Result;
        }
        internal Response IzbrisiIzvodjaca(Izvodjac izvodjac)
        {
            Request request = new Request(Operation.DeleteSinger, izvodjac);
            sender.Send(request);
            return (Response)receiver.Receive();
        }
    }
}
