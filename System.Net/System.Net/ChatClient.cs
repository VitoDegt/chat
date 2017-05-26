using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
    class ChatClient
    {

        
        private string tempLogin;
        //Dictionary<int, string> database = new Dictionary<int, string>();
        public ChatClient()
        {

        }

        public void Connect()
        {

            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 8080);
            using (var stream = client.GetStream())
            {
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream);

                Console.WriteLine("Enter password and loggin");
                tempLogin = Console.ReadLine();
                

                

                    while (true)
                    {
                        Console.Write("You received: ");
                        Console.WriteLine(reader.ReadLine());
                        string input = Console.ReadLine();
                        writer.WriteLine(input);
                        writer.Flush();
                    }
                } 
            }
        }
    }
}
