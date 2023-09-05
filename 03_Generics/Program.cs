using _00_Biblioteca;

namespace _03_Generics
{
    class Program
    {

        static void Main(string[] args)
        {
            Carros carro = new Carros() { Marca = "FIAT", Modelo = "UNO" };
            Casas casa = new Casas() { Cidade = "Brasília", Endereco = "QSQ 400" };
            Cadastro usuario = new Cadastro() { Nome = "MARIA", Email = "MARIA@GMAIL.COM", Senha = "123456ABC" };


            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);


            Carros carro2 = Serializador.Deserializar<Carros>();
            Casas casa2 = Serializador.Deserializar<Casas>();
            Cadastro usuario2 = Serializador.Deserializar<Cadastro>();

            var carroString = $"Carro: {carro2.Marca} - {carro2.Modelo}";
            var casaString = $"Carro: {casa2.Cidade} - {casa2.Endereco}";
            var usuarioString = $"Carro: {usuario2.Nome} - {usuario2.Email}";

            Console.WriteLine(carroString);
            Console.WriteLine(casaString);
            Console.WriteLine(usuarioString);

            Console.ReadKey();
        }
    }
}