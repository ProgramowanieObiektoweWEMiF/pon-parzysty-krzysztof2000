using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace PoloczenieTCPKlient
{
    class klient
    {
        private static Socket ClientSocket;
        public delegate void message(string mes);
        public delegate void Receive();
        public  message f;
        public Receive f_2;
        private static byte[] buffer = new byte[2048];

        public klient()
        {
            f = new message(SendString);
            f_2 = new Receive(ReceiveResponse);
        }
        public  bool ConnectToServer(int port, string host)
        {
           // int attempts = 0;
            ClientSocket = new Socket
                        (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
          //  while (!ClientSocket.Connected)
           // {
                

                try
                {

                    
                   // Console.WriteLine("Connection attempt " + attempts);
                    // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                    //if ( attempts == 0)
                        ClientSocket.BeginConnect(host, port, null, null);
                    //attempts++;
                   // if (attempts > 30000000) { ClientSocket.Close(); return false; }

                }
                catch (SocketException)
                {
                    return false;
                    // Console.Clear();
                }
            Thread.Sleep(1000);
            if (!ClientSocket.Connected)
            {
                ClientSocket.Close();
                return false;
            }
            // }
            
            return true;
        }

        /* private static void RequestLoop()
         {
             while (true)
             {
                 //SendRequest();
                 ReceiveResponse();
             }
         }*/
        /*private static void Exit()
        {
            SendString("exit"); // Tell the server we are exiting

            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();
            //Environment.Exit(0);
        }*/

        /* private static void SendRequest()
         {
             Console.Write("Send a request: ");


             if (request.ToLower() == "exit")
             {
                 Exit();
             }

         }*/
        private static void Accept(IAsyncResult AR)
        {

           // ClientSocket.BeginReceive(buffer, 0, 2048, SocketFlags.None, ReceiveResponse, ClientSocket);
        }
        private static  void SendString(string text)
        {
            
            byte[] buffer = Encoding.ASCII.GetBytes(text);

            ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private static void ReceiveResponse()
        {
            //var buffer = new byte[2048];
            int i = 0;
            next:
            int received = ClientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0)
            {
                // ClientSocket.BeginReceive(buffer, 0, 2048, SocketFlags.None, ReceiveResponse, ClientSocket);
                //return;
                ++i;
                if (i > 1000000) return;
                goto next;
            }
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);
            Form1.f(text.ToLower());
            //ClientSocket.BeginReceive(buffer, 0, 2048, SocketFlags.None, ReceiveResponse, ClientSocket);
            //Console.WriteLine(text);
        }
    }
}
