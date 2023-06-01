
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

        public async Task<AuthorDto> GetOne(int id)
        {
            await Task.Yield();
            var author = new AuthorDto()
            {
                LastName = "Test",
                FirstName = "Test",
                BirthDate = DateTime.Now,
            };
            Authors.Add(author);
            return author;
        }

        public static void Dispose()=> Authors.Clear();
    }
}
