using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmeraldRestaurant
{
    static class Global
    {
        public static string GlobalEmail { get; private set; }
        public static string GlobalWhoSentTheInvitation { get; private set; }
        //public static string GlobalUsername { get; private set; }
        public static void SetGlobalEmail(string email)
        {
            GlobalEmail = email.Trim();
        }
        /*public static void SetGlobalUsername(string userName)
        {
            GlobalUsername = userName;
        }*/
        public static void SetGlobalWhoSentTheInvitation(string whoSentTheInvitation)
        {
            GlobalWhoSentTheInvitation = whoSentTheInvitation.Trim();
        }
    }
}
