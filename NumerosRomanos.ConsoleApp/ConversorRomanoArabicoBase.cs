using System.Collections.Generic;

namespace NumerosRomanos.ConsoleApp
{
    public class ConversorRomanoArabicoBase
    {

        protected Dictionary<string, int> ConfigurarDicionarioRomanosParaInteiros()
        {

            Dictionary<string, int> valoresRomanosEmInteiros = new Dictionary<string, int>();
            valoresRomanosEmInteiros.Add("I", 1);
            valoresRomanosEmInteiros.Add("V", 5);
            valoresRomanosEmInteiros.Add("X", 10);
            valoresRomanosEmInteiros.Add("L", 50);
            valoresRomanosEmInteiros.Add("C", 100);
            valoresRomanosEmInteiros.Add("D", 500);
            valoresRomanosEmInteiros.Add("M", 1000);
            valoresRomanosEmInteiros.Add("N", 6);
            valoresRomanosEmInteiros.Add("O", 7);
            valoresRomanosEmInteiros.Add("P", 8);
            valoresRomanosEmInteiros.Add("Q", 9);
            valoresRomanosEmInteiros.Add("R", 10);
            return valoresRomanosEmInteiros;
        }


    }
}