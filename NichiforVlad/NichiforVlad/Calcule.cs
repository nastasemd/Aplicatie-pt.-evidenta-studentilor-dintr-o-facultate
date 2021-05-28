using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NichiforVlad
{
    class Calcule
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();

        public static void calculStoc(string cs)
        {
            con.ConnectionString = cs;
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "Delete * from CalculStudenti2";
            cmd.ExecuteNonQuery();

            stocInitial(); intrari(); iesiri();

            stocFinal();
            con.Close();
        }

        private static void stocInitial()
        {
            cmd.CommandText = 
                "Insert into CalculStudenti2(id_operatie, data_inceput_an, data_sfarsit_an, data_eveniment, id_specializare, an_specializare, numar_studenti) " +
                "Select 1, an_universitar, DateAdd(\"m\", 10, an_universitar), NULL, id_specializare, an_specializare, numar_studenti " +
                "From AnUniversitar";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private static void intrari()
        {
            cmd.CommandText =
                "Insert into CalculStudenti2(id_operatie, data_inceput_an, data_sfarsit_an, data_eveniment, id_specializare, an_specializare, numar_studenti) " +
                "Select 2, c.data_inceput_an, c.data_sfarsit_an, t.data, t.id_specializare, t.an_specializare, 1 " +
                "From Transfer AS t, CalculStudenti2 AS c " +
                "WHERE " +
                    "t.id_specializare = c.id_specializare AND " +
                    "t.data BETWEEN c.data_inceput_an AND c.data_sfarsit_an AND " +
                    "t.an_specializare = c.an_specializare AND " +
                    "c.id_operatie = 1";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private static void iesiri()
        {
            cmd.CommandText =
                "Insert into CalculStudenti2(id_operatie, data_inceput_an, data_sfarsit_an, data_eveniment, id_specializare, an_specializare, numar_studenti) " +
                "Select 3, c.data_inceput_an, c.data_sfarsit_an, t.data, t.id_specializare, t.an_specializare, -1 " +
                "From Abandon AS t, CalculStudenti2 AS c " +
                "WHERE " +
                    "t.id_specializare = c.id_specializare AND " +
                    "t.data BETWEEN c.data_inceput_an AND c.data_sfarsit_an AND " +
                    "t.an_specializare = c.an_specializare AND " +
                    "c.id_operatie = 1";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private static void stocFinal()
        {
            cmd.CommandText =
                "Insert into CalculStudenti2(id_operatie, data_inceput_an, data_sfarsit_an, data_eveniment, id_specializare, an_specializare, numar_studenti) " +
                "Select 4, data_inceput_an, data_sfarsit_an, NULL, id_specializare, an_specializare, SUM(numar_studenti) " +
                "From CalculStudenti2 " +
                "GROUP BY data_inceput_an, data_sfarsit_an, id_specializare, an_specializare";

            cmd.ExecuteNonQuery();
        }
    }
}