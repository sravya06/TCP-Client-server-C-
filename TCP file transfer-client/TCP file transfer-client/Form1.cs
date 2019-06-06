using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPIPDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer
            {
                Delimiter = 0x13,
                StringEncoder = Encoding.UTF8
            };
            server.DataReceived += Server_DataReceived;
        }
        private void Server_DataReceived(object sender,SimpleTCP.Message e)
        {
            textStatus.Invoke((MethodInvoker)delegate ()
           {
                textStatus.Text += e.MessageString;
                e.ReplyLine(string.Format(e.MessageString));
            });

        }



        private void Btnstart_Click(object sender, EventArgs e)
        {
            textStatus.Text += "Server Starting..";
            System.Net.IPAddress ip =  System.Net.IPAddress.Parse(textHost.Text); 
            server.Start(ip, Convert.ToInt32(textPort.Text));
        }

        private void Btnstop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }
    }
}
