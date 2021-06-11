namespace NumerosRomanos.ConsoleApp
{
    public class ConversorExcecoes : ConversorBase
    {


        public string ConfigurarRomanoMaiorQue4Mil(string roman)
        {
            roman = roman.Replace("V̄ĪĪĪ", "(P)");
            roman = roman.Replace("V̄ĪĪ", "(O)");
            roman = roman.Replace("V̄Ī", "(N)");
            roman = roman.Replace("ĪV̄", "(IV)");
            roman = roman.Replace("V̄", "(V)");
            roman = roman.Replace("ĪX̄", "(Q)");
            roman = roman.Replace("X̄", "(R)");
            return roman;
        }

        public string ConverterUnidadeMilharMaiorIgualQue4Mil(int arabic)
        {
            string result = "";

            result += letrasMilharMaiorOuIgualA4Mil[arabic];

            return result;
        }
    }
}