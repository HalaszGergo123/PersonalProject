namespace WebAPI.Models
{
    public class BookModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Page { get; set; }
        public string AuthorName { get; set; }
    }
}
