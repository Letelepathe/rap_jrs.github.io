using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapport_Journalier.Config
{
    class MatriculeGeneration
    {
        private static String ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static String Number = "0123456789";
        private static String mat = "";
        

        public static String GeneratMat()
        {
            Random Rand=new Random();
            for (int i = 0; i < 8; i++)
            { 
                mat+=Number[Rand.Next(0,8)];
            }

            return ALPHA[Rand.Next(0, 25)] + mat + ALPHA[Rand.Next(0, 25)];
        }
    }
}
