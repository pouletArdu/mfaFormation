namespace Infra.Repositories;

public abstract class AbstractRepositoryImp
{
    protected readonly ApplicationDbContext _context;
    protected readonly IMapper _mapper;

    public AbstractRepositoryImp(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

}
