using Components;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FormLoginHandler
    {
        public static bool ValidServerUser(User pUser)
        {
            ConnectionActor.RequestUsers(pUser);
            return true;
        }

        public static bool ValidUser(User pUser)
        {
            return DefaultValidator.ValidObject<User>(pUser);
        }
    }
}
