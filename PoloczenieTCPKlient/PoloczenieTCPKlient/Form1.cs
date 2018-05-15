using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace PoloczenieTCPKlient
{
    public partial class Form1 : Form
    {
        //private static Socket ClientSocket;
        private klient aleph = new klient();
        //private delegate void message(string mes);
        public delegate void message(object mes);
        public static message f;

        // public TcpClient klient;
        public Form1()
        {
            InitializeComponent();
            f = new message(editLog);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = textBox1.Text;
            int port = System.Convert.ToInt16(numericUpDown1.Value);
            if( host == "" || port == 0) // psełdo zabezpieczenie
            {
                return;
            }
            
                if( !aleph.ConnectToServer(port,host)) { listBox1.Items.Add("nie ma serwera albo inny błąd"); return; }
                listBox1.Items.Add("Nawiazano polaczenie z " + host + " na porcie :" + port);
                 button1.Enabled = false;
                 button2.Enabled = true;
                 aleph.f_2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aleph.f("exit");
            button2.Enabled = false;
            button1.Enabled = true; 
          }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "") return;
            aleph.f(textBox2.Text);
            aleph.f_2();
           

        }

        private void editLog(object message)
        {
            listBox1.Invoke(new MethodInvoker(delegate { listBox1.Items.Add(message); listBox1.Refresh(); }));
        }

        //private static void ConnectToServer(int port,string host)
        //{
        //    int attempts = 0;
        //        ClientSocket = new Socket
        //                    (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //        while (!ClientSocket.Connected)
        //    {

        //        try
        //        {

        //                attempts++;
        //            Console.WriteLine("Connection attempt " + attempts);
        //            // Change IPAddress.Loopback to a remote IP to connect to a remote host.
        //            ClientSocket.Connect(host, port);

        //        }
        //        catch (SocketException)
        //        {
        //           // Console.Clear();
        //        }
        //    }
        //}

        //private static void RequestLoop()
        //{
        //    while (true)
        //    {
        //        SendRequest();
        //        ReceiveResponse();
        //    }
        //}
        //private static void Exit()
        //{
        //    SendString("exit"); // Tell the server we are exiting

        //    ClientSocket.Shutdown(SocketShutdown.Both);
        //    ClientSocket.Close();
        //    //Environment.Exit(0);
        //}

        //private static void SendRequest()
        //{
        //    Console.Write("Send a request: ");
        //    string request = Console.ReadLine();
        //    SendString(request);

        //    if (request.ToLower() == "exit")
        //    {
        //        Exit();
        //    }

        //}
        //private static void SendString(string text)
        //{
        //    byte[] buffer = Encoding.ASCII.GetBytes(text);

        //    ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        //}

        //private static void ReceiveResponse()
        //{
        //    var buffer = new byte[2048];
        //    int received = ClientSocket.Receive(buffer, SocketFlags.None);
        //    if (received == 0) return;
        //    var data = new byte[received];
        //    Array.Copy(buffer, data, received);
        //    string text = Encoding.ASCII.GetString(data);
        //    //Console.WriteLine(text);
        //}
    }
}
