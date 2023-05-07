using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Communication
{
    [Serializable]
    public class Odgovor
    {
        public object Objekat { get; set; }
        public Exception Exception { get; set; }

    }
}
