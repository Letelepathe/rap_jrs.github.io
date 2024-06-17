using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Rapport_Journalier.Config
{
    class McConnexion : Connexion
    {
        public MySqlDataReader next; 
      public  McConnexion()
        {
            connexion();
          
        }

        public MySqlConnection getconnexion()
        {
            return getConnexion();
        }

        public void CloseConnexion()
        {
            fermer_Connexion();
        }

        public void OpenConnexion()
        {
            connexion();
        }
        public MySqlCommand getcmd()
        {
            return cmd;
        }

        public void setcmd(String SQL)
        {
            cmd.CommandText = SQL;
        }

        public void setcOnnexion(MySqlConnection con)
        {
            cmd.Connection = con;
        }

        public MySqlDataReader getExecuteReader()
        {
            
            return cmd.ExecuteReader();
        }

        public int getExecuteNonQuery()
        {
            return cmd.ExecuteNonQuery();
        }

        public Object getExecuteScalar()
        {
            return cmd.ExecuteScalar();
        }
        
    }
}
