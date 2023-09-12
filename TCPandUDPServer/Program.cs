using System;
using System.Collections.Generic;
using TCPandUDPServer;

class Program
{

    static void Main(string[] args)

    {
        Console.WriteLine("Select :" +
            "1- TCP Server");
        Console.WriteLine("Select :" +
           "2- UDP Server");
        Console.WriteLine("Select :" +
           "3- TCP Client Message");
        Console.WriteLine("Select :" +
           "4- UDP Client Message");
        Console.WriteLine("****************************************************");
        var client = new Client();
        Console.WriteLine("Chatting sidan");

        int val;
        Console.Write("Enter Input: ");
        val = Console.ReadLine();
        
        Console.WriteLine(" Din input: {0}", val);


        if (val == 1)
        {
            var tcpserver = new TCPServer();
            tcpserver.runTCPServer();

        }

        if (val == 2)
        {
            var udpserver = new UDPServer();
            udpserver.runUDPServer();
        }


        if (val == 3)
        {
            while (true)
            {
                Console.Write("Enter Message: ");
                string messageTCP = Console.ReadLine();
                client.SendTcpMessage(messageTCP);
            }
        }

        if (val== 4)
        {
            while (true)
            {
                Console.Write("Enter Message: ");
                string messageUDP = Console.ReadLine();

                client.SendUdpMessage(messageUDP);
            }
        }
    }
}