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

    }
}

