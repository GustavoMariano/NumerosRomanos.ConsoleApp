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
        public void DeveRetornarValorInvalido()
        {
            Assert.AreEqual(82, numeros.ConverterParaNat("LXXXII"));
        }
    }
}
