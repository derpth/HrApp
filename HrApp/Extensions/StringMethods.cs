using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HrApp
{
    public static class StringMethods
    {
        public static bool CheckString(this string line, string? message = null)
        {
            var result = !String.IsNullOrEmpty(line);
            if (!result && !String.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
            }

            return result;
        }

        public static string PrepareSqlString(this string line)
        {
            var result = line;
     
            if (!String.IsNullOrEmpty(result))
            {
                return $"N\'{result}\'";
            }
            else
            {
                return "null";
            }
        
        }
    }
}
