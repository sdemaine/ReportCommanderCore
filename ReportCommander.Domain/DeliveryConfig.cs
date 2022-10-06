using ReportCommander.Core;
using ReportCommander.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportCommander.Core.Entities;

[Table("DeliveryConfigs")]
public class DeliveryConfig : BaseEntity
{

  public int DeliveryId { get; set; }

  public virtual Delivery? Delivery { get; set; }

  public int ConfigId { get; set; }

  public virtual Config? Config { get; set; }

}

