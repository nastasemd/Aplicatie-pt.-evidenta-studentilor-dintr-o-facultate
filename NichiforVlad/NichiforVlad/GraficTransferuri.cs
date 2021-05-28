using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace NichiforVlad
{
    public partial class GraficTransferuri : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private decimal totalTransferuri;
        public GraficTransferuri()
        {
            InitializeComponent();
        }

        private void GraficTransferuri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'graficTransferDS.statTransferuri' table. You can move, or remove it, as needed.
            this.statTransferuriTableAdapter.Fill(this.graficTransferDS.statTransferuri);
            //Pregatire con si cmd
            con = statTransferuriTableAdapter.Connection;
            cmd.Connection = con;
            //Total plati
            cmd.CommandText = "select Count(id_transfer) as Total from Transfer";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            totalTransferuri = Convert.ToDecimal(rdr.GetValue(0));
            con.Close();
            rdr.Close();

            txtTotal.Text = "" + totalTransferuri;

            foreach (DataRow r in graficTransferDS.statTransferuri)
            {
                decimal x;
                x = Convert.ToDecimal(r["NrTransferuri"]) / totalTransferuri;
                x = Math.Round(x, 4) * 100;
                x = Math.Round(x, 2);
                r["Procent"] = x;
            }
            dataGridView1.Refresh();
        }
    }
}
