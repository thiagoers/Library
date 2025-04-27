namespace Library.Models.Entities
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public BookDTO()
        {

        }

        public BookDTO(int id, string name, string author, string publisher)
            :this(name, author, publisher)
        {
            this.Id = id;
        }

        public BookDTO(string name, string author, string publisher)
        {
            this.Name = name;
            this.Author = author;
            this.Publisher = publisher;
        }
    }
}
