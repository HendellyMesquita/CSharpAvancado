namespace _00_Biblioteca
{
    public class Carros : ICloneable
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public object Clone()
        {

            return new Carros()
            {
               Marca = this.Marca,
               Modelo = this.Modelo
            };
        }
    }
}
