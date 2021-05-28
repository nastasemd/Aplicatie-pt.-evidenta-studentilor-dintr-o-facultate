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
    public partial class BalantaStudenti : Form
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();

         
        private System.Windows.Forms.Button[] butoane = new System.Windows.Forms.Button[4];

        public BalantaStudenti()
        {
            InitializeComponent();
            butoane[0] = btnFinal;
            butoane[1] = btnInitial;
            butoane[2] = btnTransferuri;
            butoane[3] = btnAbandonuri;
        }

        private void seteazaButoane(int index)
        {
            for (int i = 0; i < butoane.Length; i++)
            {
                if (i == index) butoane[i].Enabled = true;
                else butoane[i].Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = balantaTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            con.Open();

            //Sterg continut tabela BalantaStoc
            cmd.CommandText = "Delete * from BalantaStudenti";
            cmd.ExecuteNonQuery();
            con.Close();

            //Calcul stoc
            Calcule.calculStoc(balantaTableAdapter.Connection.ConnectionString);
            calculStudenti2TableAdapter.Fill(dataSet3.CalculStudenti2);

            //seteaza butoane
            seteazaButoane(0);
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = 
                "INSERT INTO BalantaStudenti (data_inceput_an, data_sfarsit_an, id_specializare, an_specializare, nr_studenti_final) " +
                "SELECT data_inceput_an, data_sfarsit_an, id_specializare, an_specializare, numar_studenti " +
                "FROM CalculStudenti2 Where id_operatie = 4";
            cmd.ExecuteNonQuery();
            con.Close();
            //Afisez balanta
            balantaTableAdapter.Fill(dataSet3.Balanta);

            //seteaza butoane
            seteazaButoane(1);
        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText =
                "UPDATE BalantaStudenti AS b, CalculStudenti2 AS c " +
                "SET b.nr_studenti_initial = c.numar_studenti " +
                "WHERE " +
                    "c.id_operatie = 1 AND " +
                    "c.data_inceput_an = b.data_inceput_an AND " +
                    "c.data_sfarsit_an = b.data_sfarsit_an AND " +
                    "c.id_specializare = b.id_specializare AND " +
                    "c.an_specializare = b.an_specializare";
            cmd.ExecuteNonQuery();
            con.Close();
            //Afisez balanta
            balantaTableAdapter.Fill(dataSet3.Balanta);

            //seteaza butoane
            seteazaButoane(2);
        }

        private void btnTransferuri_Click(object sender, EventArgs e)
        {
            DataSet3TableAdapters.IntrariTableAdapter ta = new DataSet3TableAdapters.IntrariTableAdapter();
            ta.Fill(dataSet3.Intrari);

            DataRelation newRelation = new DataRelation("processDataIntrari",
                new DataColumn[] { dataSet3.Balanta.Columns["data_inceput_an"], dataSet3.Balanta.Columns["data_sfarsit_an"], dataSet3.Balanta.Columns["id_specializare"], dataSet3.Balanta.Columns["an_specializare"] },
                new DataColumn[] { dataSet3.Intrari.Columns["data_inceput_an"], dataSet3.Intrari.Columns["data_sfarsit_an"], dataSet3.Intrari.Columns["id_specializare"], dataSet3.Intrari.Columns["an_specializare"] }
                );
            dataSet3.Relations.Add(newRelation);

            foreach (DataRow rb in dataSet3.Balanta)
            {
                foreach (DataRow ri in rb.GetChildRows("processDataIntrari"))
                {
                    rb["nr_transferuri"] = ri["Total"];
                }
            }

            //seteaza butoane
            seteazaButoane(3);
        }

        private void btnAbandonuri_Click(object sender, EventArgs e)
        {
            DataSet3TableAdapters.IesiriTableAdapter ta = new DataSet3TableAdapters.IesiriTableAdapter();
            ta.Fill(dataSet3.Iesiri);

            DataRelation newRelation = new DataRelation("processDataIesiri",
                new DataColumn[] { dataSet3.Balanta.Columns["data_inceput_an"], dataSet3.Balanta.Columns["data_sfarsit_an"], dataSet3.Balanta.Columns["id_specializare"], dataSet3.Balanta.Columns["an_specializare"] },
                new DataColumn[] { dataSet3.Iesiri.Columns["data_inceput_an"], dataSet3.Iesiri.Columns["data_sfarsit_an"], dataSet3.Iesiri.Columns["id_specializare"], dataSet3.Iesiri.Columns["an_specializare"] }
                );
            dataSet3.Relations.Add(newRelation);

            foreach (DataRow rb in dataSet3.Balanta)
            {
                foreach (DataRow ri in rb.GetChildRows("processDataIesiri"))
                {
                    rb["nr_abandonuri"] = ri["Total"];
                }
            }

            //seteaza butoane
            seteazaButoane(-1);
        }
    }
}
