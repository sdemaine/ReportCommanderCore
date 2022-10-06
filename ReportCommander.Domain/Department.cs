using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("Departments")]
public class Department : BaseEntity
{
  public string Name { get; set; } = string.Empty;

}
