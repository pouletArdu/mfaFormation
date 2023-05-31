using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class BookRepositoryImp : BookRepository
    {
        public Task<int> AddBook(BookDto book)
        {
            throw new NotImplementedException();
        }
    }
}
