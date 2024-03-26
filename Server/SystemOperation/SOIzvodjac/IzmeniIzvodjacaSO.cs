using Commonn.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOIzvodjac
{
    internal class IzmeniIzvodjacaSO:SystemOperationBase
    {
        private readonly Izvodjac izvodjac;
        public IzmeniIzvodjacaSO(Izvodjac i)
        {
            izvodjac = i;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Update(izvodjac);
        }
    }
}
