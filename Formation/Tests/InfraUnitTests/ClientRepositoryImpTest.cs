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
            
        }

        [Fact]
        public void ShouldAddClient()
        {
            var client = new ClientDto()
            {
                LastName = "Test",
                Email = "toto@ss.toto",
                FirstName = "Test"
            };


            var result = _repository.Add(client);

            Assert.True(result.Result > 0);

            _dbContext.Clients.CountAsync().Result.Should().Be(1);
        }

    }
}
