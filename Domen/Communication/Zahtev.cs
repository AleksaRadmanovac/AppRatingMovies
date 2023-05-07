using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Communication
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }

        public object Objekat { get; set; }

    }
}
