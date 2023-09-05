using _00_Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Reflection
{
    public class ExemplosReflections
    {
        Usuarios usuarios = new Usuarios()
        {
            Nome = "José Caarls",
            Email = "Jose@Gmail.com",
            Senha = "123Teste",
        };

        Carros carros = new Carros()
        {
            Marca = "FIAT",
            Modelo = "Uno",
        };
        public void ReflectionIntroducao()
        {

            Logs.LogSemReflection.GravarUsuario(usuarios);
            Logs.LogSemReflection.GravarCarro(carros);

            usuarios.Nome = "José Carlos Silva";
            carros.Modelo = "TESTE";
            Logs.LogSemReflection.GravarUsuario(usuarios);
            Logs.LogSemReflection.GravarCarro(carros);

            Logs.LogSemReflection.ApresentarLog();
            Console.WriteLine("Log Gravado");
            Console.ReadKey();
        }

        public void ExemploReflection()
        {
           
            Logs.LogComReflection.Gravar(usuarios.Clone());
            Logs.LogComReflection.Gravar(carros.Clone());

            usuarios.Nome = "José Carlos Silva";
            usuarios.Sexo = "Masculino";
            carros.Marca = "Mustang";
            carros.Modelo = "64";
            Logs.LogComReflection.Gravar(usuarios.Clone());
            Logs.LogComReflection.Gravar(carros.Clone());

            Logs.LogComReflection.ApresentarLog();
            Console.WriteLine("Log Gravado");
            Console.ReadKey();
        }
    }
}
