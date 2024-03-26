using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOMuzickaGrupa
{
    internal class UcitajMuzickuGrupuSO : SystemOperationBase
    {
        public IEntity result { get; set; }
        public int Id { get; set; }
        public UcitajMuzickuGrupuSO(MuzickaGrupa m)
        {
            Id = m.GrupaId;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetEntityById(new MuzickaGrupa() { GrupaId = Id });
        }
    }
}
