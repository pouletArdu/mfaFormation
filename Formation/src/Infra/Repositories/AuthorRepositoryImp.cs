using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class AuthorRepositoryImp : AbstractRepositoryImp, AuthorRepository
    {

        public AuthorRepositoryImp(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<int> AddAuthor(AuthorDto author)
        {
            var authorEntity = _mapper.Map<Author>(author);
            var existAuthor = await _context.Authors.FindAsync(author.Id);
            if (existAuthor != null)
            {
                throw new Appllication.Commons.Exceptions.NotFoundException();
            }
            _context.Authors.Add(authorEntity);
            return await _context.SaveChangesAsync();
        }


    }
}
