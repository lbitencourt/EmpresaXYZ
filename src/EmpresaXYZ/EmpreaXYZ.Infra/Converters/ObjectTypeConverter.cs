using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EmpresaXYZ.Infra.Converters
{
    public static class ObjectTypeConverter
    {
        public static Int32 ToInt32(this object value)
        {
            return Convert.ToInt32(value);
        }       

        public static DateTime ToDateTime(this object value)
        {
            return Convert.ToDateTime(value);
        }       
    }
}
