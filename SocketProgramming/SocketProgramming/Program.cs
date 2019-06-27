using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            Socket s = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            //in tcp we know about the client. free hand in UDp no confermation between tcp and udp
            IPEndPoint endpoint = new IPEndPoint(ip, 8000);
            s.Bind(endpoint);
            s.Listen(10);
            Console.WriteLine("Server is listining");
            while(true)
            {
                Socket client = s.Accept();
                byte[] b = new byte[1024];
                int numbyte = client.Receive(b);
                string data = Encoding.ASCII.GetString(b,0, numbyte);
                Console.WriteLine(data);
                byte[] msg = Encoding.ASCII.GetBytes("Hello from the server");
                client.Send(msg);
                Console.ReadKey();

            }
        }
    }
}
