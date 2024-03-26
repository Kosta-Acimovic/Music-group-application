using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SONastup
{
    internal class UcitajNastupSO : SystemOperationBase
    {
        private readonly Nastup nastup = new Nastup();
        public IEntity result { get; set; }
        public int Id { get; set; }
        public UcitajNastupSO(int id)
        {
            Id = id;
        }
        protected override void ExecuteConcreteOperation()
        {
            nastup.IdNastupa = Id;
            result = broker.GetEntityById(nastup);
        }
    }
}