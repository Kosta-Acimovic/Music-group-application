using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOMuzickaGrupa
{
    internal class IzmeniMuzickuGrupuSO : SystemOperationBase
    {
        public MuzickaGrupa muzickaGrupa { get; set; }
        public IzmeniMuzickuGrupuSO(MuzickaGrupa mg)
        {
            muzickaGrupa = mg;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Update(muzickaGrupa);
        }
    }
}
