using Commonn.Communication;
using Commonn.Domain;
using FrmLogin.UserControlls;
using FrmLogin.UserControlls.UCIzvodjac;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Control = System.Windows.Forms.Control;

namespace FrmLogin.GUIControllers
{
    internal class IzvodjacGUIController
    {
        private UCSingleIzvodjac uCIzvodjac;
        private UCIzmeniIzvodjaca uCIzmenaIzvodjaca;
        private string prezime = "";
        private string grupa = "";
        private int broj = 0;
        private List<Izvodjac> izvodjaci = new List<Izvodjac>();
        internal Control CreateUCIzvodjac(UCMode mode, Izvodjac izvodjac)
        {
            uCIzvodjac = new UCSingleIzvodjac();
            uCIzvodjac.btnDodajIzvodjaca.Click += DodajIzvodjacaDgv;
            PrepareFormIzvodjac(mode, izvodjac);
            if (mode == UCMode.Add)
            {
                izvodjaci.Clear();
                uCIzvodjac.btnSacuvaj.Click += DodajIzvodjaca;
                uCIzvodjac.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
            }
            else if (mode == UCMode.Update)
            {
                uCIzvodjac.btnSacuvaj.Click += SacuvajIzmeneIzvodjaca;
                uCIzvodjac.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowSearchIzvodjaca();
            }
            else if (mode == UCMode.Show)
            {
                uCIzvodjac.btnDelete.Click += IzbrisiIzabranogIzvodjaca;
                uCIzvodjac.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowSearchIzvodjaca();
            }
            return uCIzvodjac; 
        }
        private void IzbrisiIzabranogIzvodjaca(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show($"Da li ste sigurni da želite da izbrišete izvođača {uCIzvodjac.txtIme.Text} {uCIzvodjac.txtPrezime.Text}","Upit",MessageBoxButtons.YesNo);
            if (odgovor == DialogResult.Yes)
            {
            Izvodjac izvodjac = new Izvodjac();
            izvodjac.IzvodjacId = int.Parse(uCIzvodjac.lblIdIzvodjaca.Text);
            Response res = Communication.Instance.IzbrisiIzvodjaca(izvodjac);
            MessageBox.Show(res.Message);
            uCIzvodjac.btnBack.PerformClick();
            }
            else
            {
                return;
            }

        }
        internal Control CreateUCIzmeniIzvodjaca()
        {
            uCIzmenaIzvodjaca = new UCIzmeniIzvodjaca();
            uCIzmenaIzvodjaca.Load += PretraziSveIzvodjace;
            uCIzmenaIzvodjaca.btnSearch.Click += PretraziPoImenuIzvodjace;
            uCIzmenaIzvodjaca.btnShow.Click += PrikaziTrazenogIzvodjaca;
            uCIzmenaIzvodjaca.btnEdit.Click += PrikaziFormuZaIzmenu;
            uCIzmenaIzvodjaca.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
            return uCIzmenaIzvodjaca;
        }
        private void PrikaziTrazenogIzvodjaca(object sender, EventArgs e)
        {

            if (uCIzmenaIzvodjaca.dgvIzvodjac.SelectedCells.Count == 1 || uCIzmenaIzvodjaca.dgvIzvodjac.SelectedRows.Count == 1)
            {
                Izvodjac izvodjac = (Izvodjac)uCIzmenaIzvodjaca.dgvIzvodjac.SelectedRows[0].DataBoundItem;

                Izvodjac i = Communication.Instance.NadjiIzvodjacaPoId(izvodjac.IzvodjacId);
                MainCoordinator.Instance.ShowIzvodjacPanel(UCMode.Show, i);
            }
            else MessageBox.Show("Prvo izaberite red/ćeliju izvođača iz tabele kojeg želite da promenite");
        }
        private void PretraziSveIzvodjace(object sender, EventArgs e)
        {
            List<Izvodjac> izvodjaci = Communication.Instance.PretraziSveIzvodjace();
            prepareDgv(izvodjaci);
        }
        private void PretraziPoImenuIzvodjace(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(uCIzmenaIzvodjaca.txtSearch.Text))
            {
                List<Izvodjac> izvodjaci = Communication.Instance.PretraziPoImenuIzvodjace(uCIzmenaIzvodjaca.txtSearch.Text);
                if (izvodjaci == null || izvodjaci.Count() == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe izvođače po zadatoj vrednosti!","Greška");
                    return;
                }
                else prepareDgv(izvodjaci);
            }
            else
            {
                List<Izvodjac> izvodjaci = Communication.Instance.PretraziSveIzvodjace();
                if (izvodjaci == null || izvodjaci.Count() == 0)
                {
                    MessageBox.Show("Sistem nije uspeo da pronađe izvođače");
                    return;
                }
                else prepareDgv(izvodjaci);
            }

        }
        private void PrikaziFormuZaIzmenu(object sender, EventArgs e)
         {
            
            if (uCIzmenaIzvodjaca.dgvIzvodjac.SelectedCells.Count == 1 || uCIzmenaIzvodjaca.dgvIzvodjac.SelectedRows.Count==1)
            {
                Izvodjac izvodjac = (Izvodjac)uCIzmenaIzvodjaca.dgvIzvodjac.SelectedRows[0].DataBoundItem; 

                Izvodjac i = Communication.Instance.NadjiIzvodjacaPoId(izvodjac.IzvodjacId);
                MainCoordinator.Instance.ShowIzvodjacPanel(UCMode.Update, i);
            }
            else MessageBox.Show("Prvo izaberite red/ćeliju izvođača iz tabele kojeg želite da promenite");
        }
        internal void PrepareFormIzvodjac(UCMode mode, Izvodjac izvodjac)
        {
            uCIzvodjac.cbGrupa.DataSource = Communication.Instance.PretraziSveMuzickeGrupe();
            if (mode == UCMode.Add)
            {
                uCIzvodjac.txtDatumRodjenja.ResetText();
                uCIzvodjac.cbGrupa.SelectedIndex = -1;
            }
            else if (mode == UCMode.Update)
            {
                uCIzvodjac.txtNaslov.Text = "Izmeni izvođača";
                uCIzvodjac.txtIme.Text = izvodjac.ImeIzvodjaca;              
                uCIzvodjac.txtPrezime.Text = izvodjac.PrezimeIzvodjaca;
                prezime = izvodjac.PrezimeIzvodjaca.ToString();
                uCIzvodjac.txtDatumRodjenja.Text = izvodjac.DatumRodjenja.ToString("yyyy-MM-dd");
                uCIzvodjac.txtNastup.Text = izvodjac.BrojNastupa.ToString();
                broj = izvodjac.BrojNastupa;
                uCIzvodjac.dgvIzvodjaci.Visible = false;
                uCIzvodjac.btnDodajIzvodjaca.Enabled = false;
                uCIzvodjac.btnDodajIzvodjaca.BackColor = Color.LightBlue;

                uCIzvodjac.cbGrupa.SelectedItem = izvodjac.MuzickaGrupa;
                uCIzvodjac.cbGrupa.Text = izvodjac.MuzickaGrupa.Naziv;
                grupa = izvodjac.MuzickaGrupa.Naziv;
                uCIzvodjac.txtIme.Enabled = false;
                uCIzvodjac.txtDatumRodjenja.Enabled= false;

                uCIzvodjac.lblIdIzvodjaca.Text = izvodjac.IzvodjacId.ToString();
            }
            else if (mode == UCMode.Show)
            {
                uCIzvodjac.txtNaslov.Text = "Prikaži izvođača";
                uCIzvodjac.txtIme.Text = izvodjac.ImeIzvodjaca;
                uCIzvodjac.txtPrezime.Text = izvodjac.PrezimeIzvodjaca;
                uCIzvodjac.txtDatumRodjenja.Text = izvodjac.DatumRodjenja.ToString("yyyy-MM-dd");
                uCIzvodjac.txtNastup.Text = izvodjac.BrojNastupa.ToString();
                uCIzvodjac.dgvIzvodjaci.Visible=false;
                uCIzvodjac.btnDodajIzvodjaca.Enabled=false;
                uCIzvodjac.btnDodajIzvodjaca.BackColor = Color.LightBlue;

                uCIzvodjac.btnSacuvaj.Enabled = false;
                uCIzvodjac.btnSacuvaj.BackColor = Color.LightBlue;

                uCIzvodjac.btnDelete.Enabled = true;
                uCIzvodjac.btnDelete.Visible = true;

                uCIzvodjac.cbGrupa.SelectedItem = izvodjac.MuzickaGrupa;
                uCIzvodjac.cbGrupa.Text = izvodjac.MuzickaGrupa.Naziv;

                uCIzvodjac.txtIme.Enabled = false;
                uCIzvodjac.txtPrezime.Enabled = false;
                uCIzvodjac.txtNastup.Enabled = false;
                uCIzvodjac.txtDatumRodjenja.Enabled = false;
                uCIzvodjac.cbGrupa.Enabled = false;
                uCIzvodjac.btnSacuvaj.Enabled = false;
                uCIzvodjac.lblIdIzvodjaca.Text = izvodjac.IzvodjacId.ToString();
            }
        }

