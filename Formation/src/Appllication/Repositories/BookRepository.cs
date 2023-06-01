namespace Appllication.Repositories
{
    public interface BookRepository
    {
        Task<int> AddBook(BookDto book);
        Task<BookDto> GetOne(int id);
    }
}
