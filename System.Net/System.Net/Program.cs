using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Do you want to be a server? (y/n)");
            if (Console.ReadLine() == "y") {
                ChatServer server = new ChatServer();
                server.Start();
            }
            else {
                ChatClient client = new ChatClient();
                client.Connect();
            }
        }
    }
}
