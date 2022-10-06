using ReportCommander.Core;
using ReportCommander.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportCommander.Core.Entities;

  [Table("ParameterQueries")]
  public class ParameterQuery : BaseEntity
{
      public int ConfigId { get; set; }

      public Config Config { get; set; } = new Config();

      public string ParameterName { get; set; } = "";

      public string Query { get; set; } = "";

      public string ValueField { get; set; } = "";

      public string DisplayField { get; set; } = "";
  }
