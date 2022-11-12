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
            var str = value switch
            {
                Status.CREATED => "CREATED",
                _ => "NULL",
            };

            return str;
        }
    }
}
