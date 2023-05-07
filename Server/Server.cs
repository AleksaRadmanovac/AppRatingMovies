using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Server
    {
        private Socket serverSocket;
        private List<Socket> listaClientSocket = new List<Socket>();
        public bool kraj = false;

        public Server()
        { 
            
        }

        public void Start()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"])));
            serverSocket.Listen(10);
            Thread thread = new Thread(ObradiZahteve);
            thread.IsBackground = true;
            thread.Start(); 
        }

        private void ObradiZahteve()
        {
            kraj = false;
            while (!kraj)
            {
               try
               {
                    //Console.WriteLine("a");
                    Socket clientSocket = serverSocket.Accept();
                    listaClientSocket.Add(clientSocket);
                    ClientHandler handler = new ClientHandler(clientSocket);
                    Thread thread = new Thread(handler.ObradiZahtev);
                    thread.IsBackground = true;
                    thread.Start();
                }
                catch (Exception ex) { }                
            }
        }
        public void Close()
        {
            kraj = true;
            foreach (Socket clientSocket in listaClientSocket)
            {
                clientSocket.Close();
            }
            serverSocket.Close();

        }



    }
}
