using ReportCommander.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportCommander.Core.Entities;

[Table("AuditRecord")]
public class AuditRecord : BaseEntity
{
  public string EntityType { get; set; } = "";

  public int EntityId { get; set; }

  public int VersionNumber { get; set; }

  public string VersionData { get; set; } = "";

}
