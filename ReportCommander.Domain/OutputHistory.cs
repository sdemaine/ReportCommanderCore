using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("OutputHistory")]
  public class OutputHistory : BaseEntity
{
      //public int DeliveryId { get; set; }
      public int ExecutionHistoryId { get; set; }

      public virtual ExecutionHistory ExecutionHistory { get; set; } = new ExecutionHistory();

      public string EmailAddress { get; set; } = "";

      public string OutputFolder { get; set; } = "";

      public string Filename { get; set; } = "";

      public bool IsEmail { get; set; }

      public bool IsPDF { get; set; }

      public bool IsCSV { get; set; }

      public bool IsFTP { get; set; }

      public string FtpRemoteDirectory { get; set; } = "";

      public string FtpHost { get; set; } = "";

      public string FtpUsername { get; set; } = "";

  }
