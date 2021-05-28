using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NichiforVlad
{
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void Studenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentiDS.Persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.studentiDS.Persoane);

            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

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
            lId.Visible = false;

            bAdaugare.Enabled = v;
            bModificare.Enabled = v;
            bStergere.Enabled = v;
        }
        private void legareControale(bool v)
        {
            if (v)
            {
                txtNume.DataBindings.Add("Text", persoaneBindingSource, "nume");
                txtCNP.DataBindings.Add("Text", persoaneBindingSource, "cnp");
                lId.DataBindings.Add("Text", persoaneBindingSource, "id_persoana");
            }
            else
            {
                txtNume.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                lId.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtCNP.ReadOnly = v;
        }
        private void golireCampuri()
        {
            txtNume.Text = "";
            txtCNP.Text = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati Nume!");
                txtNume.Focus();
                return false;
            }
            if (txtCNP.Text == "")
            {
                MessageBox.Show("Completati CNP !");
                txtCNP.Focus();
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
            con.ConnectionString = persoaneTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "nume, cnp";
            listaValori = "'" + txtNume.Text + "'" + ",'" + txtCNP.Text + "'";
            cmd.CommandText = "Insert into Persoane(" + listaCampuri + ") " + "Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void refresh_grid(int p)
        {
            persoaneTableAdapter.Fill(studentiDS.Persoane);
            persoaneBindingSource.Position = p;
        }
        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = persoaneTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "nume = '" + txtNume.Text + "'," + "cnp = '" + txtCNP.Text + "'";
            cmd.CommandText = "Update Persoane Set " + listaSet + " Where id_persoana =" + lId.Text;
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
            txtNume.Focus();

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
            txtNume.Focus();
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
            con.ConnectionString = persoaneTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From Persoane Where id_persoana = " + lId.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(persoaneBindingSource.Position);
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
                txtNume.Focus();
                refresh_grid(persoaneBindingSource.Position);
            }
            else if (lOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(persoaneBindingSource.Position);

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
        private void txtCNP_Leave(object sender, EventArgs e)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            if (lOp.Text == "")
                return;
            if (txtCNP.Text == "")
                return;
            if (bRenuntare.Focused)
                return;
            try
            {
                p = Convert.ToDecimal(txtCNP.Text);
            }
            catch
            {
                MessageBox.Show("Format eronat");
                txtCNP.Focus();
                return;
            }
            con.ConnectionString = persoaneTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            if (lOp.Text == "ADAUGARE")
            {
                cmd.CommandText = "Select nume From Persoane where cnp=" + txtCNP.Text;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("CNP deja existent");
                    txtCNP.Focus();
                    return;
                }
                con.Close();
            }
            else if (lOp.Text == "MODIFICARE")
            {
                cmd.CommandText = "Select nume From Persoane where cnp=" + txtCNP.Text + " and id_persoana <> " + lId.Text;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("CNP deja existent");
                    txtCNP.Focus();
                    return;
                }
                con.Close();
            }
        }
    }
}
