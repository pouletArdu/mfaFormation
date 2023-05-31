namespace Domain.Models
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
