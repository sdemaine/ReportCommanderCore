using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("Queue")]
public class Queue : BaseEntity
{
  public int ScheduleId { get; set; }

  public virtual Schedule Schedule { get; set; } = new Schedule();

  public bool IsProcessed { get; set; }

  public DateTime ProcessDate { get; set; }

}
