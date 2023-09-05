using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Biblioteca
{
    public class ValidacaoCustomizada : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (((string)value).Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
