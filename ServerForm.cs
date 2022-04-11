using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP
{
    public partial class ServerForm : Form
    {
        UdpClient server;
        IPEndPoint endPoint;

        public ServerForm()
        {
            InitializeComponent();
        }

       private void btnStartServer_Click(object sender, EventArgs e)
        {
            server = new UdpClient(int.Parse(txtServerPort.Text));
            endPoint = new IPEndPoint(IPAddress.Any, 0);

	WriteLog("Server Started….");

	Thread thr = new Thread (new ThreadStart (ServerStart));
	
	btnStart.Enabled = false;
        }

private void ServerStart()
        {
            // Keep Server Listening

            while (true)
            {
	    // Receive
                byte[] buffer = server.Receive(ref endPoint);

	    // portnumber.hostaname.msg
                string[] msg = Encoding.Unicode.GetString(buffer).Split('.');
	  
	    WriteLog("Client at Port : " +msg[0]);
	    WriteLog("at host : " + msg[1]);
	    WriteLog("need : "  + msg[2]);

	    // Send
	    buffer = Encoding.Unicode.GetBytes(DateTime.Now.ToString());

	    server.Send(buffer, buffer.Length, msg[1], int.Parse(msg[0]));
          
            }
        }


	
private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                txtLog.Text += string.Format("Sever Responed : {0}.{1}", msg, Environment.NewLine);
            });

            this.BeginInvoke(invoker);
        }

       private void btnNewClient_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
        }


     }
}
