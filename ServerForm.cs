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
