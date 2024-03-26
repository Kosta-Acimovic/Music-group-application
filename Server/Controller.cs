using Commonn.Domain;
using DBBroker;
using Server.SystemOperation;
using Server.SystemOperation.SOIzvodjac;
using Server.SystemOperation.SOKoncert;
using Server.SystemOperation.SOMuzickaGrupa;
using Server.SystemOperation.SONastup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Controller
    {
        public List<string> ulogovani = new List<string>();
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() { }
        #region log
        internal Korisnik Login(Korisnik k)
        {
            string logovan = k.Username + k.Password;
            bool postoji = logged(logovan);
            if (postoji)
            {
                k.Username = "a";
                return k;
            }
            LoginSO so = new LoginSO(k);
            so.ExecuteTemplate();
            if ((Korisnik)so.result != null) ulogovani.Add(logovan);
            return (Korisnik)so.result;
        }
        internal bool logged(string korisnik)
        {
            foreach (string kor in ulogovani)
            {
                if (korisnik == kor) return true;
            }
            return false;
        }

        internal void Logout(string k)
        {
            ulogovani.Remove(k);
        }
        #endregion
        #region muzicka grupa
        internal void AddMusicGroup(MuzickaGrupa mg)
        {
            KreirajMuzickuGrupuSO so = new KreirajMuzickuGrupuSO(mg);
            so.ExecuteTemplate();
        }
        internal object GetAllMusicGroups()
        {
            UcitajListuMuzickihGrupaSO so = new UcitajListuMuzickihGrupaSO();
            so.ExecuteTemplate();
            return so.result.Cast<MuzickaGrupa>().ToList();
        }
        internal object GetAllMusicGroupsFilter(string filter)
        {
            NadjiMuzickuGrupuSO so = new NadjiMuzickuGrupuSO(filter);
            so.ExecuteTemplate();
            return so.result.Cast<MuzickaGrupa>().ToList();
        }
        internal object GetMusicGroupsById(MuzickaGrupa id)
        {
            UcitajMuzickuGrupuSO so = new UcitajMuzickuGrupuSO(id);
            so.ExecuteTemplate();
            return (MuzickaGrupa)so.result;
        }
        internal void UpdateMusicGroup(MuzickaGrupa mg)
        {
            IzmeniMuzickuGrupuSO so = new IzmeniMuzickuGrupuSO(mg);
            so.ExecuteTemplate();
        }
        #endregion
        #region izvodjac
        internal void AddSinger(List<Izvodjac> i)
        {
            KreirajIzvodjacaSO so = new KreirajIzvodjacaSO(i);
            so.ExecuteTemplate();
        }
        internal object GetAllSingers()
        {
            UcitajListuIzvodjacaSO so = new UcitajListuIzvodjacaSO();
            so.ExecuteTemplate();
            return so.result.Cast<Izvodjac>().ToList();
        }
        internal object GetSingerById(int id)
        {
            UcitajIzvodjacaSO so = new UcitajIzvodjacaSO(id);
            so.ExecuteTemplate();
            return (Izvodjac)so.result;
        }
        internal object GetSingerByName(string filter)
        {
            NadjiIzvodjacaSO so = new NadjiIzvodjacaSO(filter);
            so.ExecuteTemplate();
            return so.result.Cast<Izvodjac>().ToList();
        }
        internal void UpdateSinger(Izvodjac i)
        {
            IzmeniIzvodjacaSO so = new IzmeniIzvodjacaSO(i);
            so.ExecuteTemplate();
        }
        internal void DeleteSinger(Izvodjac i)
        {
            IzbrisiIzvodjacaSO so = new IzbrisiIzvodjacaSO(i);
            so.ExecuteTemplate();
        }
        #endregion
        #region koncert
        internal object GetAllConcerts()
        {
            UcitajListuKoncerataSO so = new UcitajListuKoncerataSO();
            so.ExecuteTemplate();
            return so.result.Cast<Koncert>().ToList();
        }
        #endregion
        #region nastup
        internal void AddScene(List<Nastup>nastupi)
        {
            KreirajNastupSO so = new KreirajNastupSO(nastupi);
            so.ExecuteTemplate();
        }
        internal void UpdateScene(Nastup n)
        {
            IzmeniNastupSO so = new IzmeniNastupSO(n);
            so.ExecuteTemplate();
        }

        internal object GetAllScenes()
        {
            UcitajListuNastupaSO so = new UcitajListuNastupaSO();
            so.ExecuteTemplate();
            return so.result.Cast<Nastup>().ToList();
        }
        internal object GetSceneById(int id)
        {
            UcitajNastupSO so = new UcitajNastupSO(id);
            so.ExecuteTemplate();
            return (Nastup)so.result;
        }
        internal object GetSceneByDate(string filter)
        {
            NadjiNastupSO so = new NadjiNastupSO(filter);
            so.ExecuteTemplate();
            return so.result.Cast<Nastup>().ToList();
        }

        #endregion
    }
}
