using System;
using System.Collections.Generic;

namespace NumerosRomanos.ConsoleApp
{
    public class ConversorRomanoArabico : ConversorRomanoArabicoBase
    {
        private Dictionary<string, int> valoresRomanosEmInteiros = null;

        public int ConverterRomanoParaArabico(string numeroRomano)
        {


            ConversorExcecoes configurar = new ConversorExcecoes();

            numeroRomano = configurar.ConfigurarRomanoMaiorQue4Mil(numeroRomano);


            if (this.valoresRomanosEmInteiros == null)
            {
                valoresRomanosEmInteiros = new Dictionary<string, int>();
                valoresRomanosEmInteiros = ConfigurarDicionarioRomanosParaInteiros();
            }

            if (EhIgualAZero(numeroRomano)) return 0;

            if (EhMaiorIgualA4Mil(numeroRomano))
            {
                return ConverterRomanoMaiorIgual4Mil(numeroRomano);
            }

            int total = 0;
            int valorAnterior = 0;

            for (int i = numeroRomano.Length - 1; i >= 0; i--)
            {
                MontarNumeroRomanoParaArabico(numeroRomano, ref total, ref valorAnterior, i);
            }


            return total;
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

        private void MontarNumeroRomanoParaArabico(string numeroRomano, ref int total, ref int valorAnterior, int i)
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

        private int ConverterRomanoMaiorIgual4Mil(string numeroRomano)
        {
            return MontarRomanoParaArabicoMaiorIgual4Mil(numeroRomano);
        }

        private int MontarRomanoParaArabicoMaiorIgual4Mil(string numeroRomano)
        {
            int posicaoOndeComecaONumeroMenorQue4Mil = numeroRomano.LastIndexOf(')');

            string unidadeDeMilhar = numeroRomano.Substring(1, posicaoOndeComecaONumeroMenorQue4Mil - 1);
            string menorQueMilhar = numeroRomano.Substring(posicaoOndeComecaONumeroMenorQue4Mil + 1);

            return 1000 * ConverterRomanoParaArabico(unidadeDeMilhar) + ConverterRomanoParaArabico(menorQueMilhar);
        }

    }
}
