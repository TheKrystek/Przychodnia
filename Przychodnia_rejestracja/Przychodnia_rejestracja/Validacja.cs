using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Przychodnia_rejestracja
{
    static class Validacja
    {
        // Sprawdzanie poprawności formatu: pieniądze
        static public bool Pieniadze(string text)
        {
            Match match = Regex.Match(text, @"^[0-9]{0,6}(\.[0-9]{1,2})?$");
            return match.Success;
        }

        // Sprawdzanie poprawności formatu: tekst
        static public bool Tekst(string text, bool firstCapitalRequired = false)
        {
            Match match;
            if (firstCapitalRequired)
                match = Regex.Match(text, "^[A-ZŚŻŹŁ][a-zA-Z -ąęćśżźółńćŚŻŹŁ]*$");
            else
                match = Regex.Match(text, "^[a-zA-Z -ąęćżźśółńćŚŻŹŁ]+$");
            return match.Success;
        }

        // Sprawdzanie poprawności formatu: kod pocztowy
        static public bool Kod(string text)
        {
            Match match = Regex.Match(text, "^[0-9]{2}-[0-9]{3}$");
            return match.Success;
        }

    }
}
