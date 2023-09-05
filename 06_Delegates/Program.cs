namespace _06_Delegates
{
    internal class Program
    {
        const string CodExemploIntroducaoDelegates = "1";
        const string CodDelegatesExemploFotografia = "2";


        static void Main(string[] args)
        {

            var exemplosDelegates = new ExemplosDelegates();
            Console.WriteLine("Digite 1 para Vizualizar Exemplo Introdutório Utilizando Delegates");
            Console.WriteLine("Digite 2 para Vizualizar Exemplo Fotografia Utilizando Delegates");

            var cod = Console.ReadLine();


            switch (cod)
            {
                case CodExemploIntroducaoDelegates:
                    exemplosDelegates.DelegatesIntroducao();
                    break;
                case CodDelegatesExemploFotografia:
                    exemplosDelegates.DelegatesExemploFotografia();
                    break;
                default:
                    break;
            }
        }
    }
}
