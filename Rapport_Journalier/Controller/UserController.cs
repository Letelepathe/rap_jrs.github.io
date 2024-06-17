using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rapport_Journalier.Models;
using Rapport_Journalier.Config;
using System.Windows.Forms;

namespace Rapport_Journalier.Controller
{
    static class UserController
    {
        public static int ins;
        public static String Mat_Users,Nom;
        public static int Roles;
        public static int Create(String [] Fieldset)
        {
            if (Config.ValidateData.ControleData(Fieldset) == false)
            {
                ins = Models.Users.insert(Fieldset[0], Fieldset[1], Fieldset[2], Fieldset[3], Fieldset[4], Fieldset[5], Fieldset[6], Fieldset[7], Fieldset[8], Fieldset[9]);
                if(ins>0){
                    Models.Agents.insert(Users.MAT, 3, Fieldset[10]);
                    Mat_Users = Users.MAT;
                    Roles = Agents.ID_Roles(Mat_Users);
                    Nom = Fieldset[0];
                return ins;
                }
            }
            else 
            {
                return 0;
            }
            return 0;
        }

        public static void Show(String mat)
        {
            MessageBox.Show("Bienvenue cher membre tel");
        }
    }
}
