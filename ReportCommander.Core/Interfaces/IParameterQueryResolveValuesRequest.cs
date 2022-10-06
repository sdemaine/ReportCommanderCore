namespace ReportCommander.Core.Interfaces;

public interface IParameterQueryResolveValuesRequest
{
  int ConfigId { get; set; }

  string ParameterName { get; set; }

  string ParameterValues { get; set; }
}
