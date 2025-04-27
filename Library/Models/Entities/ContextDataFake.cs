
namespace Library.Models.Entities
{
    public static class ContextDataFake
    {
        public static List<BookDTO> List = null;

        static ContextDataFake()
        {
            List = new List<BookDTO>();
            InitializeData();
        }

        private static void InitializeData()
        {
            var book = new BookDTO() { Name = "Inicialização em Python 3", Author = "João das Cove", Publisher = "New House Publisher" };
            List.Add(book);

            book = new BookDTO() { Name = "Csharp for beginners", Author = "Thiago TH", Publisher = "Casa de Livros" };
            List.Add(book);

            book = new BookDTO() { Name = "POO Curso em Video", Author = "Guanabara", Publisher = "Curso em video" };
            List.Add(book);

            book = new BookDTO() { Name = "Clean Code", Author = "Fulaninho", Publisher = "Nunca nem vi" };
            List.Add(book);

            book = new BookDTO() { Name = ".Net Core", Author = "Nelio Alves", Publisher = "Udemy" };
            List.Add(book);
        }
    }
}
