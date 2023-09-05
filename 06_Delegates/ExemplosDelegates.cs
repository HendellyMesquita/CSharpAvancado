using _00_Biblioteca;

namespace _06_Delegates
{
    public class ExemplosDelegates
    {


        ServicoDelegatesCalcular _servicoDelegatesCalcular = new ServicoDelegatesCalcular();
        ServicoDelegatesFotografia _servicoDelegatesFotografia = new ServicoDelegatesFotografia();
        public void DelegatesIntroducao()
        {
            var a = 10; var b = 20;

            _servicoDelegatesCalcular.Calculadora(a, b);
            Console.ReadKey();
        }

        public void DelegatesExemploFotografia()
        {
            var fotoPerfil = new Fotos { Nome = "LuzArtigosDecoração.pmg", TamanhoX = 1920, TamanhoY = 1080, };
            var fotoProduto = new Fotos { Nome = "Luminaria.pmg", TamanhoX = 1920, TamanhoY = 1080, };
            var fotoAlbum = new Fotos { Nome = "Album.pmg", TamanhoX = 1920, TamanhoY = 1080, };

            ServicoDelegatesFotografia.filtros = new ServicoDelegatesFotografia().MsgGerarThumb;
            _servicoDelegatesFotografia.ProcessarFoto(fotoPerfil);

            ServicoDelegatesFotografia.filtros = new ServicoDelegatesFotografia().MsgColorirFoto;
            ServicoDelegatesFotografia.filtros += new ServicoDelegatesFotografia().MsgRedimencionar;
            _servicoDelegatesFotografia.ProcessarFoto(fotoProduto);

            ServicoDelegatesFotografia.filtros = new ServicoDelegatesFotografia().MsgPretoEBranco;
            _servicoDelegatesFotografia.ProcessarFoto(fotoAlbum);

            Console.ReadKey();
        }
    }
}
