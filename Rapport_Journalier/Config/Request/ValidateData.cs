using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;

namespace Rapport_Journalier.Config
{
    static class ValidateData
    {

      public  static bool ControleData(String[] Data)
        {
            foreach (String data in Data)
            {
                if (data.Equals(""))
                {
                    return true;
                }
            }
            return false;
        }
      public static void ResetData(BunifuMaterialTextbox[] Textbox)
      {
          foreach (BunifuMaterialTextbox txt in Textbox)
          {
              txt.Text = "";
          }
          
      }
      public static void ResetData(RichTextBox[] Textbox)
      {
          foreach (RichTextBox txt in Textbox)
          {
              txt.Text = "";
          }

      }

      public static bool ControleData(BunifuMaterialTextbox[] Textbox)
        { 
           foreach(BunifuMaterialTextbox txt in Textbox)
           {
               if (txt.Text.Equals(""))
               {
                   return true;
               }
           }
           return false;
        }

      public static bool ControleData(BunifuMetroTextbox[] Textbox)
        {
            foreach (BunifuMetroTextbox txt in Textbox)
            {
                if (txt.Text.Equals(""))
                {
                    return true;
                }
            }
            return false;
        }

      public static bool ControleData(BunifuTextbox[] Textbox)
        {
            foreach (BunifuTextbox txt in Textbox)
            {
                if (txt.Text.Equals(""))
                {
                    return true;
                }
            }
            return false;
        }


      public static bool ControleData(TextBox[] Textbox)
        {
            foreach (TextBox txt in Textbox)
            {
                if (txt.Text.Equals(""))
                {
                    return true;
                }
            }
            return false;
        }

      





    }
}
