using Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class User : IDefaultFields
    {
        public string LoginUser { get; set; }
        public string PasswordUser { get; set; }
        public string UnformatedUserList { get; set; }
        public string MessagesList { get; set; }

        public List<string> UnValidateFields = new List<string>(){ "UnformatedUserList", "MessagesList" };

        public List<string> getUnValidateFields()
        {
            return this.UnValidateFields;
        }
    }
}
