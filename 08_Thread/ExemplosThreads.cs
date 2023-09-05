using System;
using System.Threading;

namespace _08_Thread
{
    public class ExemplosThreads
    {
        public static int Rede { get; private set; }
        private static object variavelControle = 0;
       
        //controla a execução das threads como sinctronização de acesso a recursos
        static ManualResetEvent manualReset = new ManualResetEvent(false); 
        static AutoResetEvent autoResetEvent = new AutoResetEvent(false); 

        //execulta 2 fluxos em paralelo
        public void ThreadingIntroducao()
        {
            Thread t1 = new Thread(ThreadRepetcao);
            t1.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Main: {i}");
            }
            Console.ReadKey();
        }

        public void MultThreading()
        {
            for (int i = 0; i <= 5; i++)
            {
                Thread t1 = new Thread(ThreadRepetcao);
                t1.Start();
            }
            Console.WriteLine("Programa Finalizado");

            Console.ReadKey();
        }

        //utiu quando possui rotinas que se repetem varias vezes
        public void ThreadBackground()
        {
            Console.WriteLine($"DataIni: {DateTime.Now}");

            for (int i = 0; i <= 5; i++)
            {
                Thread t1 = new Thread(ThreadRepetcao);
                t1.IsBackground = true;
                t1.Start();
            }
            Console.ReadKey();
        }

        public void ThreadSafe()
        {
            Console.WriteLine($"DataIni: {DateTime.Now}");

            for (int i = 0; i <= 5; i++)
            {
                Thread t1 = new Thread(ThreadRepetcaoSafe);
                t1.IsBackground = true;
                t1.Start();
            }
            Console.ReadKey();
        }

        public void ThreadIdentificadorUnico()
        {
            for (int i = 0; i <= 5; i++)
            {
                Thread t1 = new Thread(ThreadRepetcaoComId);
                t1.Start(i);
            }
            Console.ReadKey();
        }

        //Faz com q o programa espere um minuto para ezecultar 
        public void ThreadSleepJoin()
        {

            ThreadSleep();
            ThreadJoin();
           
        }

        public void ThreadAutoeManual()
        {
            Thread t1 = new Thread(Execucao01);
            t1.Start();

            Thread t2 = new Thread(Execucao02);
            t2.Start();

            Thread.Sleep(5000);
            manualReset.Set();
            manualReset.Reset();
            autoResetEvent.Set();

            Thread.Sleep(5000);
            manualReset.Set();
            autoResetEvent.Set();

            Console.ReadKey();

        }

        private void Execucao01()
        {
            // manual Reset é nescessario dar reset para retornar a situação 
            Console.WriteLine("01 - Inicio Execução 01");
            manualReset.WaitOne();
            Console.WriteLine("02 - Executando 01 ... 25%");
            Thread.Sleep(3000);
            Console.WriteLine("03 - Executando 01 ... 83%");
            Thread.Sleep(2000);
            Console.WriteLine("04 - Finalizado Execução 01");
        }

        private void Execucao02()
        {
            // n nescessita execultar o reset, feito altomaticamente com o set
            Console.WriteLine("01 - Inicio Execução 02");
            autoResetEvent.WaitOne();
            Console.WriteLine("02 - Executando 02 ... 25%");
            Thread.Sleep(1000);
            Console.WriteLine("03 - Executando 02 ... 83%");
            Thread.Sleep(3000);
            Console.WriteLine("04 - Finalizado Execução 02");
        }

        // verifica se uma thread em execução finalizou para continuar o processamento
        private void ThreadJoin()
        {
            Thread t1 = new Thread(ThreadRepetcao);
                t1.Start();
                t1.Join();
            Console.WriteLine("Após execução Thread Join");

            Console.ReadKey();
        }

        //adiciona um time de espera para a execulção
        private void ThreadSleep()
        {
            Console.WriteLine("Inicio Thread Sleep");
            Thread.Sleep(3000);
            Console.WriteLine("Fim 3000 Sleep");
        }

        private static void ThreadRepetcao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Numero: {i}");
            }
        }
       
        //so finaliza quando td o processo for finalizado
        private static void ThreadRepetcaoSafe()
        {
            lock (variavelControle)
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine($"Numero: {i}");
                    Rede++;
                }
            }
        }

        private static void ThreadRepetcaoComId(object Id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Thread: {Id} - Numero: {i} - ID Interno: {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
