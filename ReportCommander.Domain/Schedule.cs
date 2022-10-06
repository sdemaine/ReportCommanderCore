using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("Schedules")]
public class Schedule : BaseEntity
{
  public int DeliveryId { get; set; }

  public virtual Delivery? Delivery { get; set; }

  public DateTime? LastExecutionTimeStamp { get; set; }

  public string DynamicDate { get; set; } = String.Empty;

  public string ScheduleTime { get; set; } = String.Empty;

  public bool RunOnMonday { get; set; }

  public bool RunOnTuesday { get; set; }

  public bool RunOnWednesday { get; set; }

  public bool RunOnThursday { get; set; }

  public bool RunOnFriday { get; set; }

  public bool RunOnSaturday { get; set; }

  public bool RunOnSunday { get; set; }

  public bool IsActive { get; set; }
}
