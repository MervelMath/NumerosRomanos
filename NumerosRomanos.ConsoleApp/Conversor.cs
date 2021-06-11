using System;
using System.Collections.Generic;

namespace NumerosRomanos.ConsoleApp
{
    public class Conversor : ConversorExcecoes
    {
        Dictionary<string, int> valoresRomanosEmInteiros = null;

        public int ConverterRomanoParaArabico(string numeroRomano)
        {


            ConversorExcecoes configurar = new ConversorExcecoes();

            numeroRomano = configurar.ConfigurarRomanoMaiorQue4Mil(numeroRomano);


            if (this.valoresRomanosEmInteiros == null)
            {
                valoresRomanosEmInteiros = new Dictionary<string, int>();
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
            }

            if (EhIgualAZero(numeroRomano)) return 0;

            if (EhMaiorIgualA4Mil(numeroRomano))
            {
                int posicaoOndeComecaONumeroMenorQue4Mil = numeroRomano.LastIndexOf(')');

                string unidadeDeMilhar = numeroRomano.Substring(1, posicaoOndeComecaONumeroMenorQue4Mil - 1);
                string menorQueMilhar = numeroRomano.Substring(posicaoOndeComecaONumeroMenorQue4Mil + 1);

                return 1000 * ConverterRomanoParaArabico(unidadeDeMilhar) + ConverterRomanoParaArabico(menorQueMilhar);
            }

            int total = 0;
            int valorAnterior = 0;
            for (int i = numeroRomano.Length - 1; i >= 0; i--)
            {
                int valorAtual = valoresRomanosEmInteiros[numeroRomano.Substring(i, 1)];

                if (valorAtual < valorAnterior)
                    total -= valorAtual;
                else
                {
                    total += valorAtual;
                    valorAnterior = valorAtual;
                }
            }


            return total;
        }



        public string ConverterArabicoParaRomano(int numeroArabico)
        {
            if (numeroArabico >= 4000)
            {
                int unidadeDeMilhar = numeroArabico / 1000;
                numeroArabico %= 1000;
                return ConverterUnidadeMilharMaiorIgualQue4Mil(unidadeDeMilhar) +
                    ConverterArabicoParaRomano(numeroArabico);
            }

            string resultado = "";

            int numero;
            numero = numeroArabico / 1000;
            if (numero < 4000)
                resultado += letrasMilhar[numero];

            numeroArabico %= 1000;

            numero = numeroArabico / 100;
            resultado += letrasCentenas[numero];
            numeroArabico %= 100;

            numero = numeroArabico / 10;
            resultado += letrasDezenas[numero];
            numeroArabico %= 10;

            resultado += letrasUnidades[numeroArabico];

            return resultado;
        }



        /// <summary>
        /// Verifica se o número contém "(", pois o método 'ConfigurarRomanoMaiorIgualA4Mil',
        /// adiciona esse caractere, caso a verificacao seja verdadeira.
        /// </summary>
        /// <param name="numeroRomano"></param>
        /// <returns></returns>
        private static bool EhMaiorIgualA4Mil(string numeroRomano)
        {
            return numeroRomano[0] == '(';
        }

        private static bool EhIgualAZero(string numeroRomano)
        {
            return numeroRomano.Length == 0;
        }
    }
}
