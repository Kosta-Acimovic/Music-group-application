using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOMuzickaGrupa
{
    internal class KreirajMuzickuGrupuSO : SystemOperationBase
    {
        private readonly MuzickaGrupa muzickaGrupa;
        public KreirajMuzickuGrupuSO(MuzickaGrupa muzickaGrupa)
        {
            this.muzickaGrupa = muzickaGrupa;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(muzickaGrupa);
        }
    }
}
