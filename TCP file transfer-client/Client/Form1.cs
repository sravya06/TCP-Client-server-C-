﻿using SimpleTCP;
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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();

            client.StringEncoder = Encoding.UTF8;
            
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            textStatus.Invoke((MethodInvoker)delegate ()
            {
                textStatus.Text += e.MessageString;
                e.ReplyLine(string.Format(e.MessageString));
            });
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            client.Connect(textHost.Text, Convert.ToInt32(textPort.Text));
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txtmessage.Text, TimeSpan.FromSeconds(3));
        }
    }
}
