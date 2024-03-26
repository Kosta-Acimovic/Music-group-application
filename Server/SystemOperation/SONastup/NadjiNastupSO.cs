using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SONastup
{
    internal class NadjiNastupSO : SystemOperationBase
    {
        private readonly string filter;
        public List<IEntity> result { get; set; }
        public NadjiNastupSO(string filter)
        {
            this.filter = filter;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetAllByFilter(new Nastup(), filter);
        }
    }
}
