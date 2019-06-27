using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            Socket s = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endpoint = new IPEndPoint(ip, 8000);
            s.Connect(endpoint);
            byte[] data = Encoding.ASCII.GetBytes("Hello from the other world");
            s.Send(data);
            //Socket client = s.Accept();
            byte[] b = new byte[1024];
            int numbyte = s.Receive(b);
            string msg = Encoding.ASCII.GetString(b, 0, numbyte);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
