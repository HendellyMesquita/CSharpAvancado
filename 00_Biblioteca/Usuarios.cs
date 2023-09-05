namespace _00_Biblioteca
{
    public class Usuarios : ICloneable
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Sexo { get; set; }

        public object Clone()
        {
            return new Usuarios()
            {
                Nome = this.Nome,
                Email = this.Email,
                Senha = this.Senha,
                Cpf = this.Cpf,
                Sexo = this.Sexo
            };
        }
    }
}