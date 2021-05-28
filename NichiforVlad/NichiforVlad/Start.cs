using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NichiforVlad
{
    public partial class Start : Form
    {

        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;

        public Start()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUtilizator.Visible = v;
            txtUtilizator.Visible = v;
            if (v) btnStart.Text = "Log In";
            else btnStart.Text = "Log Out";
        }
        private Boolean Logare_OK()
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return false;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return false;
            }
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=D:\\Facultate\\An III\\SEM 2\\MMP\\proiect\\proiect\\proiect.accdb";

            cmd.Connection = con;
            cmd.CommandText = "Select id_utilizator, parola from Utilizatori " +
            "where utilizator = '" + txtUtilizator.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUtilizator.Focus();
                con.Close();
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private void f2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void f1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalantaStudenti balanta = new BalantaStudenti();
            balanta.ShowDialog();
        }

        private void transferuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportTransferuri raportTransferuri = new RaportTransferuri();
            raportTransferuri.ShowDialog();
        }

        private void abandonuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportAbandonuri raportAbandonuri = new RaportAbandonuri();
            raportAbandonuri.ShowDialog();
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studenti studenti = new Studenti();
            studenti.ShowDialog();
        }

        private void transferuriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.ShowDialog();
        }

        private void abandonuriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abandon abandon = new Abandon();
            abandon.ShowDialog();
        }

        private void graficeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void graficTransferuriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GraficTransferuri graficTransfer = new GraficTransferuri();
            graficTransfer.ShowDialog();
        }

        private void graficAbandonuriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GraficAbandonuri graficAbandon = new GraficAbandonuri();
            graficAbandon.ShowDialog();
        }

        private void anUniversitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AniUniversitari aniUniversitari = new AniUniversitari();
            aniUniversitari.ShowDialog();
        }

        private void specializariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Specializari specializari = new Specializari();
            specializari.ShowDialog();
        }
    }
}
