using _00_Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Reflection
{
    public class Logs
    {
        public class LogSemReflection
        {
            public static List<Usuarios> Usuarios = new List<Usuarios>();
            public static List<Carros> Carros = new List<Carros>();

            public static void GravarUsuario(Usuarios usuario)
            {
                Usuarios.Add((Usuarios)usuario.Clone());
            }
            public static void GravarCarro(Carros carros)
            {
                Carros.Add((Carros)carros.Clone());
            }
            public static void ApresentarLog()
            {
                foreach (var usuario in Usuarios)
                {
                    Console.WriteLine($"Nome: {usuario.Nome}");
                    Console.WriteLine($"Email {usuario.Email}");
                    Console.WriteLine($"Senha {usuario.Senha}");
                }

                foreach (var carro in Carros)
                {
                    Console.WriteLine($"Marca: {carro.Marca}");
                    Console.WriteLine($"Modelo {carro.Modelo}");
                }
            }

        }

        public class LogComReflection
        {
            public static List<Object> Objects = new List<Object>();

            public static void Gravar(Object obj)
            {
                Objects.Add(obj);
            }
            public static void ApresentarLog()
            {
                foreach(object obj in Objects)
                {
                    Console.WriteLine($"____________________ Classe: {obj.GetType().Name} ____________________");

                    foreach(var prop in obj.GetType().GetProperties())
                    {
                        Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)} ");
                    }
                    Console.WriteLine($" ");

                }
            }
        }
    }

}
