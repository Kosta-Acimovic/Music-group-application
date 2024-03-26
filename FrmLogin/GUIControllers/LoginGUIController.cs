using Commonn.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.GUIControllers
{
    internal class LoginGUIController
    {

        private static LoginGUIController instance;
        public static LoginGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGUIController();
                }
                return instance;
            }
        }
        private LoginGUIController()
        {
        }
        private FrmLogin frmLogin;
        internal void ShowFrmLogin()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FrmLogin();
            frmLogin.btnLogin.Click += (s, e) => Login();
            frmLogin.AutoSize = true;
            Application.Run(frmLogin);
        }

        internal void Login()
        {
            if (!ValidateLogin()) return;
            try
            {
                Communication.Instance.Connect();
                Korisnik korisnik = Communication.Instance.Login(frmLogin.txtUsername.Text, frmLogin.txtPassword.Text);
                if (korisnik == null)
                {
                    MessageBox.Show("Ne postoji korisnik sa tim username-om i password-om!");
                }
                else if(korisnik.Username == "a")
                {
                    MessageBox.Show("Korisnik je već ulogovan");                   
                }else
                {
                    frmLogin.Hide();                    
                    MainCoordinator.Instance.ShowFrmMain(korisnik);
                    frmLogin.Dispose();
                    Communication.Instance.Close();
                }
        }
            catch (Exception)
            {
                MessageBox.Show("Server je ugašen!");
                frmLogin?.Dispose();
                //Environment.Exit(0);
                return;
            }

}

        private bool ValidateLogin()
        {
            frmLogin.txtUsername.BackColor = Color.White;
            frmLogin.lblPrvaGreska.Text = "";
            frmLogin.txtPassword.BackColor = Color.White;
            frmLogin.lblDrugaGreska.Text = "";

            string message = "";
            if (string.IsNullOrEmpty(frmLogin.txtUsername.Text) || frmLogin.txtUsername.Text.Length < 4)
            {
                message += "1\n";
                frmLogin.txtUsername.BackColor = Color.Pink;
                frmLogin.lblPrvaGreska.Text = "Username mora imati bar 4 karaktera";
                
            }
            if (string.IsNullOrEmpty(frmLogin.txtPassword.Text) || frmLogin.txtPassword.Text.Length < 4)
            {
                message += "2\n";
                frmLogin.txtPassword.BackColor = Color.Pink;
                frmLogin.lblDrugaGreska.Text = "Password mora imati bar 4 karaktera";
            }
            if (message != "")
            {
                return false;
            }
            return true;
        }
    }
}
