namespace _11_Reflection
{
    public class Program
    {
        const string CodExemploDeReflection = "1";
        const string CodExemploDeReflection2 = "2";

        static void Main(string[] args)
        {

            var exemplosReflection = new ExemplosReflections();
            Console.WriteLine("Digite 1 para Vizualizar Exemplo Utilizando Reflection");
            Console.WriteLine("Digite 2 para Vizualizar Exemplo Utilizando Reflection");

            var cod = Console.ReadLine();


            switch (cod)
            {
                case CodExemploDeReflection:
                    exemplosReflection.ReflectionIntroducao();
                    break;
                case CodExemploDeReflection2:
                    exemplosReflection.ExemploReflection();
                    break;

                default:
                    break;
            }
        }

    }
}