using System;

namespace _09_Task2
{
    public class Program
    {
        const string CodExemploIntroducaoTask = "1";
        const string CodTaskExecucoesMultiplas = "2";
      
        static void Main(string[] args)
        {

            var exemplosTasks = new ExemplosTasks();
            Console.WriteLine("Digite 1 para Vizualizar Exemplo Introdutório Utilizando Task");
            Console.WriteLine("Digite 2 para Vizualizar Exemplo Utilizando Execuções Multiplas");        

            var cod = Console.ReadLine();


            switch (cod)
            {
                case CodExemploIntroducaoTask:
                    exemplosTasks.TaskIntroducao();
                    break;
                case CodTaskExecucoesMultiplas:
                    exemplosTasks.TaskExecucoesMultiplas();
                    break;
                default:
                    break;
            }
        }

    }
}
