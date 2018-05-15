using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace Server_aleph_2
{
    public partial class window_server : Form
    {

        private Server aleph = new Server(); // inicjacja klasy serwer
        public delegate int messageTolog(string message);
        public static messageTolog  f;
       
        public window_server()
        {
           
            InitializeComponent();
            f = new messageTolog(editLog);
           
            // StartServer();
        }

        public static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port = System.Convert.ToInt16(numericUpDown1.Value);
            aleph.StartServer(port);
            button1.Enabled = false;
            buttonKlient.Enabled = true;
            numericUpDown1.Enabled = false;
            buttonStop.Enabled = true;

        }

        private void buttonKlient_Click(object sender, EventArgs e)
        {


                editLog("mamy aż: " + Server.clientSockets.Count + " klientów");
               // listBox1.Items.Add(Server_Class.clientList.Count);

            
            
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


        private int editLog(object message)
        {
                listBox1.Invoke(new MethodInvoker( delegate {listBox1.Items.Add(message);}));
            
            
            
            return 0;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            aleph.StopServer();
            button1.Enabled = true;
            buttonKlient.Enabled = false;
            numericUpDown1.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void window_server_FormClosing(object sender, FormClosingEventArgs e)
        {
            aleph.StopServer();
        }

        




       
    }
}

