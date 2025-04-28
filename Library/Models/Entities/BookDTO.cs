namespace Library.Models.Entities
{
    public class BookDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public BookDTO()
        {
            Id = Guid.NewGuid().ToString();
        }

        public BookDTO(string name, string author, string publisher)
        {
            this.Name = name;
            this.Author = author;
            this.Publisher = publisher;
        }
    }
}
