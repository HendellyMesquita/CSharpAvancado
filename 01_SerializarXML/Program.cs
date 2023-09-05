using System.Xml.Serialization;
using _00_Biblioteca;

namespace _01_SerializarXML
{
    class Program
    {
        private const string _SerializarXML = "1";
        private const string _DeserializarXML = "2";
        private const string caminhoArquivo =
            @"C:\Users\Usuario\source\repos\C#Avancado\ArquivosExternos\01_SerializarXML.xml";

        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para Serializar em XML ou 2 para Deserializar em XML");

            var cod = Console.ReadLine();


            switch (cod)
            {
                case _SerializarXML:
                    SerializarXml();
                    break;
                case _DeserializarXML:
                    DeserializarXml();
                    break;
                default:
                    break;
            }
        }

        public static void SerializarXml()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Usuarios));
            Usuarios usuario = new Usuarios()
            {
                Nome = "Fulano D. Tal",
                Cpf = "000.000.000-00",
                Email = "Fulano.D.Tal@Gmail.com"
            };

            StreamWriter sw = new StreamWriter(caminhoArquivo);
            serializador.Serialize(sw, usuario);
            sw.Close();
        }

        public static void DeserializarXml()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Usuarios));
            StreamReader sr = new StreamReader(caminhoArquivo);
            Usuarios usuarioDescerializar = (Usuarios)serializador.Deserialize(sr);
            sr.Close();

            Console.WriteLine($"Usuario: {usuarioDescerializar.Nome}, " +
                $"Cpf: {usuarioDescerializar.Cpf},  " +
                $"Email: {usuarioDescerializar.Email} ");

            Console.ReadKey();

        }
    }
}