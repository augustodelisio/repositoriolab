using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Escritorio
{
    public class Validador
    {

        public static bool validarDNI(string dni)
        {
            if (dni.Length != 8)
                return false;
            Regex reg = new Regex(@"\d{8}");
            Match match = reg.Match(dni);
            return match.Success;
        }

        public static bool validarString(string legajo)
        {
            if (legajo.Length == 0) return false;
            return true;
        }
        public static bool validarText(string txt)
        {
            if (txt.Length == 0) return false;
            return Regex.IsMatch(txt, @"^[\p{L} ]+$");
        }
        public static bool validarDecimal(string txt)
        {
            if (txt.Length == 0) return false;
            return Regex.IsMatch(txt, @"^(?:\d+\,?\d*)?$");
        }
    }
}
