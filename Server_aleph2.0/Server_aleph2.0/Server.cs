using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;



namespace Server_aleph_2
{
    public class Server 
    {
       //private volatile int flagLog = 0; // flaga dla wątków wyświetlających logi
        private static  Socket serverSocket;
        public static readonly List<Socket> clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];
        private static Control alephControl ;

        public Server(object input)
        {
            alephControl = (Control)input;

        }
        public void StartServer(int port)
        {
            try
            {
                 serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                 serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));
                 serverSocket.Listen(0);
                 serverSocket.BeginAccept(AcceptCallback, null);
               
                 window_server.Log("Mamy boski server aleph2.0, względnie jest uruchomiony");
               
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
                try
                {
                    socket.Send(Encoding.ASCII.GetBytes("exit"));
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
                catch (SocketException)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
                
                
            }
            clientSockets.Clear();// czyści liste klientów 
            if(serverSocket != null)
                serverSocket.Close(); // zamykamy serwer 
            window_server.Log("Nie mamy serwerka aleph.");
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
           socket.Send(Encoding.ASCII.GetBytes("Witamy na boskim serwerku"));
           socket.Send(Encoding.ASCII.GetBytes("|end"));
           socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
           serverSocket.BeginAccept(AcceptCallback, null);
           
            window_server.Log("OO! mammy klienta");
               
          
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
                window_server.Log("i nie mamy klienta");

                current.Shutdown(SocketShutdown.Both);
                current.Close();
                clientSockets.Remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            string[] tab_string = text.Split('|');
           
           
            if (tab_string[0].ToLower() == "exit") // rozłącz
            {
               // byte[] data = Encoding.ASCII.GetBytes("exit");
               // current.Send(data);
                current.Shutdown(SocketShutdown.Both);
                current.Close();
                clientSockets.Remove(current);
                window_server.Log("klient powiedział nam pa pa");
                return;
            }
            else if (tab_string[0].ToLower() == "kolekcja")
            {
                foreach (var items in Control.info.ListBook)
                {
                    byte[] data = Encoding.ASCII.GetBytes(items.NameBook + "|" + items.WhoWrote + "|" + items.Description + "|" + items.Borrow + "|");
                  
                    current.Send(data);
                }
                current.Send(Encoding.ASCII.GetBytes("|end"));
            }
            else if (tab_string[0] == "wyp")
            {
                byte[] data ;
                if(tab_string.Length > 1)
                     data = Encoding.ASCII.GetBytes(alephControl.SearchBook(tab_string[1]) + "|end");
                else 
                      data = Encoding.ASCII.GetBytes("brak argumentu|end");
                current.Send(data);
            }
            else if (tab_string[0] == "zwr")
            {
                byte[] data;
                if (tab_string.Length > 1)
                    data = Encoding.ASCII.GetBytes(alephControl.BackBook(tab_string[1]) + "|end");
                else
                    data = Encoding.ASCII.GetBytes("brak argumentu|end");
                current.Send(data);
            }
            else // nierozpoznane komendy 
            {
            }


            try
            {
                current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
            }
            catch (SocketException)
            {
                window_server.Log("ooo, był klient i go nie ma");
            
               // current.Shutdown(SocketShutdown.Both);
                current.Close();
                clientSockets.Remove(current);
                return;
            }
        }

        
    }
}
