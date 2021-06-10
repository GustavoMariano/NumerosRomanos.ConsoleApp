
using System;

namespace NumerosRomanos
{
    public class NumerosIndoArabico
    {
        internal string NumerosEmRomanosMaiorQueQuatroMil(int numero)
        {
            string resultado = "";
            switch (numero)
            {
                case 4000: resultado += "ĪV̄"; break;
                case 5000: resultado += "V̄"; break;
                case 6000: resultado += "V̄Ī"; break;
                case 7000: resultado += "V̄ĪĪ"; break;
                case 8000: resultado += "V̄ĪĪĪ"; break;
                case 9000: resultado += "ĪX̄"; break;
                case 10000: resultado += "X̄"; break;
                default: break;
            }

            return resultado;
        }

        internal string NumerosEmRomanos(int numero)
        {
            string resultado = "";
            switch (numero)
            {
                case 0: resultado += ""; break;
                case 1: resultado += "I"; break;
                case 2: resultado += "II"; break;
                case 3: resultado += "III"; break;
                case 4: resultado += "IV"; break;
                case 5: resultado += "V"; break;
                case 6: resultado += "VI"; break;
                case 7: resultado += "VII"; break;
                case 8: resultado += "VIII"; break;
                case 9: resultado += "IX"; break;
                case 10: resultado += "X"; break;
                case 20: resultado += "XX"; break;
                case 30: resultado += "XXX"; break;
                case 40: resultado += "XL"; break;
                case 50: resultado += "L"; break;
                case 60: resultado += "LX"; break;
                case 70: resultado += "LXX"; break;
                case 80: resultado += "LXXX"; break;
                case 90: resultado += "XC"; break;
                case 100: resultado += "C"; break;
                case 200: resultado += "CC"; break;
                case 300: resultado += "CCC"; break;
                case 400: resultado += "CD"; break;
                case 500: resultado += "D"; break;
                case 600: resultado += "DC"; break;
                case 700: resultado += "DCC"; break;
                case 800: resultado += "DCCC"; break;
                case 900: resultado += "CM"; break;
                case 1000: resultado += "M"; break;
                default:
                    break;
            }
            return resultado;
        }

        internal int ConverterParaNumero(char letras)
        {
            switch (letras)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                //case 'V̄': return 5000;
                default: return 0;
            }
        }
    }
}
