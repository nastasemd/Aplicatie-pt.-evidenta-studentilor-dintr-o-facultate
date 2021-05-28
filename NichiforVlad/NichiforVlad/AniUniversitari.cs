using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NichiforVlad
{
    public partial class AniUniversitari : Form
    {
        string AnSpec = "";
        public AniUniversitari()
        {
            InitializeComponent();
        }
        private void AniUniversitari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anUniversitarDS.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.anUniversitarDS.DataTable1);
            // TODO: This line of code loads data into the 'specializariDS.Specializari' table. You can move, or remove it, as needed.
            this.specializariTableAdapter.Fill(this.specializariDS.Specializari);
            //Initializare lblOp 
            lOp.Text = "";

            //Configurare(butoane) 
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale 
            legareControale(true);

        }
        private void configureazaButoane(bool v)
        {
            bRenuntare.Visible = !v;
            bConfirmare.Visible = !v;
            lIdSpec.Visible = false;

            bAdaugare.Enabled = v;
            bModificare.Enabled = v;
            bStergere.Enabled = v;
        }
        private void legareControale(bool v)
        {
            if (v)
            {
                dateTimePicker1.DataBindings.Add("Value", dataTable1BindingSource, "an_universitar");
                cmbSpec.DataBindings.Add("Text", dataTable1BindingSource, "denumire");
                txtAnSpec.DataBindings.Add("Text", dataTable1BindingSource, "an_specializare");
                lIdSpec.DataBindings.Add("Text", dataTable1BindingSource, "id_specializare");
                txtNrStud.DataBindings.Add("Text", dataTable1BindingSource, "numar_studenti");
            }
            else
            {
                dateTimePicker1.DataBindings.Clear();
                txtAnSpec.DataBindings.Clear();
                cmbSpec.DataBindings.Clear();
                txtNrStud.DataBindings.Clear();
                lIdSpec.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {

            txtAnSpec.ReadOnly = v;
            cmbSpec.Enabled = !v;
            dateTimePicker1.Enabled = !v;
            txtNrStud.ReadOnly = v;
        }
        private void golireCampuri()
        {
            txtAnSpec.Text = "";
            dateTimePicker1.Text = "";
            cmbSpec.Text = "";
            txtNrStud.Text = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile
            if (txtAnSpec.Text == "")
            {
                MessageBox.Show("Completati Anul specializarii!");
                txtAnSpec.Focus();
                return false;
            }
            if (cmbSpec.Text == "")
            {
                MessageBox.Show("Alegeti o specializare!");
                cmbSpec.Focus();
                return false;
            }
            if (txtNrStud.Text == "")
            {
                MessageBox.Show("Completati nr de studenti!");
                txtNrStud.Focus();
                return false;
            }
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Alegeti o data!");
                dateTimePicker1.Focus();
                return false;
            }
            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = dataTable1TableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "an_universitar, id_specializare, an_specializare, numar_studenti";
            string idSpec = cmbSpec.SelectedValue.ToString();
            DateTime d = dateTimePicker1.Value;
            listaValori = "#" + Convert.ToString(d.Month) + "/" + Convert.ToString(d.Day) + "/" + Convert.ToString(d.Year) + "#" + ",'" + idSpec + "','" + txtAnSpec.Text + "','" + txtNrStud.Text + "'";
            cmd.CommandText = "Insert into AnUniversitar(" + listaCampuri + ") " + "Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void refresh_grid(int p)
        {
            dataTable1TableAdapter.Fill(anUniversitarDS.DataTable1);
            dataTable1BindingSource.Position = p;
        }
        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = dataTable1TableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            DateTime d = dateTimePicker1.Value;
            string idSpec = cmbSpec.SelectedValue.ToString();
            listaSet = "an_universitar = #" + Convert.ToString(d.Month) + "/" + Convert.ToString(d.Day) + "/" + Convert.ToString(d.Year) + "#, " + "id_specializare = " + idSpec + "," +
                " an_specializare = " + txtAnSpec.Text + " , numar_studenti = " + txtNrStud.Text;
            cmd.CommandText = "Update AnUniversitar Set " + listaSet + " Where an_universitar = #" + Convert.ToString(d.Month) + "/" + Convert.ToString(d.Day) + "/" + Convert.ToString(d.Year) +
                 "# and id_specializare = " + lIdSpec.Text + " and an_specializare = " + AnSpec;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void bAdaugare_Click(object sender, EventArgs e)
        {
            //Configurare butoane 
            configureazaButoane(false);

            //Dezlegare controale Panel 
            legareControale(false);

            //Ridicare protectie controale Panel 
            protectiePanel(false);

            //Modifcare lblOp 
            lOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            dateTimePicker1.Focus();

            // Golire campuri 
            golireCampuri();
        }

        private void bModificare_Click(object sender, EventArgs e)
        {
            //Configurare butoane 
            configureazaButoane(false);

            //Dezlegare controale Panel 
            legareControale(false);

            //Ridicare protectie controale Panel 
            protectiePanel(false);

            //Modifcare lblOp 
            lOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp 
            dateTimePicker1.Focus();
            AnSpec = txtAnSpec.Text;
        }

        private void bStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No)
                return;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = dataTable1TableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            DateTime d = dateTimePicker1.Value;
            string idSpec = cmbSpec.SelectedValue.ToString();
            cmd.CommandText = "Delete From AnUniversitar Where an_universitar = #" + Convert.ToString(d.Month) + "/" + Convert.ToString(d.Day) + "/" + Convert.ToString(d.Year) +
                 "# and id_specializare = " + idSpec + " and an_specializare = " + txtAnSpec.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            dataTable1BindingSource.RemoveCurrent();
        }

        private void bConfirmare_Click(object sender, EventArgs e)
        {
            if (lOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii())
                    return;
                adauga_inregistrare();
                golireCampuri();

                //Pune cursor pe primul camp 
                dateTimePicker1.Focus();
                refresh_grid(dataTable1BindingSource.Position);
            }
            else if (lOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(dataTable1BindingSource.Position);

                //Initializare lblOp 
                lOp.Text = "";

                //Configurare(butoane) 
                configureazaButoane(true);

                //Protectie componente Panel
                protectiePanel(true);

                //Legare controale 
                legareControale(true);
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void bRenuntare_Click(object sender, EventArgs e)
        {
            //Initializare lblOp 
            lOp.Text = "";

            //Configurare(butoane) 
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale 
            legareControale(true);
        }

        private void txtNrStud_Leave(object sender, EventArgs e)
        {
            decimal p;
            if (lOp.Text == "")
                return;
            if (txtNrStud.Text == "")
                return;
            if (bRenuntare.Focused)
                return;
            try
            {
                p = Convert.ToDecimal(txtNrStud.Text);
            }
            catch
            {
                MessageBox.Show("Format eronat");
                txtNrStud.Focus();
                return;
            }
        }

        private void txtAnSpec_Leave(object sender, EventArgs e)
        {
            decimal p;
            if (lOp.Text == "")
                return;
            if (txtAnSpec.Text == "")
                return;
            if (bRenuntare.Focused)
                return;
            try
            {
                p = Convert.ToDecimal(txtAnSpec.Text);
            }
            catch
            {
                MessageBox.Show("Format eronat");
                txtAnSpec.Focus();
                return;
            }
        }
    }
}