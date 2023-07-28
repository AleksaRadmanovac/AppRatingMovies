using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiranje
{
    internal class PomocnaTestKlasa
    {

            public Object O { get; set; }
            public bool AreEqual { get; set; }

            public PomocnaTestKlasa(Object o, bool areEqual)
            {
                O = o;
                AreEqual = areEqual;
            }

    }
}
