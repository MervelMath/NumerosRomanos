using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class ConversorBase
    {

        protected string[] letrasMilhar = { "", "M", "MM", "MMM" };
        protected string[] letrasMilharMaiorOuIgualA4Mil = { "", "", "", "", "ĪV̄", "V̄", "V̄Ī", "V̄ĪĪ", "V̄ĪĪĪ", "ĪX̄", "X̄" };
        protected string[] letrasCentenas =
            { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        protected string[] letrasDezenas =
            { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        protected string[] letrasUnidades =
            { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
    }
}
