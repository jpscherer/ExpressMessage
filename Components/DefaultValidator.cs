using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class DefaultValidator
    {
        public static bool ValidObject<T>(T pUser) where T : IDefaultFields
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (pUser.getUnValidateFields().Contains(property.Name))
                    continue;

                string value = Convert.ToString(property.GetValue(pUser));

                if (value.TrimEnd().TrimStart() == string.Empty)
                    throw new InvalidInputException(property.Name);
            }

            return true;
        }
    }
}
