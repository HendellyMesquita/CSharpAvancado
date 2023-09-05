namespace _10_Atributos
{
    public class Program
    {
        const string CodExemploDeAtributosValidacao = "1";
        const string CodExemploDeAtributosValidacaoCustomizado = "2";

        static void Main(string[] args)
        {

            var exemplosAtributos = new ExemplosAtributo();
            Console.WriteLine("Digite 1 para Vizualizar Exemplo Utilizando Atributos de Validação");
            Console.WriteLine("Digite 2 para Vizualizar Exemplo Utilizando Atributos de Validação Customizado");

            var cod = Console.ReadLine();


            switch (cod)
            {
                case CodExemploDeAtributosValidacao:
                    exemplosAtributos.AtributosValidacao();
                    break;
                case CodExemploDeAtributosValidacaoCustomizado:
                    exemplosAtributos.AtributosValidacaoCustomizado();
                    break;
               
                default:
                    break;
            }
        }

    }
}