using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class ConversorArabicoRomano : ConversorArabicoRomanoBase
    {

        ConversorExcecoes configurar = new ConversorExcecoes();

        public string ConverterArabicoParaRomano(int numeroArabico)
        {
            if (numeroArabico >= 4000)
            {
                return ConverterMilhar4MilOuMaior(ref numeroArabico);
            }

            string resultado = "";

            int numero;

            numero = ConverterMilhar(ref numeroArabico, ref resultado);

            numero = ConverterCentena(ref numeroArabico, ref resultado);

            numero = ConverterDezena(ref numeroArabico, ref resultado);

            resultado = ConverterUnidade(numeroArabico, resultado);

            return resultado;
        }

        private string ConverterMilhar4MilOuMaior(ref int numeroArabico)
        {
            int unidadeDeMilhar = numeroArabico / 1000;
            numeroArabico %= 1000;
            return configurar.ConvercaoArabicoMilharMaiorIgualQue4Mil(unidadeDeMilhar) +
                ConverterArabicoParaRomano(numeroArabico);
        }

        private int ConverterCentena(ref int numeroArabico, ref string resultado)
        {
            int numero = numeroArabico / 100;
            resultado += letrasCentenas[numero];
            numeroArabico %= 100;
            return numero;
        }

        private int ConverterMilhar(ref int numeroArabico, ref string resultado)
        {
            int numero = numeroArabico / 1000;
            if (numero < 4000)
                resultado += letrasMilhar[numero];

            numeroArabico %= 1000;
            return numero;
        }

        private int ConverterDezena(ref int numeroArabico, ref string resultado)
        {
            int numero = numeroArabico / 10;
            resultado += letrasDezenas[numero];
            numeroArabico %= 10;
            return numero;
        }

        private string ConverterUnidade(int numeroArabico, string resultado)
        {
            resultado += letrasUnidades[numeroArabico];
            return resultado;
        }
    }
}
