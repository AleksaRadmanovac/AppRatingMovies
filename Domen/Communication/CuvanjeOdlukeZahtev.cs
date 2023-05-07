using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Communication
{
    [Serializable]
    public class CuvanjeOdlukeZahtev
    {
        public object Objekat { get; set; }
        public bool DodavanjeUloga { get; set; } = false;
    }
}
