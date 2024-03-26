using Commonn.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class LoginSO : SystemOperationBase
    {
        public IEntity result { get; set; }
        private readonly Korisnik korisnik;
        public LoginSO(Korisnik kor)
        {
            korisnik = kor;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetEntityById(korisnik);
        }

    }
}
