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
    static class Agents
    {
        public static McConnexion con=new McConnexion();
        private static MySqlCommand cmd = new MySqlCommand();
        
        public static int insert(string Mat_Users, int ID_ROLE, string POSTE)
        {
            try
            {
                con.setcmd("INSERT INTO `agents`(`MATR_USER`, `ID_ROLE`, `POSTE`) VALUES ('" + Mat_Users + "','" + ID_ROLE + "','" + POSTE + "')");
                con.setcOnnexion(con.getconnexion());
                int nbre = con.getExecuteNonQuery();
                return nbre;
            }

            catch (Exception e) { MessageBox.Show(e.ToString()); }
            return 0;

        }

        public static int ID_Roles(String mat)
        {
            cmd.CommandText=("SELECT ID_ROLE FROM agents WHERE MATR_USER='"+mat+"'");
            cmd.Connection=(con.getconnexion());
            int nbre = Convert.ToInt16(cmd.ExecuteScalar());
            return nbre;
        }

        public static int NUM_AG(String mat)
        {
            cmd.CommandText = ("SELECT NUM_AG FROM agents WHERE MATR_USER='" + mat + "'");
            cmd.Connection = (con.getconnexion());
            int nbre = Convert.ToInt16(cmd.ExecuteScalar());
            return nbre;
        }

        public static int GetAgentNumberForPoste(String POSTE)
        {
            cmd.CommandText = ("SELECT COUNT(NUM_AG) FROM agents WHERE POSTE='" + POSTE + "'");
            cmd.Connection = (con.getconnexion());
            int nbre = Convert.ToInt16(cmd.ExecuteScalar());
            return nbre;
        }

        public static int GetAgentNumberForOthers(String POSTE)
        {
            cmd.CommandText = ("SELECT COUNT(NUM_AG) FROM agents WHERE POSTE <>'" + POSTE + "'");
            cmd.Connection = (con.getconnexion());
            int nbre = Convert.ToInt16(cmd.ExecuteScalar());
            return nbre;
        }
    }
}
