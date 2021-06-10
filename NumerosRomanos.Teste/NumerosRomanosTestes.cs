using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos;
using System;

namespace NumerosRomanosTeste
{
    [TestClass]
    public class NumerosRomanosTestes
    {
        Conversor numeros;
        public NumerosRomanosTestes() 
        {
            numeros = new Conversor();
        }

        [TestMethod]
        public void DeveRetornarValorInvalido()
        {
            Assert.AreEqual("Valor inválido, tente novamente!! (valores entre 0 e 10000)", numeros.ConverterParaRomano(-1));
        }

        [TestMethod]
        public void DeveRetornarI()
        {            
            Assert.AreEqual("I", numeros.ConverterParaRomano(1));
        }

        [TestMethod]
        public void DeveRetornarII()
        {
            Assert.AreEqual("II", numeros.ConverterParaRomano(2));
        }

        [TestMethod]
        public void DeveRetornarIII()
        {
            Assert.AreEqual("III", numeros.ConverterParaRomano(3));
        }

        [TestMethod]
        public void DeveRetornarIV()
        {
            Assert.AreEqual("IV", numeros.ConverterParaRomano(4));
        }

        [TestMethod]
        public void DeveRetornarV()
        {
            Assert.AreEqual("V", numeros.ConverterParaRomano(5));
        }

        [TestMethod]
        public void DeveRetornarXCIX()
        {
            Assert.AreEqual("XCIX", numeros.ConverterParaRomano(99));
        }

        [TestMethod]
        public void DeveRetornarLXXII()
        {
            Assert.AreEqual("LXXII", numeros.ConverterParaRomano(72));
        }

        [TestMethod]
        public void DeveRetornarC()
        {
            Assert.AreEqual("C", numeros.ConverterParaRomano(100));
        }

        [TestMethod]
        public void DeveRetornarCXLII()
        {
            Assert.AreEqual("CXLII", numeros.ConverterParaRomano(142));
        }

        [TestMethod]
        public void DeveRetornarM()
        {
            Assert.AreEqual("M", numeros.ConverterParaRomano(1000));
        }


        [TestMethod]
        public void DeveRetornarMDCCCLXVII()
        {
            Assert.AreEqual("MDCCCLXVII", numeros.ConverterParaRomano(1867));
        }

        [TestMethod]
        public void DeveRetornarVIIIDLXIII()
        {
            Assert.AreEqual("V̄ĪĪĪDLXIII", numeros.ConverterParaRomano(8563));
        }

        [TestMethod]
        public void DeveRetornarX()
        {
            Assert.AreEqual("X̄", numeros.ConverterParaRomano(10000));
        }
    }
}
