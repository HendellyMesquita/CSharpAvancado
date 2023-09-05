using System.ComponentModel.DataAnnotations;
namespace _00_Biblioteca
{
    public class Cadastro
    {
        [Required(ErrorMessage ="Campo [Nome] Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Idiomas.LinguagemUS), ErrorMessageResourceName = "MSG_OBRIGATORIO")]
        [EmailAddress]
        public string Email { get; set; }

        [Required,StringLength(10, MinimumLength = 8)]
        [ValidacaoCustomizada(ErrorMessage = "Senha muito curta")]
        public string Senha { get; set; }
     
    }
}