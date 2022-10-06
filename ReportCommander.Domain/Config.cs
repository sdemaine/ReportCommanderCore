using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using ReportCommander.Core;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportCommander.Core.Interfaces;
//using ReportCommander.SharedKernel;
//using ReportCommander.SharedKernel.Interfaces;

namespace ReportCommander.Core.Entities;

//public class PersistentConfiguration : IEntityTypeConfiguration<PersistentObject>
//{
//  public void Configure(EntityTypeBuilder<PersistentObject> builder)
//  {
//    //builder.Property(t => t.CreatedDate).HasDefaultValueSql("GetDate()");
//  }
//}

//public class ConfigConfiguration : IEntityTypeConfiguration<Config>
//{
//  public void Configure(EntityTypeBuilder<Config> builder)
//  {
//    builder.Property(x => x.Name)
//        .IsRequired()
//        .HasMaxLength(200);

//    builder.Property(x => x.Description)
//        .HasMaxLength(250);

//    //builder.Property(t => t.CreatedDate).HasDefaultValueSql("GetDate()");

//  }
//}

[Table("Configs")]
public class Config : BaseEntity // EntityBase, IAggregateRoot
{

  public static readonly Expression<Func<Config, bool>> IsForFMR =
    x => x.Name.ToLower().Contains("fmr");

  public ICollection<DeliveryConfig> DeliveryConfigs { get; set; } = new List<DeliveryConfig>();

  public string Name { get; set; } = "";

  public string Description { get; set; } = "";

  public int ReportOwnerUserID { get; set; } = 0;

  public bool SkipWhenEmpty { get; set; }


  // DATA OPTIONS

  public int DatabaseConnectionId { get; set; }

  public virtual DatabaseConnection DatabaseConnection { get; set; } = new DatabaseConnection();

  [MaxLength(1000)]
  public string StoredProcedureName { get; set; } = "";

  [MaxLength(4000)]
  public string ParameterList { get; set; } = "";

  public int CommandTimeout { get; set; } = 0;

  public string? Filename { get; set; }

  public byte[]? XtraReport { get; set; }

  public virtual List<ParameterQuery> ParameterQueries { get; set; } = new List<ParameterQuery>();

}
