using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace NichiforVlad
{
    public partial class GraficAbandonuri : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private decimal totalAbandonuri;

        public GraficAbandonuri()
        {
            InitializeComponent();
        }

        private void GraficAbandonuri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'graficAbandonDS.statAbandon' table. You can move, or remove it, as needed.
            this.statAbandonTableAdapter.Fill(this.graficAbandonDS.statAbandon);

            //Pregatire con si cmd
            con = statAbandonTableAdapter.Connection;
            cmd.Connection = con;
            //Total plati
            cmd.CommandText = "select Count(id_abandon) as Total from Abandon";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            totalAbandonuri = Convert.ToDecimal(rdr.GetValue(0));
            con.Close();
            rdr.Close();

            txtTotal.Text = "" + totalAbandonuri;

            foreach (DataRow r in graficAbandonDS.statAbandon)
            {
                decimal x;
                x = Convert.ToDecimal(r["NrAbandonuri"]) / totalAbandonuri;
                x = Math.Round(x, 4) * 100;
                x = Math.Round(x, 2);
                r["Procent"] = x;
            }
            dataGridView1.Refresh();
        }
    }
}
