using System;

namespace _04_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringDeTeste = "teste 123. Repositório de Estenções";
            Console.WriteLine($"String de teste original: {stringDeTeste}");
          
            var primeiraMaiuscula = stringDeTeste.PrimeiraLetraMaiuscula();
            Console.WriteLine($"String de teste Primeira Maiuscula: {primeiraMaiuscula}");
           
            var removerAcentos = stringDeTeste.RemoverAcentos();
            Console.WriteLine($"String Sem Acentos: {removerAcentos}");
          
            var somenteNumeros = stringDeTeste.SomenteNumeros();
            Console.WriteLine($"String Somente Numeros: {somenteNumeros}");
           
            Console.ReadKey();
        }
    }
}
