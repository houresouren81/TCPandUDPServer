using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCPandUDPServer
{
    internal class TCPServer:Settings
    {
        public void runTCPServer()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, TCP_PORT);
            tcpListener.Start();
            Console.WriteLine("TCP Server started. Väntar på anslutting......");
            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Console.WriteLine("TCP Client connected.");
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("TCP Message received: " + message);
                stream.Close();
                client.Close();
            }
        }
    }
}

