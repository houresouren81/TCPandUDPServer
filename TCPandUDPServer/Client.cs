using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCPandUDPServer
{
    internal class Client : Settings
    {
        public void SendTcpMessage(string message)
        {

            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Loopback, TCP_PORT);
            NetworkStream stream = tcpClient.GetStream();
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("TCP Message sent: " + message);
            stream.Close();
            tcpClient.Close();
        }
        public void SendUdpMessage(string message)
        {

            UdpClient udpClient = new UdpClient();
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Loopback, UDP_PORT);
            byte[] data = Encoding.ASCII.GetBytes(message);
            udpClient.Send(data, data.Length, serverEndPoint);
            Console.WriteLine("UDP Message sent: " + message);
            udpClient.Close();


        }
    }
}

