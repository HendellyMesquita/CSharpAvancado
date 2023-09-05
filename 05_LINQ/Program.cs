namespace _05_LINQ
{
    public class Program
    {
        const string CodExemploIntroducaoLINQ = "1";
        const string CodExemploLINQComObtetos = "2";
        const string CodExemploLINQComJoin = "3";
        const string CodExemploLINQComGroup = "4";

        static void Main(string[] args)
        {
            var exemplosComlinq = new ExemplosLinq();


            Console.WriteLine("Digite 1 para Vizualizar Exemplo Introdutório Utilizando Linq");
            Console.WriteLine("Digite 2 para Vizualizar Exemplo Com Obtetos Utilizando Linq");
            Console.WriteLine("Digite 3 para Vizualizar Exemplo Com JOIN Utilizando Linq");
            Console.WriteLine("Digite 4 para Vizualizar Exemplo Com GROUP Utilizando Linq");

            var cod = Console.ReadLine();


            switch (cod)
            {
                case CodExemploIntroducaoLINQ:
                    exemplosComlinq.ExemploIntroducaoLINQ();
                    break;
                case CodExemploLINQComObtetos:
                    exemplosComlinq.ExemploLINQComObtetos();
                    break;
                case CodExemploLINQComJoin:
                    exemplosComlinq.ExemploLINQComJoin();
                    break;
                case CodExemploLINQComGroup:
                    exemplosComlinq.ExemploLINQComGroup();
                    break;
                default:
                    break;
            }
        }
    }
}
