using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpresaXYZ.Infra.Converters
{
    public static class CheckType
    {
        public static bool IsInteger(this string value)
        {
            int i;
            return int.TryParse(value, out i);
        }

        public static bool IsDateTime(this string value)
        {
            DateTime d;
            return DateTime.TryParse(value, out d);
        }
    }
}
