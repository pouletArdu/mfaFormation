using Infra.Repositories;
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
            throw new NotImplementedException();
        }
    }
}
