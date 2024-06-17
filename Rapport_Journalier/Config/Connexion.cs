using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Rapport_Journalier.Config
{
    class Connexion
    {
        protected static MySqlCommand cmd = new MySqlCommand();
        protected static MySqlDataReader read;
        private static MySqlConnection con;


        public static void connexion()
        {
            try
            {
                con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=rapjourn; username=root; password =''");
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static MySqlConnection getConnexion()
        {
            return con;
        }
        public static void fermer_Connexion()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
