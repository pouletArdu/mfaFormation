using Domain.Models;
using FluentAssertions;
using Infra.Entities;
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

        [Fact]
        public async Task ShouldReturnEmptyListWhenNoClient()
        {
            var result = await _repository.GetAll();

            result.Should().HaveCount(0);
        }

        [Fact]
        public async Task ShouldReturnAllClientsWhenClientsExist()
        {
            var clients = new ClientDto[]
            {
                new ClientDto { FirstName = "John", LastName = "Doe", Email = "john.doe@aol.com" },
                new ClientDto { FirstName = "Jane", LastName = "Doe", Email = "jane.doe@aol.com" },
                new ClientDto { FirstName = "John", LastName = "Smith", Email = "john.smith@aol.com" }
            };

            foreach(var client in clients)
            {
                await _repository.Add(client);
            }

            var result = await _repository.GetAll();
            result.Should().HaveCount(clients.Length);
        }

    }
}
