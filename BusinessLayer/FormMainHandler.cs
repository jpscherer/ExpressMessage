using Components;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BusinessLayer
{
    public class FormMainHandler
    {
        private static User _user;
        public static void CreateRefreschControl(User pUser)
        {
            _user = pUser;

            var timerUsers = new System.Timers.Timer();
            timerUsers.Elapsed += new System.Timers.ElapsedEventHandler(RefreshUsers);
            timerUsers.Interval = 6000;
            timerUsers.Enabled = true;


            var timerMessages = new System.Timers.Timer();
            timerMessages.Elapsed += new System.Timers.ElapsedEventHandler(ReceiveMessage);
            timerMessages.Interval = 3000;
            timerMessages.Enabled = true;
        }

        private static void RefreshUsers(object source, ElapsedEventArgs e)
        {
            ConnectionActor.RequestUsers(_user);
        }

        public static void ReceiveMessage(object source, ElapsedEventArgs e)
        {
            ConnectionActor.ReceiveMessage(_user);
        }

        public static void SendMessage(User pUser, Message pMessage)
        {
            if(ValidMessage(pMessage))
                ConnectionActor.SendMessage(pUser, pMessage);
        }

        public static bool ValidMessage(Message pMessage)
        {
            return DefaultValidator.ValidObject<Message>(pMessage);
        }

        public static string FormatUsersList(string pListUnformated)
        {
            int countAux = 0;
            StringBuilder formatedList = new StringBuilder();
            foreach (string part in pListUnformated.Split(':'))
            {
                if (countAux == 3)
                {
                    formatedList.AppendLine();
                    countAux = 0;
                }

                formatedList.AppendFormat("{0} - ", part);

                countAux++;
            }

            return formatedList.ToString();
        }
    }
}
