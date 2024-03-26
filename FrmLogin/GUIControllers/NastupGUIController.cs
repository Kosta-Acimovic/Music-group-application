using Commonn.Communication;
using Commonn.Domain;
using FrmLogin.UserControlls;
using FrmLogin.UserControlls.UCIzvodjac;
using FrmLogin.UserControlls.UCMuzickaGrupa;
using FrmLogin.UserControlls.UCNastup;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmLogin.GUIControllers
{
    internal class NastupGUIController
    {
        private UCSingleNastup uCnastup;
        private UCIzmeniNastup uCIzmeniNastup;
        private int cena = 0;
        private int rbt = 0;
        private DateTime datum;
        private List<Nastup> nastupi = new List<Nastup>();
        internal Control CreateUCNastupa(UCMode mode, Nastup nastup)
        {
            uCnastup = new UCSingleNastup();
            uCnastup.btnDodajNastup.Click += DodajNastupDgv;
            PrepareFormNastup(mode, nastup);
            if (mode == UCMode.Add)
            {
                nastupi.Clear();
                uCnastup.txtDatumOdrzavanja.ResetText();
                uCnastup.btnSacuvaj.Click += DodajNastup;
                uCnastup.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
            }
            else if (mode == UCMode.Update)
            {
                uCnastup.btnSacuvaj.Click += SacuvajIzmeneNastupa;
                uCnastup.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowSearchNastupa();
            }
            else if (mode == UCMode.Show)
            {
                uCnastup.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowSearchNastupa();
            }
            return uCnastup;
        }

        internal void PrepareFormNastup(UCMode mode, Nastup nastup)
        {
            uCnastup.cbGrupa.DataSource = Communication.Instance.PretraziSveMuzickeGrupe();
            uCnastup.cbKoncert.DataSource = Communication.Instance.PretraziSveKoncerte();
            if (mode == UCMode.Add)
            {
                uCnastup.cbKoncert.SelectedIndex = -1;
                uCnastup.cbGrupa.SelectedIndex = -1;
            }
            else if (mode == UCMode.Update)
            {
                uCnastup.txtNaslov.Text = "Izmeni Nastup";
                uCnastup.txtDatumOdrzavanja.Text = nastup.DatumOdrzavanja.ToString("yyyy-MM-dd");
                datum = nastup.DatumOdrzavanja;
                uCnastup.txtCenaUlaznice.Text = nastup.CenaUlaznice.ToString();
                cena = nastup.CenaUlaznice;
                uCnastup.txtRBTacke.Text = nastup.RBTacke.ToString();
                rbt = nastup.RBTacke;
                uCnastup.btnDodajNastup.Enabled = false;
                uCnastup.btnDodajNastup.BackColor = Color.LightBlue;
                uCnastup.dgvNastupi.Visible= false;
                uCnastup.cbGrupa.SelectedItem = nastup.MuzickaGrupa;
                uCnastup.cbGrupa.Text = nastup.MuzickaGrupa.Naziv;
                uCnastup.cbKoncert.SelectedItem = nastup.Koncert;
                uCnastup.cbKoncert.Text = nastup.Koncert.Adresa;

                uCnastup.btnSacuvaj.Text = "Izmeni nastup";

                uCnastup.cbGrupa.Enabled = false;
                uCnastup.cbKoncert.Enabled = false;
                uCnastup.lblIdNastupa.Text = nastup.IdNastupa.ToString();
            }
            else if (mode == UCMode.Show)
            {
                uCnastup.txtRBTacke.Enabled = false;
                uCnastup.txtNaslov.Text = "Prikaži Nastup";
                uCnastup.txtDatumOdrzavanja.Text = nastup.DatumOdrzavanja.ToString("yyyy-MM-dd");
                uCnastup.txtCenaUlaznice.Text = nastup.CenaUlaznice.ToString();
                uCnastup.txtRBTacke.Text = nastup.RBTacke.ToString();
                uCnastup.dgvNastupi.Visible = false;
                uCnastup.btnSacuvaj.Enabled = false;
                uCnastup.btnSacuvaj.BackColor = Color.LightBlue;
                uCnastup.btnDodajNastup.Enabled = false;
                uCnastup.btnDodajNastup.BackColor = Color.LightBlue;
                uCnastup.cbGrupa.SelectedItem = nastup.MuzickaGrupa;
                uCnastup.cbGrupa.Text = nastup.MuzickaGrupa.Naziv;
                uCnastup.cbKoncert.SelectedItem = nastup.Koncert;
                uCnastup.cbKoncert.Text = nastup.Koncert.Adresa;

                uCnastup.txtCenaUlaznice.Enabled = false;
                uCnastup.txtDatumOdrzavanja.Enabled = false;
                uCnastup.btnSacuvaj.Enabled = false;
                uCnastup.cbGrupa.Enabled = false;
                uCnastup.cbKoncert.Enabled = false;
            }
        }
        private void DodajNastup(object sender, EventArgs e)
        {
            if (nastupi.Count == 0)
            {
                if (!ValidationDodajNastup()) return;
            }
            else
            {
            Response response = Communication.Instance.DodajNastup(nastupi);
            MessageBox.Show(response.Message);
            nastupi.Clear();
            uCnastup.btnBack.PerformClick();

            }
        }
        private void DodajNastupDgv(object sender, EventArgs e)
        {
            if (!ValidationDodajNastup()) return;
            PoluResetForme();
            ispiLbl();
            Nastup nastup = new Nastup()
            {
                DatumOdrzavanja = DateTime.Parse(uCnastup.txtDatumOdrzavanja.Text),
                CenaUlaznice = int.Parse(uCnastup.txtCenaUlaznice.Text.Trim().Replace(" ", "")),
                RBTacke=int.Parse(uCnastup.txtRBTacke.Text.Trim().Replace(" ","")),
                MuzickaGrupa = (MuzickaGrupa)uCnastup.cbGrupa.SelectedItem,
                Koncert = (Koncert)uCnastup.cbKoncert.SelectedItem,
            };

            string poruka = $"Datum održavanja nastupa je(dan-mesec-godina): {nastup.DatumOdrzavanja.ToString("dd-MM-yyyy")}\n" +
                $"Cena ulaznice za nastup je: {nastup.CenaUlaznice}\n" +
                $"Redni broj tačke za nastup je: {nastup.RBTacke}\n" +
                $"Naziv muzičke grupe koja nastupa je: {nastup.MuzickaGrupa.Naziv}\n" +
                $"Adresa održavanja koncerta je: {nastup.Koncert.Adresa}\n" +
                $"Grad održavanja je: {nastup.Koncert.Grad}\n" +
                $"Tip nastupa je: {nastup.Koncert.TipKoncerta}\n";
            DialogResult odgovor = MessageBox.Show($"Da li ste sigurni da želite da dodate ovu muzičku grupu\n{poruka}", "Upit", MessageBoxButtons.YesNo);
            if (odgovor == DialogResult.Yes)
            {
                nastupi.Add(nastup);
                uCnastup.dgvNastupi.DataSource = "";
                uCnastup.dgvNastupi.DataSource = nastupi;                
                ResetForm();
            }
            else return;
        }
        private bool ValidationDodajNastup()
        {
            List<string> errors = new List<string>();
            List<Control> controls = new List<Control>();

            if (uCnastup.cbGrupa.SelectedIndex < 0)
            {
                errors.Add("Grupa");
                controls.Add(uCnastup.cbGrupa);
            }
            if (uCnastup.cbKoncert.SelectedIndex < 0)
            {
                errors.Add("Koncert");
                controls.Add(uCnastup.cbKoncert);
            }
            if (string.IsNullOrEmpty(uCnastup.txtCenaUlaznice.Text) || !int.TryParse(uCnastup.txtCenaUlaznice.Text, out int cena) || cena <= 0)
            {
                errors.Add("Cena");
                controls.Add(uCnastup.txtCenaUlaznice);
            }
            if (string.IsNullOrEmpty(uCnastup.txtRBTacke.Text) || !int.TryParse(uCnastup.txtRBTacke.Text, out int redosled) || redosled <= 0)
            {
                errors.Add("Redni");
                controls.Add(uCnastup.txtRBTacke);
            }

            if (errors.Count > 0)
            {
                ValidationError(errors, controls);
                ispiLbl();
                return false;
            }
            else return true;
        }
        private void ValidationError(List<string> errors, List<Control> controls)
        {
            uCnastup.txtCenaUlaznice.BackColor = Color.White;
            uCnastup.txtDatumOdrzavanja.BackColor = Color.White;
            uCnastup.cbGrupa.BackColor = Color.White;
            uCnastup.cbKoncert.BackColor = Color.White;
            uCnastup.txtRBTacke.BackColor = Color.White;

            if (errors.Count() == 0) return;
            for (int i = 0; i < controls.Count(); i++)
            {
                controls[i].BackColor = Color.LightSalmon;
            }
        }
        internal void PoluResetForme()
        {
            uCnastup.txtCenaUlaznice.BackColor = Color.White;
            uCnastup.txtDatumOdrzavanja.BackColor = Color.White;
            uCnastup.cbGrupa.BackColor = Color.White;
            uCnastup.cbKoncert.BackColor = Color.White;
            uCnastup.txtRBTacke.BackColor = Color.White;
        }
        internal void ResetForm()
        {
            uCnastup.txtCenaUlaznice.BackColor = Color.White;
            uCnastup.txtDatumOdrzavanja.BackColor = Color.White;
            uCnastup.cbGrupa.BackColor = Color.White;
            uCnastup.cbKoncert.BackColor = Color.White;
            uCnastup.txtRBTacke.BackColor = Color.White;

            uCnastup.txtRBTacke.Text = string.Empty;
            uCnastup.txtCenaUlaznice.Text = string.Empty;
            uCnastup.cbGrupa.SelectedIndex = -1;
            uCnastup.cbKoncert.SelectedIndex = -1;
            uCnastup.txtDatumOdrzavanja.ResetText();
        }
        private void SacuvajIzmeneNastupa(object sender, EventArgs e)
        {
            if (!ValidationDodajNastup()) return;
            PoluResetForme();
            ispiLbl();
            Nastup nastup = new Nastup()
            {
                IdNastupa = int.Parse(uCnastup.lblIdNastupa.Text.ToString()),
                DatumOdrzavanja = DateTime.Parse(uCnastup.txtDatumOdrzavanja.Text),
                CenaUlaznice = int.Parse(uCnastup.txtCenaUlaznice.Text.Trim().Replace(" ", "")),
                RBTacke = int.Parse(uCnastup.txtRBTacke.Text.Trim()),
                MuzickaGrupa = (MuzickaGrupa)uCnastup.cbGrupa.SelectedItem,
                Koncert = (Koncert)uCnastup.cbKoncert.SelectedItem,
            };
            string poruka = ProveriPoruku(nastup);

            DialogResult odgovor = MessageBox.Show($"Da li ste sigurni da želite da izmenite ovaj nastup\n{poruka}", "Upit", MessageBoxButtons.YesNo);
            if (odgovor == DialogResult.Yes)
            {
                Response res = Communication.Instance.IzmeniNastup(nastup);
                MessageBox.Show(res.Message);
                uCnastup.btnBack.PerformClick();
            }
            else return;
        }

        private string ProveriPoruku(Nastup n)
        {
            int promene = 0;
            string poruka = $"Stara vrednost\t  \tNova vrednost\n";
            if (n.DatumOdrzavanja != datum)
            {
                poruka += $"{datum.ToString("dd-MM-yyyy")}\t=>\t{n.DatumOdrzavanja.ToString("dd-MM-yyyy")}\n";
                promene++;
            }
            if (n.CenaUlaznice != cena)
            {
                poruka += $"{cena}\t\t=>\t{n.CenaUlaznice}\n"; promene++;
            }
            if (n.RBTacke != rbt)
            {
                poruka += $"{rbt}\t\t=>\t{n.RBTacke}\n";
                promene++;
            }
            if (promene > 0)
            {

            }
            else
            {
                poruka = "Jer niste napravili ni jednu promenu\n";
            }
            return poruka;
        }
        internal Control CreateUCIzmeniNastup()
        {
            uCIzmeniNastup = new UCIzmeniNastup();
            uCIzmeniNastup.Load += PretraziSveNastupe;
            uCIzmeniNastup.btnSearch.Click += PretraziPoDatumuNastupa;
            uCIzmeniNastup.btnShow.Click += PrikaziTrazeniNastup;
            uCIzmeniNastup.btnEdit.Click += PrikaziFormuZaIzmenu;
            uCIzmeniNastup.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
            return uCIzmeniNastup;
        }
        private void PrikaziTrazeniNastup(object sender, EventArgs e)
        {

            if (uCIzmeniNastup.dgvNastup.SelectedCells.Count == 1 || uCIzmeniNastup.dgvNastup.SelectedRows.Count == 1)
            {
                Nastup nastup = (Nastup)uCIzmeniNastup.dgvNastup.SelectedRows[0].DataBoundItem;

                Nastup n = Communication.Instance.NadjiNastupPoId(nastup.IdNastupa);
                MainCoordinator.Instance.ShowNastupPanel(UCMode.Show, nastup);
            }
            else MessageBox.Show("Prvo izaberite red/ćeliju izvođača iz tabele kojeg želite da promenite");
        }
        private void PrikaziFormuZaIzmenu(object sender, EventArgs e)
        {

            if (uCIzmeniNastup.dgvNastup.SelectedCells.Count == 1 || uCIzmeniNastup.dgvNastup.SelectedRows.Count == 1)
            {
                Nastup nastup = (Nastup)uCIzmeniNastup.dgvNastup.SelectedRows[0].DataBoundItem;

                Nastup n = Communication.Instance.NadjiNastupPoId(nastup.IdNastupa);
                MainCoordinator.Instance.ShowNastupPanel(UCMode.Update, nastup);
            }
            else MessageBox.Show("Prvo izaberite red/ćeliju nastupa iz tabele kojeg želite da promenite");
        }
        private void PretraziSveNastupe(object sender, EventArgs e)
        {
            List<Nastup> nastupi = Communication.Instance.PretraziSveNastupe();
            prepareDgv(nastupi);
        }

        private void prepareDgv(List<Nastup> nastupi)
        {
            if (nastupi != null && nastupi.Count > 0)
            {
                foreach (Nastup n in nastupi)
                {
                    uCIzmeniNastup.dgvNastup.DataSource = nastupi;
                }
            }
            else MessageBox.Show("Sistem ne može da nađe nastupe","Greška");
        }
        #region datum provera
        private void PretraziPoDatumuNastupa(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(uCIzmeniNastup.txtSearch.Text))
            {
                string c = uCIzmeniNastup.txtSearch.Text.ToLower();
                
                if (c == "1" || c == "01" || c == "jan" || c == "januar" || c == "january"||c=="j"||c=="i")
                {
                    c = "01";
                }
                else if (c == "2" || c == "02" || c == "feb" || c == "februar" || c == "february"||c=="f" || c == "ii")
                {
                    c = "02";
                }
                else if (c == "3" || c == "03" || c == "mar" || c == "mart" || c == "march"||c=="m" || c == "iii")
                {
                    c = "03";
                }
                else if (c == "4" || c == "04" || c == "apr" || c == "april"||c=="a" || c == "iv")
                {
                    c = "04";
                }
                else if (c == "5" || c == "05" || c == "maj" || c == "may"||c=="mm" || c == "v")
                {
                    c = "05";
                }
                else if (c == "6" || c == "06" || c == "jun" || c == "june"||c=="jj" || c == "vi")
                {
                    c = "06";
                }
                else if (c == "7" || c == "07" || c == "jul" || c == "july"||c=="jjj" || c == "vii")
                {
                    c = "07";
                }
                else if (c == "8" || c == "08" || c == "aug" || c == "avgust" || c == "august"||c=="aa" || c == "viii")
                {
                    c = "08";
                }
                else if (c == "9" || c == "09" || c == "sep" || c == "septembar" || c == "september"||c=="s" || c == "ix")
                {
                    c = "09";
                }
                else if (c == "10" || c == "oct" || c == "oktobar" || c == "october"||c=="o" || c == "x")
                {
                    c = "10";
                }
                else if (c == "11" || c == "nov" || c == "novembar" || c == "november"||c=="n" || c == "xi")
                {
                    c = "11";
                }
                else if (c == "12" || c == "dec" || c == "decembar" || c == "december"||c=="d" || c == "xii")
                {
                    c = "12";
                }


                #endregion
                List<Nastup> nastupi = Communication.Instance.PretraziPoDatumuNastupa(c);
                if (nastupi == null || nastupi.Count() == 0)
                {
                    uCIzmeniNastup.lblSuport.Text = "Idealna pretraga je u formatu: slova ili brojevi kao mesec(mm)";
                    MessageBox.Show("Sistem nije uspeo da nađe nastupe po zadatoj vrednosti!", "Greška");
                    return;
                }
                else
                {
                    prepareDgv(nastupi);
                    uCIzmeniNastup.lblSuport.Text = "";
                }
            }
            else
            {
                List<Nastup> nastupi = Communication.Instance.PretraziSveNastupe();
                if (nastupi == null || nastupi.Count() == 0)
                {
                    MessageBox.Show("Sistem nije uspeo da pronađe nastupe", "Greška");
                    return;
                }
                else prepareDgv(nastupi);
            }

        }
        private void ispiLbl()
        {
            if (uCnastup.txtCenaUlaznice.BackColor == Color.White) uCnastup.lblCenaGreska.Text = "";
            else uCnastup.lblCenaGreska.Text = "Cena ulaznice mora biti pozitivna i predstavljati broj!";
            if (uCnastup.cbGrupa.BackColor == Color.White) uCnastup.lblNazivGreska.Text = "";
            else uCnastup.lblNazivGreska.Text = "Izaberite grupu koja nastupa na nastupu!";
            if (uCnastup.txtRBTacke.BackColor == Color.White) uCnastup.lblRedniBrTacke.Text = "";
            else uCnastup.lblRedniBrTacke.Text = "Redni broj tačke mora biti pozitivan i predstavljati broj!";
            if (uCnastup.cbKoncert.BackColor == Color.White) uCnastup.lblAdresaGreska.Text = "";
            else uCnastup.lblAdresaGreska.Text = "Izaberite koncert na kom se održava nastup";
        }
    }
}
