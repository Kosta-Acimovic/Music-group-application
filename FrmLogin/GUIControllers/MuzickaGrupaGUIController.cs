using Commonn.Communication;
using Commonn.Domain;
using FrmLogin.UserControlls;
using FrmLogin.UserControlls.UCMuzickaGrupa;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace FrmLogin.GUIControllers
{
    internal class MuzickaGrupaGUIController
    {
        private UCSingleMuzickaGrupa uCMG;
        private UCIzmeniMuzickuGrupu uCIzmeniMG;
        private string naziv = "";
        private string scenograf = "";
        private List<MuzickaGrupa> mg = new List<MuzickaGrupa>();
        private List<string> pomocna = new List<string>();

        internal Control CreateUCMuzickaGrupa(UCMode mode, MuzickaGrupa grupa = null)
        {
            uCMG = new UCSingleMuzickaGrupa();
            mg = Communication.Instance.PretraziSveMuzickeGrupe();
            PrepareFormMuzickaGrupa(mode, grupa);
            if (mode == UCMode.Add)
            {
                uCMG.btnSave.Click += SacuvajMuzickuGrupu;
                uCMG.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
            }
            else if (mode == UCMode.Update || mode == UCMode.Show)
            {
                uCMG.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowSearchMuzickeGrupe();
                if (mode == UCMode.Update) uCMG.btnSave.Click += AzurirajMuzickuGrupu;
            }
            return uCMG;
        }

        internal Control CreateUCIzmeniMuzickuGrupu()
        {
            uCIzmeniMG = new UCIzmeniMuzickuGrupu();
            uCIzmeniMG.Load += (s, e) => VratiSveMuzickeGrupe();
            uCIzmeniMG.btnSearch.Click += PretraziPoImenuMuzickeGrupe;
            uCIzmeniMG.btnShow.Click += PrikaziTrazenuMuzickuGrupu;
            uCIzmeniMG.btnEdit.Click += PrikaziMuzickuGrupuZaIzmenu;
            uCIzmeniMG.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
            return uCIzmeniMG;
        }
        private void PrepareFormMuzickaGrupa(UCMode mode, MuzickaGrupa grupa = null)
        {
            pomocna.Clear();
            foreach (MuzickaGrupa muz in mg)
            {
                pomocna.Add(muz.Naziv);
            }
            if (mode == UCMode.Show)
            {
                uCMG.txtNaziv.Enabled = false;
                uCMG.txtScenograf.Enabled = false;
                uCMG.btnSave.Enabled = false;
                uCMG.btnSave.BackColor = Color.LightBlue;

                uCMG.txtNaziv.Text = grupa.Naziv.ToString();
                uCMG.txtScenograf.Text = grupa.Scenograf.ToString();
            }
            else if (mode == UCMode.Update)
            {
                uCMG.lblIdMuzickeGrupe.Text = grupa.GrupaId.ToString();
                uCMG.txtNaziv.Text = grupa.Naziv.ToString();
                naziv = grupa.Naziv;
                uCMG.txtScenograf.Text = grupa.Scenograf.ToString();
                scenograf = grupa.Scenograf;
                pomocna.Remove(naziv);
            }

        }

        private void SacuvajMuzickuGrupu(object sender, EventArgs e)
        {
            if (!ValidateMuzickaGrupa()) return;
            PoluResetForm();
            ispiLbl();
            MuzickaGrupa grupa = new MuzickaGrupa
            {
                Naziv = uCMG.txtNaziv.Text.Trim(),
                Scenograf = uCMG.txtScenograf.Text.Trim(),
            };
            string poruka = $"Naziv muzičke grupe je: {grupa.Naziv}\n" +
                $"Scenograf muzičke grupe je: {grupa.Scenograf} \n";

            DialogResult odgovor = MessageBox.Show($"Da li ste sigurni da želite da dodate ovu muzičku grupu\n{poruka}", "Upit", MessageBoxButtons.YesNo);
            if (odgovor == DialogResult.Yes)
            {
                Response res = Communication.Instance.DodajMuzickuGrupu(grupa);
                MessageBox.Show(res.Message);
                ResetForm();
            }
            else return;
        }
        private string ProveriPoruku(MuzickaGrupa mg)
        {
            int promene = 0;
            string poruka = $"Stara vrednost\t  \tNova vrednost\n";
            if (mg.Naziv != naziv)
            {
                poruka += $"{naziv}\t\t=>\t{mg.Naziv}\n";
                promene++;
            }
            if (mg.Scenograf != scenograf)
            {
                poruka += $"{scenograf}\t\t=>\t{mg.Scenograf}\n"; promene++;
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

        internal bool ValidateMuzickaGrupa()
        {
            List<string> errors = new List<string>();
            List<Control> controls = new List<Control>();

            if (string.IsNullOrEmpty(uCMG.txtNaziv.Text) || uCMG.txtNaziv.Text.Length < 2 || !uCMG.txtNaziv.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errors.Add("Naziv");
                controls.Add(uCMG.txtNaziv);
            }
            if (string.IsNullOrEmpty(uCMG.txtScenograf.Text) || uCMG.txtScenograf.Text.Length < 2 || !uCMG.txtScenograf.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errors.Add("Scenograf");
                controls.Add(uCMG.txtScenograf);
            }
            foreach (string s in pomocna)
            {
                if (s == uCMG.txtNaziv.Text)
                {
                    errors.Add("Naziv");
                    controls.Add(uCMG.txtNaziv);
                }
            }
            if (errors.Count > 0)
            {
                ShowErrors(errors, controls);
                ispiLbl();
                return false;
            }

            return true;
        }

        private void ShowErrors(List<string> errors, List<Control> controls)
        {
            uCMG.txtNaziv.BackColor = Color.White;
            uCMG.txtScenograf.BackColor = Color.White;

            if (errors.Count() == 0) return;
            for (int i = 0; i < controls.Count(); i++)
            {
                controls[i].BackColor = Color.LightSalmon;
            }
        }
        internal void PoluResetForm()
        {
            uCMG.txtNaziv.BackColor = Color.White;
            uCMG.txtScenograf.BackColor = Color.White;
        }
        internal void ResetForm()
        {
            uCMG.txtScenograf.Text = string.Empty;
            uCMG.txtNaziv.Text = string.Empty;
            uCMG.txtNaziv.BackColor = Color.White;
            uCMG.txtScenograf.BackColor = Color.White;
        }
        private void AzurirajMuzickuGrupu(object sender, EventArgs e)
        {
            if (!ValidateMuzickaGrupa()) return;
            PoluResetForm();
            ispiLbl();
            MuzickaGrupa grupa = new MuzickaGrupa
            {
                GrupaId = int.Parse(uCMG.lblIdMuzickeGrupe.Text),
                Naziv = uCMG.txtNaziv.Text.Trim(),
                Scenograf = uCMG.txtScenograf.Text.Trim(),
            };
            string poruka = ProveriPoruku(grupa);
            DialogResult odgovor = MessageBox.Show($"Da li ste sigurni da želite da izmenite ovu grupu\n{poruka}", "Upit", MessageBoxButtons.YesNo);
            if (odgovor == DialogResult.Yes)
            {
                Response res = Communication.Instance.IzmeniMuzickuGrupu(grupa);
                MessageBox.Show(res.Message);
                uCMG.btnBack.PerformClick();
            }
            else return;
        }
        private void VratiSveMuzickeGrupe()
        {
            List<MuzickaGrupa> grupe = Communication.Instance.PretraziSveMuzickeGrupe();
            if (grupe == null || grupe.Count() == 0)
            {
                MessageBox.Show("Sistem nije uspeo da pronađe muzičke grupe");
                return;
            }
            uCIzmeniMG.listMuzickeGrupe.DataSource = null;
            List<ListBoxMuzickeGrupe> listaMG = new List<ListBoxMuzickeGrupe>();
            foreach (MuzickaGrupa m in grupe)
            {
                ListBoxMuzickeGrupe mg = new ListBoxMuzickeGrupe()
                {
                    IdMuzickeGrupe = m.GrupaId,
                    Naziv = m.Naziv,
                };
                mg.Naziv.ToString();
                listaMG.Add(mg);
            }
            uCIzmeniMG.listMuzickeGrupe.DataSource = listaMG;
            uCIzmeniMG.listMuzickeGrupe.DisplayMember = "NazivMuzickeGrupe";
        }

        private void PretraziPoImenuMuzickeGrupe(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uCIzmeniMG.txtSearch.Text)) VratiSveMuzickeGrupe();
            else
            {
                List<MuzickaGrupa> grupe = Communication.Instance.PretraziPoImenuMuzickeGrupe(uCIzmeniMG.txtSearch.Text);
                if (grupe == null || grupe.Count() == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe muzičku grupu po zadatoj vrednosti!", "Greška");
                    return;
                }
                uCIzmeniMG.listMuzickeGrupe.DataSource = null;
                List<ListBoxMuzickeGrupe> listaMG = new List<ListBoxMuzickeGrupe>();
                foreach (MuzickaGrupa m in grupe)
                {
                    ListBoxMuzickeGrupe mg = new ListBoxMuzickeGrupe()
                    {
                        IdMuzickeGrupe = m.GrupaId,
                        Naziv = m.Naziv,
                    };
                    listaMG.Add(mg);
                }
                uCIzmeniMG.listMuzickeGrupe.DataSource = listaMG;
                uCIzmeniMG.listMuzickeGrupe.DisplayMember = "NazivMuzickeGrupe";
            }
        }
        private void PrikaziTrazenuMuzickuGrupu(object sender, EventArgs e)
        {
            MuzickaGrupa grupa = VratiTrazenuMuzickuGrupu();
            if (grupa == null)
            {
                MessageBox.Show("Izaberite neku od muzičkih grupa iz liste");
                return;
            }
            MainCoordinator.Instance.ShowMuzickaGrupaPanel(UCMode.Show, grupa);
        }
        private MuzickaGrupa VratiTrazenuMuzickuGrupu()
        {
            if (uCIzmeniMG.listMuzickeGrupe.SelectedItems.Count == 1)
            {
                string name = ((ListBoxMuzickeGrupe)uCIzmeniMG.listMuzickeGrupe.SelectedItem).Naziv;
                MuzickaGrupa m = new MuzickaGrupa();
                foreach (ListBoxMuzickeGrupe mg in uCIzmeniMG.listMuzickeGrupe.Items)
                {
                    if (mg.Naziv == name)
                    {
                        m.GrupaId = mg.IdMuzickeGrupe;
                        m.Naziv = mg.Naziv;
                    }
                }
                return Communication.Instance.NadjiMuzickuGrupuPoId(m);

            }
            else
            {
                return null;
            }
        }
        private void PrikaziMuzickuGrupuZaIzmenu(object sender, EventArgs e)
        {
            MuzickaGrupa grupa = VratiTrazenuMuzickuGrupu();
            if (grupa == null)
            {
                MessageBox.Show("Izaberite neku od muzičkih grupa iz liste");
                return;
            }
            MainCoordinator.Instance.ShowMuzickaGrupaPanel(UCMode.Update, grupa);
        }
        private void ispiLbl()
        {
            if (uCMG.txtNaziv.BackColor == Color.White) uCMG.lblGrupaGreska.Text = "";
            else uCMG.lblGrupaGreska.Text = "Naziv mora imati barem 2 slova, sastojati se samo od slova\n I biti unikatan!";
            if (uCMG.txtScenograf.BackColor == Color.White) uCMG.lblScenografGreska.Text = "";
            else uCMG.lblScenografGreska.Text = "Scenograf mora imati barem 2 slova i mora se sastojati samo od slova!";
        }
    }
    public class ListBoxMuzickeGrupe
    {
        public int IdMuzickeGrupe { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
