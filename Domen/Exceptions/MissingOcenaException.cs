using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Exceptions
{
    [Serializable]
    public class MissingOcenaException : Exception
    {
        public MissingOcenaException() { }
        public MissingOcenaException(SerializationInfo info, StreamingContext context) : base(info, context)
        { 
        
        }

        
    }
}
