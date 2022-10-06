using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("DeliveryEmailRecipients")]
public class DeliveryEmailRecipient : BaseEntity
{

  public int DeliveryId { get; set; }

  public virtual Delivery Delivery { get; set; } = new Delivery();

  public int EmailRecipientId { get; set; }

  public virtual EmailRecipient EmailRecipient { get; set; } = new EmailRecipient();

}
