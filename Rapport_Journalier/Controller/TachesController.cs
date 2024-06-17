using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rapport_Journalier.Models;
using Bunifu.Framework.UI;

namespace Rapport_Journalier.Controller
{
    static class TachesController
    {

        //private static String[] bwaka;
        public static int ins;
        public static int Postes;
        public static int Authers;
        public static void index(BunifuCustomDataGrid dg,BunifuCustomLabel Com,BunifuCustomLabel Autres)
        {
            Taches.All(dg);
            Postes= Agents.GetAgentNumberForPoste("DEVELOPPEUR");
            Authers= Agents.GetAgentNumberForOthers("DEVELOPPEUR");
            Com.Text = Convert.ToString(Postes);
            Autres.Text = Authers.ToString();
        }
        public static int getNumberAll()
        {
            return Postes + Authers;
        }
        public static void Show(String mat,BunifuCustomDataGrid dg)
        {
           Taches.findOrFail(mat,dg);
        }
        public static void Show(String mat, BunifuCustomDataGrid dg,string rec)
        {
            try
            {
                Taches.findOrFail(mat, dg,rec);
            }
            catch (Exception ex) 
            {
                
            }
        }
        public static int Create(String[] Fieldset)
        {
                if (Config.ValidateData.ControleData(Fieldset) == false)
            {
                ins = Models.Taches.insert(Fieldset[0], Fieldset[1], Fieldset[2], Fieldset[3], Fieldset[4], Fieldset[5], Fieldset[6]);
                if(ins>0){
                return ins;
                }
            }
            else 
            {
                return 0;
            }
            return 0;
        }
    }
}
