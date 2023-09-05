using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace _09_Task2
{
    public class ExemplosTasks
    {
        public void TaskIntroducao()
        {
            Task.Run(() => Metodo01());
            Task.Factory.StartNew(Metodo01);

            Console.ReadKey();
        }

        public void TaskExecucoesMultiplas()
        {

            ListaEnderecos();
            ListaTask();

            Console.WriteLine("Finalizado");
            Console.ReadKey();

        }

        private async Task DownloadPagina(string end)
        {
            WebClient webClient = new WebClient();
            string html = await webClient.DownloadStringTaskAsync(end);
            Console.WriteLine($"{end}");


        }

        private void ListaEnderecos()
        {
            string[] enderecos = new string[]
           {
                "https://www.google.com.br/?hl=pt-BR",
                "https://www.microsoft.com/pt-br",
                "https://g1.globo.com",
           };

            var lista = from end in enderecos select DownloadPagina(end);
            Task.WaitAll(lista.ToArray());
        }

        private void ListaTask()
        {
            List<Task> tasks = new List<Task>();

            tasks.Add(Task.Factory.StartNew(Metodo01));
            tasks.Add(Task.Factory.StartNew(Metodo01));
            tasks.Add(Task.Factory.StartNew(Metodo01));
            tasks.Add(Task.Factory.StartNew(Metodo01));
            tasks.Add(Task.Factory.StartNew(Metodo01));
            tasks.Add(Task.Factory.StartNew(Metodo01));
            tasks.Add(Task.Factory.StartNew(Metodo01));
            tasks.Add(Task.Factory.StartNew(Metodo01));


            //Quando um processo finaliza, pode se continuar com a movimentação em paralelo ao resto do processamento
            //Task.WaitAny(tasks.ToArray());
            //permite continuar processo somente apos toda a execução
            Task.WaitAll(tasks.ToArray());


        }

        private void Metodo01()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Valor: {i} Task Id: {Task.CurrentId}");
            }
        }
    }
}
