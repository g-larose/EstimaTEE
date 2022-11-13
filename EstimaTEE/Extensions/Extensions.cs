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
            string? enumDisplayValue = Enum.GetName(typeof(Status), value) ?? "NA";
            return enumDisplayValue;
        }
    }
}
