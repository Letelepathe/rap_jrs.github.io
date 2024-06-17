using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rapport_Journalier.Config;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Bunifu.Framework.UI;


namespace Rapport_Journalier.Models
{
    static class Taches
    {
        private static String [] BWAKA;
        public static McConnexion con = new McConnexion();
        private static MySqlCommand cmd = new MySqlCommand();
        public static String MAT = "";
        public static void findOrFail(String mat,BunifuCustomDataGrid dg)
        {
            con.OpenConnexion();
            cmd.CommandText=("SELECT * FROM `taches_` t inner join agents a where t.NUM_AG=a.NUM_AG and a.MATR_USER='" + mat + "'");
            cmd.Connection = con.getconnexion();
            con.next = cmd.ExecuteReader();
            while (con.next.Read())
            {
                dg.Rows.Add(con.next.GetString("ID_TACHE"),
                    con.next.GetString("NUM_AG"),
                    con.next.GetString("INTITULER"),
                    con.next.GetString("DATE_OUVER"),
                    con.next.GetString("DATE_FERM"),
                    con.next.GetString("OBSERVATION"),
                    con.next.GetString("H_OUVER"),
                    con.next.GetString("H_FERM"));
            }
            con.next.Close();
           // return BWAKA;
        }
        public static void All(BunifuCustomDataGrid dg)
        {
            con.OpenConnexion();
            cmd.CommandText = ("SELECT * FROM `taches_` t NATURAL join agents a where (t.NUM_AG=a.NUM_AG ) ");
            cmd.Connection = con.getconnexion();
            con.next = cmd.ExecuteReader();
            while (con.next.Read())
            {
                dg.Rows.Add(con.next.GetString("ID_TACHE"),
                    con.next.GetString("NUM_AG"),
                    con.next.GetString("INTITULER"),
                    con.next.GetString("DATE_OUVER"),
                    con.next.GetString("DATE_FERM"),
                    con.next.GetString("OBSERVATION"),
                    con.next.GetString("H_OUVER"),
                    con.next.GetString("H_FERM"));
            }
            con.next.Close();
            // return BWAKA;
        }
        public static void findOrFail(String mat, BunifuCustomDataGrid dg,String rec)
        {
            con.OpenConnexion();
            cmd.CommandText = ("SELECT DISTINCTROW * FROM `taches_` t inner join agents a where (t.NUM_AG=a.NUM_AG and a.MATR_USER='" + mat + "') and (t.INTITULER like '%" + rec + "%' or t.OBSERVATION like '%" + rec + "%' or t.DATE_FERM like '%" + rec + "%' )");
            cmd.Connection = con.getconnexion();
            con.next = cmd.ExecuteReader();
            dg.Rows.Clear();
            while (con.next.Read())
            {
                dg.Rows.Add(con.next.GetString("ID_TACHE"),
                    con.next.GetString("NUM_AG"),
                    con.next.GetString("INTITULER"),
                    con.next.GetString("DATE_OUVER"),
                    con.next.GetString("DATE_FERM"),
                    con.next.GetString("OBSERVATION"),
                    con.next.GetString("H_OUVER"),
                    con.next.GetString("H_FERM"));
            }
            con.next.Close();
            // return BWAKA;
        }

        public static int insert(string NUM_AG, string INTITULER, string DATE_OUVER, string DATE_FERM, string OBSERVATION, string H_OUVER, string H_FERM)
        {
            MAT = MatriculeGeneration.GeneratMat();

            try
            {
                con.setcmd("INSERT INTO `taches_`( `NUM_AG`, `INTITULER`, `DATE_OUVER`, `DATE_FERM`, `OBSERVATION`, `H_OUVER`, `H_FERM`) VALUES ('" + NUM_AG + "','" + INTITULER + "','" + DATE_OUVER + "','" + DATE_FERM + "','" + OBSERVATION + "','" + H_OUVER + "','" + H_FERM + "')");
                con.setcOnnexion(con.getconnexion());
                int nbre = con.getExecuteNonQuery();
                return nbre;
            }

            catch (Exception e) { MessageBox.Show(e.ToString()); }
            return 0;

        }
    }
}
