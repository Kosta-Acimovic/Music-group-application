using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOMuzickaGrupa
{
    internal class UcitajListuMuzickihGrupaSO : SystemOperationBase
    {
        public List<IEntity> result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.ReadAllSearch(new MuzickaGrupa());
        }
    }
}
