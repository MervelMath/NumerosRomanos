using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos.ConsoleApp;

namespace InputNumbersTest
{
    [TestClass]
    public class RomanosParaInteirosTest
    {
        ConversorRomanoArabico conv = new ConversorRomanoArabico();

        [TestMethod]
        public void MyTestMethod()
        {
            Assert.AreEqual(1, conv.ConverterRomanoParaArabico("I"));
        }

        [TestMethod]
        public void Teste10()
        {
            Assert.AreEqual(10, conv.ConverterRomanoParaArabico("X"));
        }


        [TestMethod]
        public void Teste20()
        {
            Assert.AreEqual(20, conv.ConverterRomanoParaArabico("XX"));
        }

        [TestMethod]
        public void TesteRegraDaSubtracao()
        {
            Assert.AreEqual(24, conv.ConverterRomanoParaArabico("XXIV"));
        }

        [TestMethod]
        public void Teste30()
        {
            Assert.AreEqual(30, conv.ConverterRomanoParaArabico("XXX"));
        }

        [TestMethod]
        public void Teste40()
        {
            Assert.AreEqual(40, conv.ConverterRomanoParaArabico("XL"));
        }

        [TestMethod]
        public void Teste50()
        {
            Assert.AreEqual(50, conv.ConverterRomanoParaArabico("L"));
        }

        [TestMethod]
        public void Teste60()
        {
            Assert.AreEqual(62, conv.ConverterRomanoParaArabico("LXII"));
        }

        [TestMethod]
        public void Teste4Mil()
        {
            Assert.AreEqual(4000, conv.ConverterRomanoParaArabico("ĪV̄"));
        }

        [TestMethod]
        public void TesteMaiorQue4Mil()
        {
            Assert.AreEqual(4500, conv.ConverterRomanoParaArabico("ĪV̄D"));
        }

        [TestMethod]
        public void Teste6Mil()
        {
            Assert.AreEqual(6000, conv.ConverterRomanoParaArabico("V̄Ī"));
        }

        [TestMethod]
        public void TesteMaiorQue6Mil()
        {
            Assert.AreEqual(6004, conv.ConverterRomanoParaArabico("V̄ĪIV"));
        }

        [TestMethod]
        public void TesteMaiorQue7Mil()
        {
            Assert.AreEqual(7015, conv.ConverterRomanoParaArabico("V̄ĪĪXV"));
        }


        [TestMethod]
        public void TesteMaiorQue8Mil()
        {
            Assert.AreEqual(8641, conv.ConverterRomanoParaArabico("V̄ĪĪĪDCXLI"));
        }

        [TestMethod]
        public void TesteMaiorQue9Mil()
        {
            Assert.AreEqual(9120, conv.ConverterRomanoParaArabico("ĪX̄CXX"));
        }

        [TestMethod]
        public void Teste10Mil()
        {
            Assert.AreEqual(10000, conv.ConverterRomanoParaArabico("X̄"));
        }
    }
}
