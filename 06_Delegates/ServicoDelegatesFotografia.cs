using _00_Biblioteca;

namespace _06_Delegates
{
    public class ServicoDelegatesFotografia
    {
        public delegate void FotoFiltroHandler(Fotos foto);
        public static FotoFiltroHandler filtros;

        public void ProcessarFoto(Fotos foto)
        {
            filtros(foto);
        }

        public  void MsgColorirFoto(Fotos foto)
        {
            Console.WriteLine($"FotoFoltro > Colorir {foto.Nome} ");
        }
        
        public  void MsgGerarThumb(Fotos foto)
        {
            Console.WriteLine($"FotoFoltro > Gerar Thumb {foto.Nome} ");
        }
        
        public  void MsgPretoEBranco(Fotos foto)
        {
            Console.WriteLine($"FotoFoltro > Preto e Branco {foto.Nome} ");
        }
        
        public  void MsgRedimencionar(Fotos foto)
        {
            Console.WriteLine($"FotoFoltro > Redimencionar {foto.Nome} ");
        }


    }
}
