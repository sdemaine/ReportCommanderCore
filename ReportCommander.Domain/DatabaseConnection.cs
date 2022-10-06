using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("DatabaseConnections")]
public class DatabaseConnection : BaseEntity
{
  public string ConnectionName { get; set; } = "";

  public string DatabaseServer { get; set; } = "";

  public string DatabaseName { get; set; } = "";

  public string SqlUsername { get; set; } = "";

  public string SqlPassword { get; set; } = "";

  public string GetSqlConnectionString()
  {
    return $"Data Source={DatabaseServer};Initial Catalog={DatabaseName};User ID={SqlUsername};Password={SqlPassword}";
  }
}
