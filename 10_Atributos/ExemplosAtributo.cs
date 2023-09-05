using _00_Biblioteca;
using System.ComponentModel.DataAnnotations;

namespace _10_Atributos
{
    [Atributos("Atributo Classe", Descricao = "Descrição do Atributo")]
    public class ExemplosAtributo
    {
       
        public void AtributosValidacao()
        {
            Cadastro cadastro = new Cadastro() { Nome = "Hendy", Email = "Email", Senha = "1234" };
            ValidationContext validationContext = new ValidationContext(cadastro);
            List<ValidationResult>results = new List<ValidationResult>();

            Validator.TryValidateObject(cadastro, validationContext, results,true);

                foreach(var erro in results)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            Console.ReadKey();
        }
        public void AtributosValidacaoCustomizado()
        {
            Cadastro cadastro = new Cadastro() { Nome = "Hendy", Email = "Email", Senha = "123456" };
            ValidationContext validationContext = new ValidationContext(cadastro);
            List<ValidationResult> results = new List<ValidationResult>();

            Validator.TryValidateObject(cadastro, validationContext, results, true);

            foreach (var erro in results)
            {
                Console.WriteLine(erro.ErrorMessage);
            }
            Console.ReadKey();
        }
    }
}