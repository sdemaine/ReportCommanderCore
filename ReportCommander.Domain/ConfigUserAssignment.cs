using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("ConfigUserAssignments")]
public class ConfigUserAssignment : BaseEntity
{

  public int ConfigId { get; set; }

  public virtual Config? Config { get; set; }

  public int UserProfileId { get; set; }

  public virtual UserProfile? UserProfile { get; set; }

}

