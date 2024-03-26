using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commonn.Domain
{
    [Serializable]
    public class Grad
    {
        public int GradId { get; set; }
        public string NazivGrada { get; set; }
        public override string ToString()
        {
            return NazivGrada;
        }
    }
}
