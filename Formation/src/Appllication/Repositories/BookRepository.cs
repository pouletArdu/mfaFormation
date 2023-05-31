namespace Appllication.Repositories
{
    public interface BookRepository
    {
        Task<int> AddBook(BookDto book);
       
    }
}
