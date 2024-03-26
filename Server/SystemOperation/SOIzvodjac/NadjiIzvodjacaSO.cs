using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOIzvodjac
{
    internal class NadjiIzvodjacaSO:SystemOperationBase
    {
        private readonly string Filter;
        public List<IEntity> result { get; set; }
        public NadjiIzvodjacaSO(string filter)
        {
            Filter = filter;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetAllByFilter(new Izvodjac(), Filter);
        }
    }
}