        private void DodajIzvodjacaDgv(object sender, EventArgs e)
        {
            if (!ValidationDodajIzvodjaca()) return;
            PoluResetForme();
            ispiLbl();
            Izvodjac izvodjac = new Izvodjac()
            {
                ImeIzvodjaca = uCIzvodjac.txtIme.Text.Trim().Replace(" ", ""),
                PrezimeIzvodjaca = uCIzvodjac.txtPrezime.Text.Trim().Replace(" ", ""),
                DatumRodjenja = DateTime.Parse(uCIzvodjac.txtDatumRodjenja.Text),
                BrojNastupa = int.Parse(uCIzvodjac.txtNastup.Text.Trim().Replace(" ", "")),
                MuzickaGrupa = (MuzickaGrupa)uCIzvodjac.cbGrupa.SelectedItem,
            };
            string poruka = $"Ime izvođača: {izvodjac.ImeIzvodjaca}\n" +
                $"Prezime izvođača: {izvodjac.PrezimeIzvodjaca}\n" +
                $"Datum rođenja izvođača(dan-mesec-godina): {izvodjac.DatumRodjenja.ToString("dd-MM-yyyy")}\n" +
                $"Broj nastupa izvođača: {izvodjac.BrojNastupa}\n" +
                $"Muzička grupa kojoj pripada: {izvodjac.MuzickaGrupa.Naziv}\n";
            DialogResult odgovor = MessageBox.Show($"Da li ste sigurni da želite da dodate ovog izvođača\n{poruka}", "Upit", MessageBoxButtons.YesNo);
            if (odgovor == DialogResult.Yes)
            {
                izvodjaci.Add(izvodjac);
                uCIzvodjac.dgvIzvodjaci.DataSource = "";
                uCIzvodjac.dgvIzvodjaci.DataSource = izvodjaci;
                ResetForm();
            }
            else return;
        }
        private void DodajIzvodjaca(object sender, EventArgs e)
        {
            if (izvodjaci.Count == 0)
            {
                if (!ValidationDodajIzvodjaca()) return;
            }
            else
            {

            Response response = Communication.Instance.DodajIzvodjaca(izvodjaci);
            MessageBox.Show(response.Message);
            izvodjaci.Clear();
            uCIzvodjac.btnBack.PerformClick();
            }
        }
        internal void PoluResetForme()
        {
            uCIzvodjac.txtIme.BackColor = uCIzvodjac.txtPrezime.BackColor = uCIzvodjac.txtNastup.BackColor = uCIzvodjac.cbGrupa.BackColor= Color.White;
            uCIzvodjac.txtDatumRodjenja.CalendarMonthBackground = Color.White;
        }
        internal void ResetForm()
        {
            uCIzvodjac.txtIme.BackColor = uCIzvodjac.txtPrezime.BackColor = uCIzvodjac.txtNastup.BackColor = uCIzvodjac.cbGrupa.BackColor = Color.White;
            uCIzvodjac.txtIme.Text = uCIzvodjac.txtPrezime.Text = "";
            uCIzvodjac.txtNastup.Text = uCIzvodjac.txtNastup.Text = "";
            uCIzvodjac.cbGrupa.SelectedIndex = -1;
            uCIzvodjac.txtDatumRodjenja.ResetText();
        }

