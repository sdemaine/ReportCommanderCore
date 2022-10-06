namespace ReportCommander.Core.Interfaces;

public interface IParameterQueryDto
{
  int Id { get; set; }
  string ParameterName { get; set; }
  string Query { get; set; }
  int ReportScheduleId { get; set; }
}
