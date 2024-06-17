using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rapport_Journalier.Config;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rapport_Journalier.Models
{
    static class Users
    {
        private static McConnexion con=new McConnexion();
        private static MySqlCommand cmd=new MySqlCommand();
        private static String[] BWAKA;
        private static int ID;
        public static String MAT = "";

        public static int insert(string nom, string postnom, string prenom, string sexe, string numTel, string Adresse, string Prov, string TEL, string PWD,string EMAIL )
        {
            MAT = MatriculeGeneration.GeneratMat();
            try
            {
                con.setcmd("INSERT INTO `users` (`MATR_USER` ,`NOM`, `POSTNOM`, `PRENOM`, `SEXE`, `NUM_TEL`, `ADRESSE`, `PROVINCE`, `TERRITOIRE`, `PWD`, `EMAIL`) VALUES ('" +MAT+ "','" + nom + "','" + postnom + "','" + prenom + "','" + sexe + "','" + numTel + "','" + Adresse + "','" + Prov + "','" + TEL + "','" + PWD + "','" + EMAIL + "')");
                con.setcOnnexion(con.getconnexion());
                int nbre = con.getExecuteNonQuery();
                return nbre;
            }

            catch (Exception e) {  }
            return 0;

        }
        public static String[] findOrFail(String username,String MP)
        {
            cmd.CommandText=("SELECT * FROM `agents` a inner join users u WHERE u.MATR_USER=a.MATR_USER and u.EMAIL='" + username + "' and u.PWD='" + MP + "'");
            cmd.Connection= con.getconnexion();
            con.next = cmd.ExecuteReader();
            while (con.next.Read())
            {
                BWAKA = new String[] {con.next.GetString("MATR_USER"),
                    con.next.GetString("ID_ROLE"),
                con.next.GetString("NOM")};
                
            }
            con.next.Close();
            con.CloseConnexion();
            return BWAKA;
        }

        public static void All(Bunifu.Framework.UI.BunifuCustomDataGrid dg)
        {
            cmd.CommandText = ("SELECT * FROM `agents` a inner join users u WHERE u.MATR_USER=a.MATR_USER");
            cmd.Connection = con.getconnexion();
            con.next = cmd.ExecuteReader();
            while (con.next.Read())
            {
                dg.Rows.Add(con.next.GetString("MATR_USER"),
               con.next.GetString("NOM"),
                con.next.GetString("POSTNOM"),
                    con.next.GetString("PRENOM"),
                        con.next.GetString("SEXE"),
                            con.next.GetString("NUM_TEL"),
                                con.next.GetString("ADRESSE"),
                                    con.next.GetString("PROVINCE"),
                                        con.next.GetString("TERRITOIRE")
                );

            }
            con.next.Close();
            con.CloseConnexion();
            
        }

        public static int GenerateID(string nom_espece)
        {
            try
            {
                
                //cmd.Connection = EcoleConnexion.getConnexion();
                //int ID = Convert.ToInt16(cmd.ExecuteScalar());
                //return ID;
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            return 0;
        }

        public static string GenerateMAT(string nom_espece)
        {
            try
            {
                //EcoleConnexion.connexion();
                //cmd.CommandText = "select MAT_ELE from eleve where MAT_ELE like '" + nom_espece + "'";
                //cmd.Connection = EcoleConnexion.getConnexion();
                ////int ID = Convert.ToInt16(cmd.ExecuteScalar());
                //return Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            //return Convert.ToString(cmd.ExecuteScalar());
            return " ";
        }

        public static void select(ComboBox data)
        {
            try
            {
                //EcoleConnexion.connexion();

                //cmd.CommandText = "select el.NOM_ELE from eleve el right join inscription inc on el.ID_ELE=inc.ID_ELE  ";
                //cmd.Connection = EcoleConnexion.getConnexion();
                //read = cmd.ExecuteReader();
                //while (read.Read())
                //{
                //    data.Items.Add(read.GetValue(0));
                //}
            }
            catch (Exception e) { MessageBox.Show("ERREUR SURVENU"); }

        }
        public static void ELEVE_ADMIS(ListBox data)
        {
            try
            {
                //EcoleConnexion.connexion();

                //cmd.CommandText = "select el.NOM_ELE,sum(P.cote_obtenu)/ sum(ex.COTE_EXAM)*100 from passer P inner join eleve el inner join examen ex on el.ID_ELE=P.ID_ELE and ex.ID_EXA=P.ID_EXA group by el.NOM_ELE having sum(P.cote_obtenu)/ sum(ex.COTE_EXAM)*100 >=55   ";
                //cmd.Connection = EcoleConnexion.getConnexion();
                //read = cmd.ExecuteReader();
                //data.Items.Clear();
                //while (read.Read())
                //{
                //    data.Items.Add(read.GetValue(0));
                //}
            }
            catch (Exception e) { MessageBox.Show("ERREUR SURVENU"); }

        }
        public static Boolean ELEVE_ADMIS(ListBox data, string mat)
        {
            try
            {
                //EcoleConnexion.connexion();

                //cmd.CommandText = "select * from eleve where MAT_ELE like '" + mat + "'";
                //cmd.Connection = EcoleConnexion.getConnexion();
                //read = cmd.ExecuteReader();
                //while (read.Read())
                //{
                //    data.Items.Add(read.GetValue(2));
                //}
                //if (data.Items.Count > 0)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
                return true;
            }
            catch (Exception e) { MessageBox.Show(e.ToString(), "ERREUR SURVENU"); return false; }

        }

        public static void SelectEleve(DataGridView data)
        {
            try
            {
                //EcoleConnexion.connexion();

                //cmd.CommandText = "SELECT * FROM `eleve` as el natural join promotion as p where el.ID_PROMO=p.ID_PROMO ";
                //cmd.Connection = EcoleConnexion.getConnexion();
                //cmd.CommandTimeout = 1000;
                //if (cmd.CommandTimeout > 1000)
                //{
                //    MessageBox.Show("Connecting...");
                //}
                //else
                //{
                //    read = cmd.ExecuteReader();
                //    data.Rows.Clear();
                //    while (read.Read())
                //    {
                //        data.Rows.Add(read.GetValue(2), read.GetValue(3), read.GetValue(4), read.GetValue(5), read.GetValue(7), read.GetValue(6), read.GetValue(9), read.GetValue(8), read.GetValue(1));
                //    }
                //}

            }
            catch (Exception e) { MessageBox.Show("ERREUR SUVENU"); }

        }
    }
}
