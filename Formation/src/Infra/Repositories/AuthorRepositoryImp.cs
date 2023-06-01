using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories;
public class AuthorRepositoryImp : AbstractRepositoryImp, AuthorRepository
{
    public class AuthorRepositoryImp : AbstractRepositoryImp, AuthorRepository
    {
        public AuthorRepositoryImp(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public Task<int> AddAuthor(AuthorDto author)
        {
            throw new NotImplementedException();
        } 

        public async Task<IEnumerable<AuthorDto>> GetAll()
        {
            var authors = _context.Authors.AsEnumerable();
            return _mapper.Map<IEnumerable<AuthorDto>>(authors);
        }
    }

    public Task<int> AddAuthor(AuthorDto author)
    {
        throw new NotImplementedException();
    }
}
