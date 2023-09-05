using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Biblioteca
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    public class Atributos : Attribute
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Atributos(string nome)
        {
            Nome = nome;
        }
    }
}
