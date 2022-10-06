using ReportCommander.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ReportCommander.Core.Entities;
using ReportCommander.Core.Interfaces;
using System.IO;

namespace ReportCommander.Infrastructure
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public IUserProfile UserProfile;

        private Action<object> p;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            //this.UserProfile = new UserProfile()
            //{
            //    Id = 1,
            //    CreatedByUserId = 0,
            //    CreatedDate = DateTime.Now,
            //    DarkModeEnabled = true,
            //    FirstName = "Stephen",
            //    LastName = "Demaine",
            //    EmailAddress = "sdemaine@spragueenergy.com",
            //    IsAdmin = true,
            //    UserID = 100
            //};
        }

        public ApplicationDbContext(Action<object> p)
        {
            this.p = p;
        }



        public virtual DbSet<AuditRecord> AuditRecords { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<ConfigDepartmentAssignment> ConfigDepartmentAssignments { get; set; }
        public virtual DbSet<ConfigUserAssignment> ConfigUserAssignments { get; set; }
        public virtual DbSet<DatabaseConnection> DatabaseConnections { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<DeliveryConfig> DeliveryConfigs { get; set; }
        public virtual DbSet<DeliveryEmailRecipient> DeliveryEmailRecipients { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EmailRecipient> EmailRecipients { get; set; }
        public virtual DbSet<ExecutionHistory> ExecutionHistory { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<OutputHistory> OutputHistory { get; set; }
        public virtual DbSet<ParameterQuery> ParameterQueries { get; set; }
        public virtual DbSet<Queue> Queue { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        //public virtual DbSet<StoredProcedureParameter> StoredProcedureParameters { get; set; }
        public virtual DbSet<UserDepartmentAssignment> UserDepartmentAssignments { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }

        IUserProfile IApplicationDbContext.UserProfile => new UserProfile()
        {
            Id = 1,
            CreatedByUserId = 0,
            CreatedDate = DateTime.Now,
            DarkModeEnabled = true,
            FirstName = "Stephen",
            LastName = "Demaine",
            EmailAddress = "sdemaine@spragueenergy.com",
            IsAdmin = true,
            UserID = 100
        };
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();


            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = $"Data Source=.\\SQL2019;Initial Catalog=ReportCommanderDB;Integrated Security=True";
            builder.UseSqlServer(connectionString);
            return new ApplicationDbContext(builder.Options);
        }
    }
}
