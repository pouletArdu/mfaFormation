
using Appllication.Repositories;

namespace Application.ValidationTest.Mocks
{
    public class AuthorRepositoryMock : AuthorRepository
    {
        public static List<AuthorDto> Authors { get; set; } = new List<AuthorDto>();

        public async Task<int> AddAuthor(AuthorDto author)
        {
            await Task.Yield();
            author.Id = Authors.Count + 1;
            Authors.Add(author);
            return author.Id;
        }
        public static void Dispose()=> Authors.Clear();

        public Task<IEnumerable<AuthorDto>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
