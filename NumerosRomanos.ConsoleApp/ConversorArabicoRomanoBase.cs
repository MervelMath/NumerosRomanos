using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class ConversorArabicoRomanoBase
    {

        protected string[] letrasMilhar = { "", "M", "MM", "MMM" };
        
        protected string[] letrasCentenas =
            { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

        protected string[] letrasDezenas =
            { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };

        protected string[] letrasUnidades =
            { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
    }
}
