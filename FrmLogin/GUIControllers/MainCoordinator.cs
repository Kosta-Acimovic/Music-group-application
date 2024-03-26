using Commonn.Communication;
using Commonn.Domain;
using FrmLogin.UserControlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.GUIControllers
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;
        private Timer timer;
        private Timer odjava;
        private Timer kraj;
        private UCDefaultMain main;
        private int vreme = 0;
        private int vremeDoOdjave = 15;
        private int vremeDoKraja = 0;
        public static MainCoordinator Instance

        {
            get
            {
                if (instance == null) instance = new MainCoordinator();
                return instance;
            }
        }
        private MainCoordinator()
        {
            izvodjacGUIController = new IzvodjacGUIController();
            muzickaGrupaGUIController = new MuzickaGrupaGUIController();
            nastupGUIController = new NastupGUIController();
            timer = new Timer();
            odjava = new Timer();
        }

        private FrmMain frmMain;
        private IzvodjacGUIController izvodjacGUIController;
        private NastupGUIController nastupGUIController;
        private MuzickaGrupaGUIController muzickaGrupaGUIController;
        internal void ShowFrmMain(Korisnik korisnik)
        {
            frmMain = new FrmMain(korisnik);
            frmMain.AutoSize = true;
            ShowDefault();
            frmMain.ShowDialog();
        }
        internal void ShowIzvodjacPanel(UCMode mode, Izvodjac izvodjac = null)
        {
            frmMain.ChangePanel(izvodjacGUIController.CreateUCIzvodjac(mode, izvodjac));
        }
        internal void ShowSearchIzvodjaca()
        {
            frmMain.Size = new System.Drawing.Size(637, 412);
            frmMain.ChangePanel(izvodjacGUIController.CreateUCIzmeniIzvodjaca());
        }

        internal void ShowMuzickaGrupaPanel(UCMode mode, MuzickaGrupa grupa = null)
        {
            frmMain.Size = new System.Drawing.Size(637, 412);
            frmMain.ChangePanel(muzickaGrupaGUIController.CreateUCMuzickaGrupa(mode, grupa));
        }

        internal void ShowSearchMuzickeGrupe()
        {
            frmMain.Size = new System.Drawing.Size(637, 412);
            frmMain.ChangePanel(muzickaGrupaGUIController.CreateUCIzmeniMuzickuGrupu());
        }

        internal void ShowNastupPanel(UCMode mode = UCMode.Add, Nastup nastup = null)
        {
            frmMain.ChangePanel(nastupGUIController.CreateUCNastupa(mode, nastup));
        }
        internal void ShowSearchNastupa()
        {
            frmMain.Size = new System.Drawing.Size(637, 412);
            frmMain.ChangePanel(nastupGUIController.CreateUCIzmeniNastup());
        }


        internal void ShowDefault()
        {
            main = new UCDefaultMain();
            frmMain.Size = new System.Drawing.Size(637, 412);
            main.lblVreme.Text = DateTime.Now.ToString("HH:mm:ss");
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += generate;
            odjava.Enabled = true;
            odjava.Interval = 300000;
            odjava.Tick += generatee;
            main.btnZakazi.Click += (s, e) => ShowNastupPanel();
            frmMain.ChangePanel(main);
        }

        private void generate(object sender, EventArgs e)
        {
            main.lblVreme.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void generatee(object sender, EventArgs e)
        {
            vreme++;
            if (vreme == 6)
            {
                kraj = new Timer();
                kraj.Start();
                kraj.Interval = 1000;
                kraj.Tick += generateee;
                DialogResult odgovor = MessageBox.Show("Prošlo je pola sata od vašeg logovanja, savetujemo Vam da odmorite malo\n" +
                    "Da li želite da nastavite", "Savet", MessageBoxButtons.YesNoCancel);
                if (odgovor==DialogResult.No)
                {
                    timer.Enabled = false;
                    odjava.Enabled= false;
                    kraj.Enabled=false;
                    frmMain.btnLogout.PerformClick();
                }
                else if (odgovor==DialogResult.Yes)
                {
                    kraj.Stop();
                    kraj.Dispose();
                    vreme = 0;
                    vremeDoKraja = 0;
                    vremeDoOdjave = 15;
                    main.lblVremeDoKraja.Text = "";
                }else if(odgovor==DialogResult.Cancel)
                {
                    timer.Enabled = false;
                    odjava.Enabled = false;
                    kraj.Enabled = false;
                    frmMain.btnLogout.PerformClick();
                    
                }
            }
        }

        private void generateee(object sender, EventArgs e)
        {
            vremeDoKraja++;
            vremeDoOdjave--;
            main.lblVremeDoKraja.Text = $"Vreme do\n" +
                $"odjave je\n" +
                $"{vremeDoOdjave}";
            if(vremeDoKraja == 15)
            {
                SendKeys.Send("{ESC}");
                frmMain.btnLogout.PerformClick();
            }
        }
    }
}
