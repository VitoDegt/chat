using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
    class ChatServer
    {

        private string loggin = "key User";
        private string tempLogin;

        public ChatServer() {

        }

        public void Start() {
            TcpListener listner = new TcpListener(
                IPAddress.Parse("127.0.0.1"), 8080
            );
            listner.Start();
            Console.WriteLine("Server started");
            TcpClient client = listner.AcceptTcpClient();
            using (Stream stream = client.GetStream()) {

                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream);

                tempLogin.Split(' ').ToArray();
                while (true) {
                    Console.Write("Enter your message?>");
                    string userInput = Console.ReadLine();
                    writer.WriteLine(userInput);
                    writer.Flush();
                    Console.Write("You received a message: ");
                    Console.WriteLine(reader.ReadLine());
                }
            }

        }
    }
}
