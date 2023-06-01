using Domain.Models;
using FluentAssertions;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InfraUnitTests
{
    public class ClientRepositoryImpTest : Testing, IDisposable
    {
        ClientRepositoryImp _repository;
        public ClientRepositoryImpTest():base()
        {
            _repository = new ClientRepositoryImp(_dbContext, _mapper);
        }

        public void Dispose()
        {
            _dbContext.Database.ExecuteSqlRaw("DELETE FROM Clients");
            _dbContext.SaveChanges();
        }

        [Fact]
        public async Task ShouldAddClient()
        {
            var client = new ClientDto()
            {
                LastName = "Test",
                Email = "toto@ss.toto",
                FirstName = "Test"
            };

            var result = await _repository.Add(client);

            Assert.True(result > 0);

            _dbContext.Clients.Count().Should().Be(1);
        }

        [Fact]
        public async Task ShouldAddClient1()
        {
            var client = new ClientDto()
            {
                LastName = "Test1",
                Email = "toto@ss.toto",
                FirstName = "Test"
            };


            var result = await _repository.Add(client);

            Assert.True(result > 0);

            _dbContext.Clients.Count().Should().Be(1);
        }

        [Theory]
        [InlineData(1)]
        public async Task ShouldRemoveClient1WhenClientExist(int id)
        {
            //var entity = _dbContext.Client.FindAsync(1);
            throw NotImplementedException();
        }

    }
}
