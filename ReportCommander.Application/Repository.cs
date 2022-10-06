using ReportCommander.Core;
using ReportCommander.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ReportCommander.Core.Entities;
using ReportCommander.Core.Interfaces;
using System.Linq.Expressions;

namespace ReportCommander.Application;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly IApplicationDbContext _context;

    public Repository(IApplicationDbContext context)
    {
        _context = context;
    }

    //IUserProfile IRepository<TEntity>.UserProfile => new UserProfile()
    //{
    //    Id = 100,
    //    FirstName = "Stephen",
    //    LastName = "Demaine",
    //    CreatedByUserId = 0,
    //    CreatedDate = DateTime.Now,
    //    DarkModeEnabled = true,
    //    EmailAddress = "sdemaine@spragueenergy.com",
    //    IsAdmin = true,
    //    UserID = 100
    //};

    public void Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
    }

    public void AddRange(IEnumerable<TEntity> entities)
    {
        foreach(var entity in entities)
        {
            entity.CreatedDate = DateTime.Now;
            entity.CreatedByUserId = _context.UserProfile.UserID;
        }

        _context.Set<TEntity>().AddRange(entities);
    }

    public bool Contains(ISpecification<TEntity> specification = null)
    {
        return Count(specification) > 0 ? true : false;
    }

    public bool Contains(Expression<Func<TEntity, bool>> predicate)
    {
        return Count(predicate) > 0 ? true : false;
    }

    public int Count(ISpecification<TEntity> specification = null)
    {
        return ApplySpecification(specification).Count();
    }

    public int Count(Expression<Func<TEntity, bool>> predicate)
    {
        return _context.Set<TEntity>().Where(predicate).Count();
    }

    public IEnumerable<TEntity> Find(ISpecification<TEntity> specification = null)
    {
        return ApplySpecification(specification);
    }

    public TEntity FindById(int id)
    {
        return _context.Set<TEntity>().Find(id);
    }

    public TEntity? FindById(int id, string[] includes)
    {
        IQueryable<TEntity> entityQuery = _context.Set<TEntity>();

        foreach (var include in includes)
        {
            entityQuery = entityQuery.Include(include);
        }

        return entityQuery.FirstOrDefault(x => x.Id == id);
    }

    public ICollection<TEntity> GetListFromRequestDto(RequestDto requestDto)
    {
        throw new NotImplementedException();
    }

    public void Remove(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _context.Set<TEntity>().RemoveRange(entities);
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        _context.Entry(entity).Property("UpdatedDate").CurrentValue = DateTime.Now;
        _context.Entry(entity).Property("UpdatedByUserId").CurrentValue = _context.UserProfile.UserID;

    }

    private IQueryable<TEntity> ApplySpecification(ISpecification<TEntity> spec)
    {
        return SpecificationEvaluator<TEntity>.GetQuery(_context.Set<TEntity>().AsQueryable(), spec);
    }
}
