using _00_Biblioteca;
using Nancy.Json;

namespace _02_SerializarJSON
{
    class Program
    {
        private const string _SerializarJSON = "1";
        private const string _DeserializarJSON = "2";
        private const string caminhoArquivo =
            @"C:\Users\Usuario\source\repos\C#Avancado\ArquivosExternos\02_SerializarJSON.Json";

        static void Main(string[] args)
        {


            Console.WriteLine("Digite 1 para Serializar em JSON ou 2 para Deserializar em JSON");

            var cod = Console.ReadLine();


            switch (cod)
            {
                case _SerializarJSON:
                    SerializarJSON();
                    break;
                case _DeserializarJSON:
                    DeserializarJSON();
                    break;
                default:
                    break;
            }
        }
        public static void SerializarJSON()
        {
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            Usuarios usuario = new Usuarios()
            {
                Nome = "Fulano D. Tal .jason",
                Cpf = "111.111.111-11",
                Email = "Fulano.D.Tal.jason@Gmail.com"
            };

           var objSerializado = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(caminhoArquivo);
            sw.WriteLine(objSerializado);
            sw.Close();
        }

        public static void DeserializarJSON()
        {
            StreamReader sr = new StreamReader(caminhoArquivo);
            var linhasArquivo = sr.ReadToEnd();
           
            JavaScriptSerializer serializador = new JavaScriptSerializer();

            Usuarios usuarioDescerializar = serializador.Deserialize<Usuarios>(linhasArquivo);
            sr.Close();

            Console.WriteLine($"Usuario: {usuarioDescerializar.Nome}, " +
               $"Cpf: {usuarioDescerializar.Cpf}, " +
               $"Email: {usuarioDescerializar.Email} ");

            Console.ReadKey();
        }
    }
}