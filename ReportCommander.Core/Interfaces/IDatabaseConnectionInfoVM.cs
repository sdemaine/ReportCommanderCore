using System;
using System.Linq;

namespace ReportCommander.Core.Interfaces
{
    public interface IDatabaseConnectionInfoVM
    {
        string ConnectionName { get; set; }
        string DatabaseName { get; set; }
        string ServerName { get; set; }
        string UserName { get; set; }
    }
}
