using Commonn.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SONastup
{
    internal class KreirajNastupSO:SystemOperationBase
    {
        private readonly List<Nastup> nastupi;

        public KreirajNastupSO(List<Nastup> n)
        {
            nastupi = n;
        }
        protected override void ExecuteConcreteOperation()
        {
            foreach(Nastup nas in nastupi)
            {
                broker.Add(nas);
            }
        }
    }
}
