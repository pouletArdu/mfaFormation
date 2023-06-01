using Domain.Models;
using Infra.Repositories;

namespace InfraUnitTests
{
    public class AuthorRepositoryImpTest : Testing, IDisposable
    {

        AuthorRepositoryImp _repository;

        public AuthorRepositoryImpTest() : base(){

            _repository = new AuthorRepositoryImp(_dbContext, _mapper);

        }

        public void Dispose()
        {
             var authors = _dbContext.Authors.ToList();
            _dbContext.Authors.RemoveRange(authors);
            _dbContext.SaveChanges();
        }

        [Fact]
        public async void ShouldAddAuthor()
        {

            var author = new AuthorDto {
                FirstName = "Pablo",
                LastName = "Cuelo",
                BirthDate = new DateTime(1947,8,24)
            };
            
            var result = await _repository.AddAuthor(author);

            Assert.True(result > 0);
        }

        
    }
}