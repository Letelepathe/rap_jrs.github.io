using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rapport_Journalier.Models;

namespace Rapport_Journalier.Controller
{
    static class AuthController
    {
        public static int ins;
        public static String Mat_Users, Nom;
        public static int Roles;

        public static String [] Login(String username,String MP)
        {
           return Users.findOrFail(username,MP);
        }

    }
}
