using ReportCommander.Core;
using ReportCommander.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportCommander.Core.Entities;

  [Table("EmailRecipients")]
  public class EmailRecipient : BaseEntity
{
      public string Name { get; set; } = "";

      public string EmailAddress { get; set; } = "";

      public bool IsDistributionGroup { get; set; }
  }
