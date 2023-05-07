using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Help
    {
        private static Help instance;

        public static Help Instance 
        {
            get { if (instance == null) instance = new Help(); return instance; }
        }
        private Help() { }

        public int boolToNumber(bool b)
        {
            if (b) return 1;
            return 0;
        }

        public bool numberToBool(int n) 
        {
            if (n == 1) return true;
            return false;     
        }
    }
}
