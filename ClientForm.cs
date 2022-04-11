using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP
{
    public partial class ClientForm : Form
    {
        UdpClient client;
        IPEndPoint endPoint;

        public ClientForm()
        {
            InitializeComponent();        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            // Send Message to Server 

            int serverPort = int.Parse(txtServerPort.Text);
            int clientPort = int.Parse(txtClientPort.Text);
            string hostName = txtHostName.Text;

	client = new UdpClient(clientPort);

	// portnumber.hostname.msg
	string msg = clientPort + "." +hostName + "." + txtMsg.Text;
	Byte[] buffer = Encoding.Unicode.GetBytes(msg);
	
	// Send Msg

            client.Send(buffer, buffer.Length, hostName, serverPort);

            // Receive Response from Server

            endPoint = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref endPoint);

            msg = Encoding.Unicode.GetString(buffer);

            txtLog.AppendText("Server Said: " + msg +Enviroment.NewLine);           
            }

   private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                txtLog.Text += string.Format("Sever Responed : {0}.{1}", msg, Environment.NewLine);                
            });

            this.BeginInvoke(invoker);
        }

	
    }
}
