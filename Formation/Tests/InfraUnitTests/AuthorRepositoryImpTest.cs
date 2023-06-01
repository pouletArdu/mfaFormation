using Domain.Models;
using Infra.Entities;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraUnitTests
{
    public class AuthorRepositoryImpTest : Testing, IDisposable
    {
        AuthorRepositoryImp _repository;
        public AuthorRepositoryImpTest() : base()
        {
            _repository = new AuthorRepositoryImp(_dbContext, _mapper);
        }
        public void Dispose()
        { 
            var authors = _dbContext.Authors.ToList();
            _dbContext.Authors.RemoveRange(authors);
            _dbContext.SaveChanges();
        }

        [Fact]
        public async Task ShouldGetAll()
        {
            // Arrange
            var authors = new List<Author>{ new Author
            {
                FirstName = "Test",
                LastName = "Test",
                BirthDate = DateTime.Now
            },
                new Author
            {
                FirstName = "Test1",
                LastName = "Test1",
                BirthDate = DateTime.Now
            }};
            await _dbContext.Authors.AddRangeAsync(authors);
            _dbContext.SaveChanges();

            // Act
            var result = await _repository.GetAll();

            // Assert
            Assert.True(result.Count() > 0);
            _dbContext.Authors.Count().Should().Be(authors.Count());
        }
    }
}
