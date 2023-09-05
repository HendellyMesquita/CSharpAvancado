using _00_Biblioteca;

namespace _06_Delegates
{
    public class ServicoDelegatesCalcular
    {
      
        delegate int Calcular(int a, int b);

        public void Calculadora(int a, int b)
        {

            Console.WriteLine($"Valores para calculo: {a}, {b}");

            Calcular somar = new Calcular(Somar);
            var somarCalc = somar(a, b);
            Console.WriteLine($"Somar: {somarCalc}");

            Calcular subitrair = new Calcular(Subitrair);
            var subitrairCalc = subitrair(b, a);
            Console.WriteLine($"Subitrair: {subitrairCalc}");

            Calcular multiplicar = new Calcular(Multiplicar);
            var multiplicarCalc = multiplicar(a, b);
            Console.WriteLine($"Multiplicar: {multiplicarCalc}");

            Calcular dividir = new Calcular(Dividir);
            var dividirCalc = dividir(b, a);
            Console.WriteLine($"Dividir: {dividirCalc}");

        }

        public  int Somar(int a, int b)
        {
            return a + b;
        }

        public  int Subitrair(int a, int b)
        {
            return a - b;
        }

        public  int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public  int Dividir(int a, int b)
        {
            return a / b;
        }

    }
}
