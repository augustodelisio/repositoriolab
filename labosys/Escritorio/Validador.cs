using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public class Validador
    {

        public static bool validarDNI(string dni)
        {
            if ((dni.Length < 8) || (dni.Length > 9))
                return false;
            Regex reg = new Regex(@"^(M|F|m|f)?\d{8}$");
            Match match = reg.Match(dni);
            return match.Success;
        }

        public static bool validarCodAnalisis(string cod)
        {
            if ((cod.Length < 4) || (cod.Length > 6))
                return false;
            Regex reg = new Regex(@"^\d{4,6}$");
            Match match = reg.Match(cod);
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
        public static bool validarPorcentaje(string porc)//ME HICISTE RENEGAR HDP
        {
            try
            {
                string ult = "";
                if (porc.Length > 0)
                {
                    ult = porc.Substring(porc.Length - 1, 1);
                }
                if ((porc.Length == 0) || (ult==",") ) return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No funciona el VALIDADOR DE PORCENTAJE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Regex.IsMatch(porc, @"^(?:(\d{1,2}(\,\d*)?|1?0?0?))?$");

        }
    }
}
