using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOKoncert
{
    internal class UcitajListuKoncerataSO : SystemOperationBase
    {
        public List<IEntity> result { get; set; }
        public bool ReadAll { get; set; }
        public UcitajListuKoncerataSO(bool allAttributes = false)
        {
            ReadAll = allAttributes;
        }
        protected override void ExecuteConcreteOperation()
        {
            if (ReadAll)
            {
                result = broker.ReadAll(new Koncert());
            }
            else result = broker.ReadAllSearch(new Koncert());
        }
    }
}
