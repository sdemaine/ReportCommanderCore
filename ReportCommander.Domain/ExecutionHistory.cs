using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("ExecutionHistory")]
  public class ExecutionHistory : BaseEntity
{
      //public int DeliveryId { get; set; }

      public int QueueId { get; set; }

      public virtual Queue Queue { get; set; } = new Queue();

      public DateTime ExecutionDate { get; set; }

  }
