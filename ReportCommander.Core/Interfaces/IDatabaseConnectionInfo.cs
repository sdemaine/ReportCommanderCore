namespace ReportCommander.Core.Interfaces;

public interface IDatabaseConnectionInfo
{
  string ConnectionName { get; set; }
  string ConnectionString { get; }
  string DatabaseName { get; set; }
  string Password { get; set; }
  string ServerName { get; set; }
  string TrustedConnectionString { get; }
  string UserName { get; set; }
}
