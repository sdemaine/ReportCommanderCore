using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ReportCommander.Core.Entities;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Infrastructure
{
    public interface IApplicationDbContext
    {
        IUserProfile UserProfile { get; }

        DbSet<AuditRecord> AuditRecords { get; set; }
        DbSet<ConfigDepartmentAssignment> ConfigDepartmentAssignments { get; set; }
        DbSet<Config> Configs { get; set; }
        DbSet<ConfigUserAssignment> ConfigUserAssignments { get; set; }
        DbSet<DatabaseConnection> DatabaseConnections { get; set; }
        DbSet<Delivery> Deliveries { get; set; }
        DbSet<DeliveryConfig> DeliveryConfigs { get; set; }
        DbSet<DeliveryEmailRecipient> DeliveryEmailRecipients { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<EmailRecipient> EmailRecipients { get; set; }
        DbSet<ExecutionHistory> ExecutionHistory { get; set; }
        DbSet<Note> Notes { get; set; }
        DbSet<OutputHistory> OutputHistory { get; set; }
        DbSet<ParameterQuery> ParameterQueries { get; set; }
        DbSet<Queue> Queue { get; set; }
        DbSet<Schedule> Schedules { get; set; }
        DbSet<UserDepartmentAssignment> UserDepartmentAssignments { get; set; }
        DbSet<UserProfile> UserProfiles { get; set; }

        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));


        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet<TEntity> Set<TEntity>(string name) where TEntity : class;

        EntityEntry Entry(object entity);

        void Dispose();
    }
}