        private void SacuvajIzmeneIzvodjaca(object sender, EventArgs e)
        {
            if (!ValidationDodajIzvodjaca()) return;
            PoluResetForme();
            ispiLbl();
            Izvodjac izvodjac = new Izvodjac()
            {
                IzvodjacId = int.Parse(uCIzvodjac.lblIdIzvodjaca.Text.ToString()),
                ImeIzvodjaca = uCIzvodjac.txtIme.Text.Trim().Replace(" ", ""),
                PrezimeIzvodjaca = uCIzvodjac.txtPrezime.Text.Trim().Replace(" ", ""),
                DatumRodjenja = DateTime.Parse(uCIzvodjac.txtDatumRodjenja.Text),
                BrojNastupa = int.Parse(uCIzvodjac.txtNastup.Text.Trim().Replace(" ", "")),
                MuzickaGrupa = (MuzickaGrupa)uCIzvodjac.cbGrupa.SelectedItem,
            };
            string poruka =ProveriPoruku(izvodjac);           
            DialogResult odgovor = MessageBox.Show($"Da li ste sigurni da želite da izmenite ovog izvođača\n{poruka}", "Upit", MessageBoxButtons.YesNo);
            if (odgovor == DialogResult.Yes)
            {
            Response res = Communication.Instance.IzmeniIzvodjaca(izvodjac);
            MessageBox.Show(res.Message);
            uCIzvodjac.btnBack.PerformClick();
            }
            else return;
        }
        private string ProveriPoruku(Izvodjac i)
        {
            int promene = 0;
            string poruka = $"Stara vrednost\t  \tNova vrednost\n";
            if (i.PrezimeIzvodjaca != prezime)
            {
                poruka += $"{prezime}\t\t=>\t{i.PrezimeIzvodjaca}\n";
                promene++;
            }
            if (i.BrojNastupa != broj)
            {
                poruka += $"{broj}\t\t=>\t{i.BrojNastupa}\n";                promene++;
            }
            if (i.MuzickaGrupa.Naziv != grupa)
            {
                poruka+= $"{grupa}\t\t=>\t{i.MuzickaGrupa.Naziv}\n";
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
        private bool ValidationDodajIzvodjaca()
        {
            uCIzvodjac.txtDatumRodjenja.CalendarMonthBackground = Color.White;
            List<string> errors = new List<string>();
            List<Control> controls = new List<Control>();
            DateTime trenutni = DateTime.Now;
            int sadGodina = trenutni.Year-18;
            int sadMesec = trenutni.Month;
            int sadDan = trenutni.Day;

            DateTime izabrani = DateTime.Parse(uCIzvodjac.txtDatumRodjenja.Text);
            int izabranaGodina = izabrani.Year-18;
            int izabraniMesec = izabrani.Month;
            int izabraniDan = izabrani.Day;

            int vrednost = (sadGodina - izabranaGodina)*100 + (sadMesec-izabraniMesec)*10 + (sadDan-izabraniDan);

            if (string.IsNullOrEmpty(uCIzvodjac.txtIme.Text) || uCIzvodjac.txtIme.Text.Length < 2 || !uCIzvodjac.txtIme.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errors.Add("Ime mora imati barem 2 slova i mora se sastojati samo od slova!");
                controls.Add(uCIzvodjac.txtIme);
            }

            if (string.IsNullOrEmpty(uCIzvodjac.txtPrezime.Text) || uCIzvodjac.txtPrezime.Text.Length < 2 || !uCIzvodjac.txtPrezime.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errors.Add("Prezime mora imati barem 2 slova i mora se sastojati od slova!");
                controls.Add(uCIzvodjac.txtPrezime);
            }
            if (string.IsNullOrEmpty(uCIzvodjac.txtNastup.Text) || !int.TryParse(uCIzvodjac.txtNastup.Text, out int nastup) || nastup <= 0)
            {
                errors.Add("Redni broj nastupa mora biti pozitivan i predstavljati broj!");
                controls.Add(uCIzvodjac.txtNastup);
            }
            if (vrednost < 1400)
            {
                errors.Add("Izvođač mora imati više od 14 godina!");
                uCIzvodjac.txtDatumRodjenja.CalendarMonthBackground = Color.IndianRed;
                controls.Add(uCIzvodjac.txtDatumRodjenja);
            }
            if (uCIzvodjac.cbGrupa.SelectedIndex < 0)
            {
                errors.Add("Izaberite grupu kojoj izvođač pripada!");
                controls.Add(uCIzvodjac.cbGrupa);
            }
            if (errors.Count > 0)
            {
                ValidationError(errors, controls);
                return false;
            }
            else return true;
        }

        private void ValidationError(List<string> errors, List<Control> controls)
        {
            uCIzvodjac.txtIme.BackColor = Color.White;
            uCIzvodjac.txtPrezime.BackColor = Color.White;
            uCIzvodjac.txtNastup.BackColor = Color.White;
            uCIzvodjac.cbGrupa.BackColor = Color.White;


            if (errors.Count() == 0) return;
            for (int i = 0; i < controls.Count(); i++)
            {
                controls[i].BackColor = Color.LightSalmon;
            }
            ispiLbl();
        }

        private void prepareDgv(List<Izvodjac> izvodjaci)
        {

            if (izvodjaci != null && izvodjaci.Count > 0)
            {
                foreach (Izvodjac i in izvodjaci)
                {
                uCIzmenaIzvodjaca.dgvIzvodjac.DataSource = izvodjaci;
                }
            }
            else MessageBox.Show("Sistem ne može da nađe izvođače po zadatoj vrednosti!","Greška");
        }
        private void ispiLbl()
        {
            if(uCIzvodjac.txtDatumRodjenja.CalendarMonthBackground == Color.White) uCIzvodjac.lblDatumGreska.Text = "";
            else uCIzvodjac.lblDatumGreska.Text = "Izvođač mora imati više od 14 godina";
            if (uCIzvodjac.txtIme.BackColor == Color.White) uCIzvodjac.lblImeGreska.Text = "";
            else uCIzvodjac.lblImeGreska.Text = "Ime mora imati barem 2 slova i mora se sastojati samo od slova!";
            if (uCIzvodjac.txtPrezime.BackColor == Color.White) uCIzvodjac.lblPrezimeGreska.Text = "";
            else uCIzvodjac.lblPrezimeGreska.Text = "Prezime mora imati barem 2 slova i mora se sastojati samo od slova!";
            if (uCIzvodjac.txtNastup.BackColor == Color.White) uCIzvodjac.lblNastupGreska.Text = "";
            else uCIzvodjac.lblNastupGreska.Text = "Redni broj nastupa mora biti pozitivan i predstavljati broj!";
            if (uCIzvodjac.cbGrupa.BackColor == Color.White) uCIzvodjac.lblGrupaGreska.Text = "";
            else uCIzvodjac.lblGrupaGreska.Text = "Izaberite grupu kojoj izvođač pripada";
        }
    }
}
