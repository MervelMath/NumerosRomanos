using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos.ConsoleApp;
namespace InputNumbersTest
{
    [TestClass]
    public class InteirosParaRomanosTest
    {
        ConversorArabicoRomano conv = new ConversorArabicoRomano();


        [TestMethod]
        public void Teste1()
        {
            Assert.AreEqual("I", conv.ConverterArabicoParaRomano(1));
        }

        [TestMethod]
        public void Teste10()
        {
            Assert.AreEqual("X", conv.ConverterArabicoParaRomano(10));
        }


        [TestMethod]
        public void TesteMaiorQue10()
        {
            Assert.AreEqual("XVI", conv.ConverterArabicoParaRomano(16));
        }


        [TestMethod]
        public void Teste20()
        {
            Assert.AreEqual("XXV", conv.ConverterArabicoParaRomano(25));
        }

        [TestMethod]
        public void Teste30()
        {
            Assert.AreEqual("XXXV", conv.ConverterArabicoParaRomano(35));
        }



        [TestMethod]
        public void Teste40()
        {
            Assert.AreEqual("XLV", conv.ConverterArabicoParaRomano(45));
        }

        [TestMethod]
        public void Teste50()
        {
            Assert.AreEqual("LIX", conv.ConverterArabicoParaRomano(59));
        }


        [TestMethod]
        public void TesteMaiorQue4Mil()
        {
            Assert.AreEqual("ĪV̄D", conv.ConverterArabicoParaRomano(4500));
        }



        [TestMethod]
        public void TesteMaiorQue5MilEDezena60()
        {
            Assert.AreEqual("V̄LXVIII", conv.ConverterArabicoParaRomano(5068));
        }

        [TestMethod]
        public void TEste6MilCentena200EDezena70()
        {
            Assert.AreEqual("V̄ĪCCLXXII", conv.ConverterArabicoParaRomano(6272));
        }

        [TestMethod]
        public void TEste8MilCentena500EDezena80()
        {
            Assert.AreEqual("V̄ĪĪĪDLXXXVI", conv.ConverterArabicoParaRomano(8586));
        }

        [TestMethod]
        public void TEste9MilCentena900EDezena90()
        {
            Assert.AreEqual("ĪX̄CMXCII", conv.ConverterArabicoParaRomano(9992));
        }




        [TestMethod]
        public void Teste10Mil()
        {
            Assert.AreEqual("X̄", conv.ConverterArabicoParaRomano(10000));
        }

        [TestMethod]
        public void TesteMaiorQue10Mil()
        {
            Assert.AreEqual("X̄I", conv.ConverterArabicoParaRomano(10001));
        }

    }
}
