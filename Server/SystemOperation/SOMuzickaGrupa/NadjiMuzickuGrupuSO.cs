using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOMuzickaGrupa
{
    internal class NadjiMuzickuGrupuSO : SystemOperationBase
    {
        public List<IEntity> result { get; set; }
        public string Filter { get; set; }
        public NadjiMuzickuGrupuSO(string filter)
        {
            Filter = filter;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetAllByFilter(new MuzickaGrupa(), Filter);
        }
    }
}
