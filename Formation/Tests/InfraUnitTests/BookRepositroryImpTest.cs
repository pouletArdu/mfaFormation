using Domain.Models;
using Infra.Entities;
using Infra.Repositories;

namespace InfraUnitTests
{
    public class BookRepositroryImpTest : Testing, IDisposable
    {
        BookRepositoryImp _repository;
        public BookRepositroryImpTest() : base()
        {
            _repository = new BookRepositoryImp(_dbContext,_mapper);
        }
        public void Dispose()
        {

            var books = _dbContext.Books.ToList();
            _dbContext.Books.RemoveRange(books);
            _dbContext.SaveChanges();

            var authors = _dbContext.Authors.ToList();
            _dbContext.Authors.RemoveRange(authors);
            _dbContext.SaveChanges();
        }

        [Fact]
        public async Task ShouldAddBook()
        {
            var author = new Author
            {
                FirstName = "Test",
                LastName = "Test",
                BirthDate = DateTime.Now
            };

            _dbContext.Authors.Add(author);
            await _dbContext.SaveChangesAsync();

            var book = new BookDto()
            {
                Title = "Test",
                AuthorId = author.Id,
                Description = "Test",
                PublicationDate = DateTime.Now
            };

            var result = await _repository.AddBook(book);
            Assert.True(result > 0);
            _dbContext.Books.Count().Should().Be(1);
        }
    }
}
