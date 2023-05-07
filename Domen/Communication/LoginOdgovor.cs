using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Communication
{
    [Serializable]
    public class LoginOdgovor
    { 
        public object Nalog { get; set; }
        public bool Uspesan { get; set; }
    }
}
