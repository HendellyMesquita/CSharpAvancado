using Nancy.Json;

namespace _03_Generics
{
    public class Serializador
    {
        public static void Serializar(object objeto)
        {
           string caminhoArquivo = @$"C:\Users\Usuario\source\repos\C#Avancado\ArquivosExternos\03_{objeto.GetType().Name}.txt";

            StreamWriter sw = new StreamWriter(caminhoArquivo);
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            var objSerializado = serializador.Serialize(objeto);
            sw.WriteLine(objSerializado);
        
            sw.Close();
        }
        public static T Deserializar <T>()
        {
            string caminhoArquivo = @$"C:\Users\Usuario\source\repos\C#Avancado\ArquivosExternos\03_{typeof(T).Name}.txt";

            StreamReader sr = new StreamReader(caminhoArquivo);
            var linhasArquivo = sr.ReadToEnd();
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            var objDescerializar = serializador.Deserialize<T>(linhasArquivo);
        
            sr.Close();

            return objDescerializar;
        }
    }
}
