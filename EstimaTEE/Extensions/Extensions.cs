using EstimaTEE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimaTEE.Extensions
{
    public static class Extensions
    {
        public static string FromEnumToString(this Enum value)
        {
            //var enumDisplayValue = (value).ToString();
            //return enumDisplayValue;
            string enumDisplayValue = Enum.GetName(typeof(Status), value);
            return enumDisplayValue;
        }
    }
}
