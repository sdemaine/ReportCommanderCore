using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("ConfigDepartmentAssignments")]
public class ConfigDepartmentAssignment : BaseEntity
{

  public int ConfigId { get; set; }

  public virtual Config? Config { get; set; }

  public int DepartmentId { get; set; }

  public virtual Department? Department { get; set; }

}

