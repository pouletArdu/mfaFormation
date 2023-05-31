using AutoMapper;
using Infra.Persitence;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace InfraUnitTests
{
    public class Testing
    {
        protected ApplicationDbContext _dbContext;
        protected IMapper _mapper;
        public Testing()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite(connection)
                .Options;
            _dbContext = new ApplicationDbContext(options);

            _mapper = CreateMapper();
        }

        private IMapper CreateMapper()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Infra.Mapping.MappingProfile>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
