using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SONastup
{
    internal class IzmeniNastupSO : SystemOperationBase
    {
        private readonly Nastup nastup;
        public IzmeniNastupSO(Nastup n)
        {
            nastup = n;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Update(nastup);
        }
    }
}
