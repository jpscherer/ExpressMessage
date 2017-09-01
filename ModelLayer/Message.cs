using Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Message : IDefaultFields
    {
        public string UserCodeDestination { get; set; }
        public string MessageContent { get; set; }

        public List<string> UnValidateFields = new List<string>() {  };
        public List<string> getUnValidateFields()
        {
            return this.UnValidateFields;
        }
    }
}
