using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("Deliveries")]
  public class Delivery : BaseEntity
{
      public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

      public ICollection<DeliveryConfig>? DeliveryConfigs { get; set; }

      public string? Name { get; set; }

      public string? Description { get; set; }
      
      // EMAIL OPTIONS

      public string? MailHost { get; set; }

      public string? SubjectLine { get; set; }

      public string? SenderEmailAddress { get; set; }

      public string? RecipientEmailAddressList { get; set; } = "";


      public string? BlankReportEmailRecipient { get; set; }

      public bool RenderInBody { get; set; }

      public bool HighPriority { get; set; }

      public string? EmailAttachmentMessage { get; set; }

      public int EmailBodyRowCountLimit { get; set; } = 100;

      public string? EmailDescription { get; set; }

      public string? EmailTemplate { get; set; }


      // BODY OPTIONS

      public string? RowColorList { get; set; }

      public bool ShowHeaders { get; set; }

      public bool FreezeTopRow { get; set; }



      // FILESYSTEM OPTIONS

      public string? OutputFolder { get; set; }

      //public string? Filename { get; set; }


      // EXCEL FILE

      public bool EmailExcelFile { get; set; }

      public bool SaveExcelFile { get; set; }



      // DELIMITED FILE

      public bool EmailDelimitedFile { get; set; }

      public bool SaveDelimitedFile { get; set; }

      public string? Delimiter { get; set; }



      // XTRA REPORTS

      public bool SaveXtraReport { get; set; }

      public string? XtraReportParameters { get; set; }

      public bool EmailXtraReport { get; set; }


      // FTP OPTIONS

      public bool SendFTP { get; set; }

      public bool SecureFTP { get; set; }

      public string? FTPHost { get; set; }

      public string? FTPUsername { get; set; }

      public string? FTPPassword { get; set; }

      public string? FTPDestinationFolder { get; set; }

      public string? SSHFingerprint { get; set; }
  }
