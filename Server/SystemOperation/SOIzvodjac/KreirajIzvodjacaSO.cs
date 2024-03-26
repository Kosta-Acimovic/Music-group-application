using Commonn.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOIzvodjac
{
    internal class KreirajIzvodjacaSO:SystemOperationBase
    {
        private readonly List<Izvodjac> izvodjaci;

        public KreirajIzvodjacaSO(List<Izvodjac> i)
        {
            izvodjaci = i;
        }
        protected override void ExecuteConcreteOperation()
        {
            foreach (Izvodjac izv in izvodjaci)
            {
             broker.Add(izv);
            }
        }
    }
}
