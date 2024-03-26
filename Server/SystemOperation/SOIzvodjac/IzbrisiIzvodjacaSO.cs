using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOIzvodjac
{
    internal class IzbrisiIzvodjacaSO : SystemOperationBase
    {
        private readonly Izvodjac izvodjac;
        public IzbrisiIzvodjacaSO(Izvodjac i)
        {
            izvodjac = i;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Delete(izvodjac);
        }
    }
}
