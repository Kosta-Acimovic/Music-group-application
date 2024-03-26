using Commonn.Domain;
using FrmLogin.GUIControllers;
using FrmLogin.UserControlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class FrmMain : Form
    {
        private readonly string ime;
        private readonly string prezime;
        private readonly string ulogovan;
        public FrmMain(Korisnik k)
        {
            InitializeComponent();
            if (!(k == null))
            {
            ime = k.FirstName;
            prezime = k.LastName;
            ulogovan = k.Username+k.Password;
            lblKorisnik.Text = ime + " " + prezime;
            }

            dodajIzvodjacaItem.Click += (s, e) => MainCoordinator.Instance.ShowIzvodjacPanel(UCMode.Add);
            izmeniIzvodjacaItem.Click += (s, e) => MainCoordinator.Instance.ShowSearchIzvodjaca();

            dodajMuzickuGrupuItem.Click += (s, e) => MainCoordinator.Instance.ShowMuzickaGrupaPanel(UCMode.Add);
            pretraziMuzickuGrupuItem.Click += (s, e) => MainCoordinator.Instance.ShowSearchMuzickeGrupe();

            dodajNastupItem.Click += (s, e) => MainCoordinator.Instance.ShowNastupPanel(UCMode.Add);
            pretraziNastupItem.Click += (s, e) => MainCoordinator.Instance.ShowSearchNastupa();

        }

        public void ChangePanel(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
            pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Communication.Instance.Logout(ulogovan);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Communication.Instance.Logout(ulogovan);
            Environment.Exit(0);
        }

    }
}
