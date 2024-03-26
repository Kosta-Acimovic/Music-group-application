using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOIzvodjac
{
    internal class UcitajListuIzvodjacaSO:SystemOperationBase
    {
        public List<IEntity> result { get; set; }
        public bool ReadAll { get; set; }
        public UcitajListuIzvodjacaSO(bool allAttributes = false)
        {
            ReadAll = allAttributes;
        }
        protected override void ExecuteConcreteOperation()
        {
            if (ReadAll)
            {
                result = broker.ReadAll(new Izvodjac());
            }
            else result = broker.ReadAllSearch(new Izvodjac());
        }
    }
}
