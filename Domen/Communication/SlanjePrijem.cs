using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domen.Communication
{
    public class SlanjePrijem
    {
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public SlanjePrijem(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public T Prijem<T>() where T: class 
        {
            try
            {
                T t = (T)formatter.Deserialize(stream);
                return t;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Slanje(object obj)
        {
            try
            {
                formatter.Serialize(stream, obj);
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }


    }
}
