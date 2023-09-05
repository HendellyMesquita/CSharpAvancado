using System;

namespace _08_Thread
{
    internal class Program
    {
        const string CodExemploIntroducaoThreading = "1";
        const string CodMultThreading = "2";
        const string CodThreadBackground = "3";
        const string CodThreadSafe = "4";
        const string CodThreadId = "5";
        const string CodThreadSleepJoin = "6";
        const string CodThreadAutoeManual = "7";


        static void Main(string[] args)
        {

            var exemplosThreading = new ExemplosThreads();
            Console.WriteLine("Digite 1 para Vizualizar Exemplo Introdutório Utilizando Threading");
            Console.WriteLine("Digite 2 para Vizualizar Exemplo Utilizando MultThreading");
            Console.WriteLine("Digite 3 para Vizualizar Exemplo Utilizando Thread Background");
            Console.WriteLine("Digite 4 para Vizualizar Exemplo Utilizando Thread Safe");
            Console.WriteLine("Digite 5 para Vizualizar Exemplo Utilizando Thread Identificador Unico");
            Console.WriteLine("Digite 6 para Vizualizar Exemplo Utilizando Thread Sleep e Join");
            Console.WriteLine("Digite 7 para Vizualizar Exemplo Utilizando Thread Auto e Manual");

            var cod = Console.ReadLine();


            switch (cod)
            {
                case CodExemploIntroducaoThreading:
                    exemplosThreading.ThreadingIntroducao();
                    break;
                case CodMultThreading:
                    exemplosThreading.MultThreading();
                    break;
                case CodThreadBackground:
                    exemplosThreading.ThreadBackground();
                    break;
                case CodThreadSafe:
                    exemplosThreading.ThreadSafe();
                    break; 
                case CodThreadId:
                    exemplosThreading.ThreadIdentificadorUnico();
                    break;
                case CodThreadSleepJoin:
                    exemplosThreading.ThreadSleepJoin();
                    break;
                 case CodThreadAutoeManual:
                    exemplosThreading.ThreadAutoeManual();
                    break;
                default:
                    break;
            }
        }

    }
}
