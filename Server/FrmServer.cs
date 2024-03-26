using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {

        Server server;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server = new Server();
            server.Start();

            lblPokrenut.ForeColor = Color.Lime;
            lblPokrenut.Text = "Server je pokrenut...";
            btnPokreni.Enabled = false;
            btnStopiraj.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Controller.Instance.ulogovani.Clear();
            server.Stop();

            lblPokrenut.Text = "Server nije pokrenut...";
            btnStopiraj.Enabled = false;
            btnPokreni.Enabled = true;
            lblPokrenut.ForeColor = Color.Crimson;
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
