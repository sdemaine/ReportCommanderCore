using ReportCommander.Core;

namespace ReportCommander.Application;

public interface IUnitOfWork : IDisposable
{
    IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
    int Complete();

    Task<int> CompleteAsync(CancellationToken cancellationToken);
}
