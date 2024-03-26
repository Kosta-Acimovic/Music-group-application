using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOIzvodjac
{
    internal class UcitajIzvodjacaSO:SystemOperationBase
    {
        private readonly Izvodjac izvodjac = new Izvodjac();
        public IEntity result { get; set; }
        public int Id { get; set; }
        public UcitajIzvodjacaSO(int id)
        {
            Id = id;
        }
        protected override void ExecuteConcreteOperation()
        {
            izvodjac.IzvodjacId = Id;
            result = broker.GetEntityById(izvodjac);
        }
    }
}
