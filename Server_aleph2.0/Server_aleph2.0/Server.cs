using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;



namespace Server_aleph_2
{
    public class Server 
    {
       //private volatile int flagLog = 0; // flaga dla wątków wyświetlających logi
        private static  Socket serverSocket;
        public static readonly List<Socket> clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];
        
       

        public void StartServer(int port)
        {
            try
            {
                 serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                 serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));
                 serverSocket.Listen(0);
                 serverSocket.BeginAccept(AcceptCallback, null);
               
                 window_server.f("Mamy boski server aleph2.0, względnie jest uruchomiony");
               
                }
            catch (SocketException ex)
            {
                window_server.ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                window_server.ShowErrorDialog(ex.Message);
            }
        }

        public  void StopServer() 
        {
            foreach (Socket socket in clientSockets) // wysyła do każdego klienta wiadomość exit oraz zamyka nasłuchiwanie
            {
                socket.Send( Encoding.ASCII.GetBytes("exit"));
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                
                
            }
            clientSockets.Clear();// czyści liste klientów 
           
            serverSocket.Close(); // zamykamy serwer 
            window_server.f("Nie mamy serwerka aleph.");
        }

        /*
         * metoda nasuchiwania klientów
         * gdy dostaniemy możliwość połączenia osoby, tworzymy jej gniazdo nasłuchu 
         * dalsza obsługa przenoszona do metody odbiodu danych ReceiveCallback
         */
        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException)
            {
                return;
            }

           clientSockets.Add(socket);
           socket.Send(Encoding.ASCII.GetBytes("Witamy na boskim serwerku\n\r"));
           socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket); 
           serverSocket.BeginAccept(AcceptCallback, null);
           
            window_server.f("OO! mammy klienta");
               
          
        }



        /*
         * metoda odbiodu danych
         * tutaj również dekodujemy rozkazy wysyłane od klientów 
         */
        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received = 0;

            try
            {
                if (current.Connected == false) return;
               received = current.EndReceive(AR);
               
            }
            catch (SocketException)
            {
                window_server.f("i nie mamy klienta");

                current.Shutdown(SocketShutdown.Both);
                current.Close();
                clientSockets.Remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);

            if (text.ToLower() == "witaj") // klient wita się z nami, bardzo miły jest ten klient 
            {
                window_server.f("klient mówi nam cześć");
                byte[] data = Encoding.ASCII.GetBytes("czesc klient\n\r");
                current.Send(data);

                
            }
            else if (text.ToLower() == "exit") // rozłącz
            {
               // byte[] data = Encoding.ASCII.GetBytes("exit");
               // current.Send(data);
                current.Shutdown(SocketShutdown.Both);
                current.Close();
                clientSockets.Remove(current);
                window_server.f("klient powiedział nam pa pa");
                return;
            }
            else if (text.ToLower() == "jaki czas") // wyśli czas
            {
                byte[] data = Encoding.ASCII.GetBytes(DateTime.Now.ToLongTimeString() + "\n\r");
                current.Send(data);
            }
            else // nierozpoznane komendy 
            {
                current.Send(Encoding.ASCII.GetBytes("error inne"));
            }

            try
            {
                current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
            }
            catch (SocketException)
            {
                window_server.f("ooo, był klient i go nie ma");
                if (current.Connected == true)
                    current.Shutdown(SocketShutdown.Both);
                current.Close();
                clientSockets.Remove(current);
                return;
            }
        }

        
    }
}
