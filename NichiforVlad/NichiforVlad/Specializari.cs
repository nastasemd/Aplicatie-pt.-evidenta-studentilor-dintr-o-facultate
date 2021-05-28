using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NichiforVlad
{
    public partial class Specializari : Form
    {
        public Specializari()
        {
            InitializeComponent();
        }

        private void Specializari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'specializariDS.Specializari' table. You can move, or remove it, as needed.
            this.specializariTableAdapter.Fill(this.specializariDS.Specializari);

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
                txtDenumire.DataBindings.Add("Text", specializariBindingSource, "denumire");
                txtNrAni.DataBindings.Add("Text", specializariBindingSource, "numar_ani");
                lId.DataBindings.Add("Text", specializariBindingSource, "id_specializare");
            }
            else
            {
                txtDenumire.DataBindings.Clear();
                txtNrAni.DataBindings.Clear();
                lId.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            txtDenumire.ReadOnly = v;
            txtNrAni.ReadOnly = v;
        }
        private void golireCampuri()
        {
            txtDenumire.Text = "";
            txtNrAni.Text = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile
            if (txtDenumire.Text == "")
            {
                MessageBox.Show("Completati Denumireaa!");
                txtDenumire.Focus();
                return false;
            }
            if (txtNrAni.Text == "")
            {
                MessageBox.Show("Completati Numarul de ani!");
                txtNrAni.Focus();
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
            con.ConnectionString = specializariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "denumire, numar_ani";
            listaValori = "'" + txtDenumire.Text + "'" + ",'" + txtNrAni.Text + "'";
            cmd.CommandText = "Insert into Specializari(" + listaCampuri + ") " + "Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void refresh_grid(int p)
        {
            specializariTableAdapter.Fill(specializariDS.Specializari);
            specializariBindingSource.Position = p;
        }
        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = specializariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "denumire = '" + txtDenumire.Text + "'," + "numar_ani = '" + txtNrAni.Text + "'";
            cmd.CommandText = "Update Specializari Set " + listaSet + " Where id_specializare =" + lId.Text;
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
            txtDenumire.Focus();

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
            txtDenumire.Focus();
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
            OleDbDataReader r;
            con.ConnectionString = specializariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select id_specializare From AnUniversitar where id_specializare=" + lId.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Specializare referita in tabela AnUniversitar! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            cmd.CommandText = "Delete From Specializari Where id_specializare = " + lId.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(specializariBindingSource.Position);
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
                txtDenumire.Focus();
                refresh_grid(specializariBindingSource.Position);
            }
            else if (lOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(specializariBindingSource.Position);

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

        private void txtNrAni_Leave(object sender, EventArgs e)
        {
            decimal p;
            if (lOp.Text == "")
                return;
            if (txtNrAni.Text == "")
                return;
            if (bRenuntare.Focused)
                return;
            try
            {
                p = Convert.ToDecimal(txtNrAni.Text);
            }
            catch
            {
                MessageBox.Show("Format eronat");
                txtNrAni.Focus();
                return;
            }
        }

        private void txtDenumire_Leave(object sender, EventArgs e)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            if (lOp.Text == "")
                return;
            if (txtDenumire.Text == "")
                return;
            if (bRenuntare.Focused)
                return;
            con.ConnectionString = specializariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            if (lOp.Text == "ADAUGARE")
            {
                cmd.CommandText = "Select denumire From Specializari where denumire='" + txtDenumire.Text +"'";
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Specializarea deja exista");
                    txtDenumire.Focus();
                    return;
                }
                con.Close();
            }
            else if (lOp.Text == "MODIFICARE")
            {
                cmd.CommandText = "Select denumire From Specializari where denumire='" + txtDenumire.Text + "' and id_specializare <> " + lId.Text;
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Specializare deja existenta");
                    txtDenumire.Focus();
                    return;
                }
                con.Close();
            }
        }
    }
}
