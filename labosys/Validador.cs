using System;

public class Validador
{
	public Validador()
	{
	}


    public static bool validarDNI(string dni)
    {
        if (dni.Length != 8)
            return false;
        Regex reg = new Regex(@"\d{8}");
        Match match = reg.Match(dni);
        return match.Success;
    }


    public static bool validarText(string txt)
    {   if (string.IsNullOrEmpty(txt)) return false;
        if (txt.Length == 0) return false;
        return Regex.IsMatch(txt, @"^[\p{L} ]+$");
    }



  
}
