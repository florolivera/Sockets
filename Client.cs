using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Client
    {
        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endPoint;

        Socket s_Client;

        public Client(string ip, int port)
        {
            host = Dns.GetHostByName(ip);
            ipAddr = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddr, port);

            s_Client = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s_Client.Bind(endPoint);


        }

        public void Start()
        {
            s_Client.Connect(endPoint);
        }

        public void Send(string msg)
        {
            byte[] byteMsg = Encoding.ASCII.GetBytes(msg);
            s_Client.Send(byteMsg);
            Console.WriteLine("MENSAJE ENVIADO");
        }
    }
}
