using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("Notes")]
  public class Note : BaseEntity
{
      public string Content { get; set; } = "";

  }
