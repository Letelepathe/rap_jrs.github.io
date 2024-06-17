using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rapport_Journalier.Models;

namespace Rapport_Journalier.Controller
{
    static class AgentsController
    {
        public static int ins;
        public static int NUM_AG(string mat)
        {
            return Agents.NUM_AG(mat);
        }

        public static void index(Bunifu.Framework.UI.BunifuCustomDataGrid dg)
        {
            Users.All(dg);
        }
    }
}
