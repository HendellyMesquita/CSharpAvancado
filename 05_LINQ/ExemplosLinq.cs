using _00_Biblioteca;

namespace _05_LINQ
{
    public class ExemplosLinq
    {
        public void ExemploIntroducaoLINQ()
        {
            int[] lista = { 3, 48, 5, 1, 4, 5, 65, 7, 8, 10, 96 };

            var maioresQueDez = lista.Where(x => x >= 10).ToList();
            var OrdemCrescente = lista.OrderBy(x => x);
            var OrdemDecrescente = lista.OrderByDescending(x => x);

            Console.Write("Ordem Crescente: ");
            foreach (var x in OrdemCrescente)
            {
                Console.Write($"{x}, ");
            }

            Console.WriteLine();
            Console.Write("Ordem Decrescente: ");
            foreach (var x in OrdemDecrescente)
            {
                Console.Write($"{x}, ");
            }

            Console.WriteLine();
            Console.Write("Valores maiores que 10: ");
            foreach (var x in maioresQueDez)
            {
                Console.Write($"{x}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Metodo Alternativo");

            var AlternOrdemCrescente = from x in lista orderby x select x;

            Console.Write("Ordem Crescente V2: ");
            foreach (var x in AlternOrdemCrescente)
            {
                Console.Write($"{x}, ");
            }
            Console.ReadKey();

        }

        public void ExemploLINQComObtetos()
        {
            List<Usuarios> listaUsuario = new List<Usuarios>();

            listaUsuario.Add(new Usuarios() { Sexo = "M", Nome = "Luiz Pereira", Email = "LuizPereira@Hotmail.Com" });
            listaUsuario.Add(new Usuarios() { Sexo = "F", Nome = "Ana Maria", Email = "AnaMaria@Gmail.Com" });
            listaUsuario.Add(new Usuarios() { Sexo = "M", Nome = "Pedro Lucas", Email = "PedroLucas@Hotmail.Com" });
            listaUsuario.Add(new Usuarios() { Sexo = "F", Nome = "Luiza Maia", Email = "LuizaMaia@Gmail.Com" });
            listaUsuario.Add(new Usuarios() { Sexo = "M", Nome = "Claudio Bathista", Email = "ClaudioBathista@Hotmail.Com" });
            listaUsuario.Add(new Usuarios() { Sexo = "F", Nome = "Eduarda Gonçalves", Email = "EduardaGonçalves@Gmail.Com" });

            var ListaDeGmail = listaUsuario.Where(a => a.Email.Contains("@Gmail"))
                .OrderBy(x => x.Nome).Select(x => x.Nome);

            var ListaDeHomens = listaUsuario.Where(a => a.Sexo == "M");

            Console.WriteLine("Pessoas que Possuem Gmail");
            foreach (var item in ListaDeGmail)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine($"Quantidade de Homens Cadastrados: {ListaDeHomens}");
            foreach (var item in ListaDeHomens)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }

        public void ExemploLINQComJoin()
        {
            var listaAutor = new List<Autores>();
            var listaLivro = new List<Livros>();

            listaLivro.Add(new Livros() { Codigo = 1, AltorCodigo = 2, Titulo = "As Cronicas De Pedro" });
            listaLivro.Add(new Livros() { Codigo = 2, AltorCodigo = 2, Titulo = "Sete Passos Para Vida" });
            listaLivro.Add(new Livros() { Codigo = 3, AltorCodigo = 1, Titulo = "John & John" });
            listaLivro.Add(new Livros() { Codigo = 4, AltorCodigo = 3, Titulo = "Outro Dia Para Amar" });
            listaLivro.Add(new Livros() { Codigo = 5, AltorCodigo = 1, Titulo = "Tudo Sobre Esportes" });
            listaLivro.Add(new Livros() { Codigo = 6, AltorCodigo = 2, Titulo = "Porque Terra Planistas?" });
            listaLivro.Add(new Livros() { Codigo = 7, AltorCodigo = 3, Titulo = "Ultima Hora" });
            listaLivro.Add(new Livros() { Codigo = 8, AltorCodigo = 1, Titulo = "Mais Um Dia Sendo Eu" });
            listaLivro.Add(new Livros() { Codigo = 9, AltorCodigo = 3, Titulo = "Como Comprar BitCoins" });

            listaAutor.Add(new Autores() { Codigo = 1, Nome = "Luiz Pereira" });
            listaAutor.Add(new Autores() { Codigo = 2, Nome = "Ana Maria" });
            listaAutor.Add(new Autores() { Codigo = 3, Nome = "Pedro Lucas" });

            var listaJoin =
                from livros in listaLivro
                join autor in listaAutor on livros.AltorCodigo
                equals autor.Codigo
                select new { livros.Titulo, autor.Nome };

            foreach (var item in listaJoin)
            {
                Console.WriteLine($"Livro: {item.Titulo}, Autor: {item.Nome}");
            }

            Console.ReadKey();

        }

        public void ExemploLINQComGroup()
        {
            int[] listaNumerica = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 1, 2, 3, 4, 1, 2, 3, 4, 5, };

            var listaFiltradaDistinct = listaNumerica.Distinct();
            var listaFiltradaGroupBy = listaNumerica.GroupBy(a => a);

            Console.WriteLine("Lista de Dados: ");
            foreach (var item in listaNumerica) 
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            Console.WriteLine("Com Distinct: ");
            foreach (var item in listaFiltradaDistinct) 
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Com Group: ");

            foreach (var item in listaFiltradaGroupBy) 
            {
                Console.Write($"{item.Key}, ");
            }
            Console.ReadKey();
        }
    }
}
