using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_ExtensionMethods
{
    // toda classe de extenção nescessita que seus metodos sejam estaticos
    // todos os metodos precisam possuir 'this tipo' como parametro
    public static class ExtensionString
    {
        public static string PrimeiraLetraMaiuscula(this String str)
        {
            var primeiraLetra = str.Substring(0,1).ToUpper();

            return primeiraLetra + str.Substring(1);
        }

        public static string RemoverAcentos(this string pValue)
        {
            if (string.IsNullOrWhiteSpace(pValue))
                return pValue;

            pValue = Regex.Replace(pValue, "[ÁÀÂÃÄ]", "A");
            pValue = Regex.Replace(pValue, "[ÉÈÊË]", "E");
            pValue = Regex.Replace(pValue, "[ÍÌÎÏ]", "I");
            pValue = Regex.Replace(pValue, "[ÓÒÔÕÖ]", "O");
            pValue = Regex.Replace(pValue, "[ÚÙÛÜ]", "U");
            pValue = Regex.Replace(pValue, "[Ç]", "C");
            pValue = Regex.Replace(pValue, "[áàâãä]", "a");
            pValue = Regex.Replace(pValue, "[éèêë]", "e");
            pValue = Regex.Replace(pValue, "[íìîï]", "i");
            pValue = Regex.Replace(pValue, "[óòôõö]", "o");
            pValue = Regex.Replace(pValue, "[úùûü]", "u");
            pValue = Regex.Replace(pValue, "[ç]", "c");

            return pValue;
        }

        public static string SomenteNumeros(this string value)
        {
            return Regex.Match(value, "\\d+").Value;
        }
    }
}
