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

       
        private static Control alephControl = new Control(); //inicjacja klasy kontrol
        private Server aleph = new Server(alephControl); // inicjacja klasy serwer
        public delegate int messageTolog(string message);
        public static messageTolog  Log;
        private string path_lib = null;
        public delegate void refreshData();
        public static refreshData Grid;
        private EditLibrary WindowEditLibrary = new EditLibrary(alephControl);
       
        public window_server()
        {
           
            InitializeComponent();
           Log= new messageTolog(editLog);
            Grid = new refreshData(refreshGrid);
           
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
            newBook.Enabled = false;
            try
            {
                WindowEditLibrary.Close();
            }
            catch
            { }

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
            newBook.Enabled = true;
        }

        private void window_server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(path_lib != null) alephControl.SaveLibrary(path_lib);
            aleph.StopServer();
        }


        private void LoadLibrary(object sender, EventArgs e)
        {
            OpenFileDialog OpenLibrary = new OpenFileDialog();
            OpenLibrary.Filter = "Plik XML|*.xml";
            OpenLibrary.Title = "Wybierz biblioteke";

            if (OpenLibrary.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Add("otwieramy plik: " + OpenLibrary.FileName);
                alephControl.ReadLibrary(OpenLibrary.FileName);
                listBox1.Items.Add("Wczytano: " + Control.info.ListBook.Count);
                dataGridView1.DataSource = Control.info.ListBook;
                button1.Enabled = true;
                loadBooks.Enabled = false;
                newBook.Enabled = true;
                path_lib = OpenLibrary.FileName;
                //dataGridView1.Update();

            }
            else
            {
                listBox1.Items.Add("błąd otwarcia pliku XML");
            }

        }

        private void refreshGrid()
        {
            dataGridView1.Invoke(new MethodInvoker(delegate
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Control.info.ListBook;
                dataGridView1.Refresh();
            }));
        }

        private void newBook_Click(object sender, EventArgs e)
        {
            try
            {
                WindowEditLibrary.Show();
            }
            catch
            {
                WindowEditLibrary = new EditLibrary(alephControl);
                WindowEditLibrary.Show();
            }
         }

      
      
       

        

       
    }
}

