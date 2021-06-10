using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos;

namespace NumerosRomanosParaNat
{
    [TestClass]
    public class ConverterParaNumerosNat
    {
        Conversor numeros;
        public ConverterParaNumerosNat()
        {
            numeros = new Conversor();
        }

        [TestMethod]
        public void DeveRetornar82()
        {
            Assert.AreEqual(82, numeros.ConverterParaNat("LXXXII"));
        }

        [TestMethod]
        public void DeveRetornar1()
        {
            Assert.AreEqual(1, numeros.ConverterParaNat("I"));
        }

        [TestMethod]
        public void DeveRetornar2()
        {
            Assert.AreEqual(2, numeros.ConverterParaNat("II"));
        }

        [TestMethod]
        public void DeveRetornar9()
        {
            Assert.AreEqual(9, numeros.ConverterParaNat("IX"));
        }

        [TestMethod]
        public void DeveRetornar11()
        {
            Assert.AreEqual(11, numeros.ConverterParaNat("XI"));
        }

        [TestMethod]
        public void DeveRetornar19()
        {
            Assert.AreEqual(19, numeros.ConverterParaNat("XIX"));
        }

        [TestMethod]
        public void DeveRetornar49()
        {
            Assert.AreEqual(49, numeros.ConverterParaNat("XLIX"));
        }

        [TestMethod]
        public void DeveRetornar79()
        {
            Assert.AreEqual(79, numeros.ConverterParaNat("LXXIX"));
        }

        [TestMethod]
        public void DeveRetornar89()
        {
            Assert.AreEqual(89, numeros.ConverterParaNat("LXXXIX"));
        }

        [TestMethod]
        public void DeveRetornar99()
        {
            Assert.AreEqual(99, numeros.ConverterParaNat("XCIX"));
        }

        [TestMethod]
        public void DeveRetornar109()
        {
            Assert.AreEqual(109, numeros.ConverterParaNat("CIX"));
        }

        [TestMethod]
        public void DeveRetornar149()
        {
            Assert.AreEqual(149, numeros.ConverterParaNat("CXLIX"));
        }

        [TestMethod]
        public void DeveRetornar199()
        {
            Assert.AreEqual(199, numeros.ConverterParaNat("CXCIX"));
        }

        [TestMethod]
        public void DeveRetornar499()
        {
            Assert.AreEqual(499, numeros.ConverterParaNat("CDXCIX"));
        }

        [TestMethod]
        public void DeveRetornar999()
        {
            Assert.AreEqual(999, numeros.ConverterParaNat("CMXCIX"));
        }

        [TestMethod]
        public void DeveRetornar1009()
        {
            Assert.AreEqual(1009, numeros.ConverterParaNat("MIX"));
        }

        [TestMethod]
        public void DeveRetornar1049()
        {
            Assert.AreEqual(1049, numeros.ConverterParaNat("MXLIX"));
        }

        [TestMethod]
        public void DeveRetornar1449()
        {
            Assert.AreEqual(1449, numeros.ConverterParaNat("MCDXLIX"));
        }

        [TestMethod]
        public void DeveRetornar4000()
        {
            Assert.AreEqual(4000, numeros.ConverterParaNat("ĪV̄"));
        }

        [TestMethod]
        public void DeveRetornar5685()
        {
            Assert.AreEqual(5685, numeros.ConverterParaNat("V̄DCLXXXV"));
        }

        [TestMethod]
        public void DeveRetornar8685()
        {
            Assert.AreEqual(8685, numeros.ConverterParaNat("V̄ĪĪĪDCLXXXV"));
        }

        [TestMethod]
        public void DeveRetornar10000()
        {
            Assert.AreEqual(10000, numeros.ConverterParaNat("X̄"));
        }
    }
}
