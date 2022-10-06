using ReportCommander.Core;
using ReportCommander.Infrastructure;
using System.Collections;

namespace ReportCommander.Application;

public class UnitOfWork : IUnitOfWork
{
    private readonly IApplicationDbContext _context;
    public readonly IConfigRepository configRepository;
    private Hashtable _repositories;

    public IConfigRepository ConfigRepository { get => configRepository; }

    public UnitOfWork(IApplicationDbContext context, IConfigRepository configRepository)
    {
        _context = context;
        this.configRepository = configRepository;
    }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public Task<int> CompleteAsync(CancellationToken cancellationToken)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }

    public IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
    {
        if (_repositories == null)
            _repositories = new Hashtable();

        var type = typeof(TEntity).Name;

        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(Repository<>);

            var repositoryInstance =
                Activator.CreateInstance(repositoryType
                    .MakeGenericType(typeof(TEntity)), _context);

            _repositories.Add(type, repositoryInstance);
        }

        return (IRepository<TEntity>)_repositories[type];
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
