
namespace Appllication.Author
{

    public record GetAllAuthorsQuery() : IRequest<IEnumerable<AuthorDto>>
    {
    }

    public class GetAllAuthorsQueryHandler : IRequestHandler<GetAllAuthorsQuery, IEnumerable<AuthorDto>>
    {
        private readonly AuthorRepository _authorRepository;
        public GetAllAuthorsQueryHandler(AuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public async Task<IEnumerable<AuthorDto>> Handle(GetAllAuthorsQuery request, CancellationToken cancellationToken)
        {
            return await _authorRepository.GetAll();
        }

       
    }
 
}
