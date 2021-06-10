
namespace NumerosRomanos
{
    public class Conversor
    {
        public string ConverterParaRomano(int num)
        {
            string resultado = "";
            NumerosIndoArabico indoArabico = new NumerosIndoArabico();

            int unidade = 0, dezena = 0, centena = 0, milhar = 0;

            if (num < 10 && num >= 0)
                unidade = num;
            else if (num >= 10 && num <= 100)
            {
                unidade = num % 10;
                dezena = num - unidade;
            }
            else if (num > 100 && num < 1000)
            {
                unidade = num % 10;
                dezena = (num % 100) - unidade;
                centena = num - (dezena + unidade);
            }
            else if (num >= 1000 && num <= 10000)
            {
                unidade = num % 10;
                dezena = (num % 100) - unidade;
                centena = (num % 1000) - (dezena + unidade);
                milhar = num - (centena + dezena + unidade);
            }
            else
                return "Valor inválido, tente novamente!! (valores entre 0 e 10000)";

            if(milhar >= 4000)
                resultado += indoArabico.NumerosEmRomanosMaiorQueQuatroMil(milhar);
            else
                resultado = ConverteParaRomano(resultado, indoArabico, milhar);

            resultado = ConverteParaRomano(resultado, indoArabico, centena);
            resultado = ConverteParaRomano(resultado, indoArabico, dezena);
            resultado = ConverteParaRomano(resultado, indoArabico, unidade);

            return resultado;
        }

        public int ConverterParaNat(string romano)
        {
            int resultado = 0;
            NumerosIndoArabico numeros = new NumerosIndoArabico();
            foreach (char letras in romano)
            {                
                resultado += numeros.ConverterParaNumero(letras);
            }

            if (romano.Contains("IV") || romano.Contains("IV"))
                resultado -= 1;
            if(roman)

            return resultado;
        }

        #region Métodos privados
        private static string ConverteParaRomano(string resultado, NumerosIndoArabico indoArabico, int dezena)
        {
            resultado += indoArabico.NumerosEmRomanos(dezena);
            return resultado;
        }
        #endregion
    }
}
