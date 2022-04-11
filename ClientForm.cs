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
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Send Message to Server 

            int serverPort = int.Parse(txtServerPort.Text);
            int clientPort = int.Parse(txtClientPort.Text);
            string hostName = txtHostName.Text;
            client = new UdpClient(clientPort);

	// portnumber.hostname.msg
	string msg = clientPort + “.” +hostName + “.” + txtMsg.Text;
	Byte[] buffer = Encoding.Unicode.GetBytes(msg);




        }
    }
}

