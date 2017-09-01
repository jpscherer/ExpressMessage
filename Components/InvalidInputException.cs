using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class InvalidInputException : Exception
    {
        private string field;
        public InvalidInputException(string pField)
        {
            this.field = pField;
        }

        public override string Message
        {
            get
            {
                return string.Format("ATENÇÃO - Valor informado para o campo '{0}' é invalido", this.field);
            }
        }
    }
}
