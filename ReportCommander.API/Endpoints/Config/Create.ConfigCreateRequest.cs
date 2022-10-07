using System.ComponentModel.DataAnnotations;

namespace ReportCommander.API.Endpoints;

public class ConfigCreateRequest
{
    [MaxLength(5)]
    public string Name { get; set; } = "";

    public string Description { get; set; } = "";

    public bool SkipWhenEmpty { get; set; }

    public int DatabaseConnectionId { get; set; }

    

    [MaxLength(1000)]
    public string StoredProcedureName { get; set; } = "";

    [MaxLength(4000)]
    public string ParameterList { get; set; } = "";

    public int CommandTimeout { get; set; } = 0;

    public string? Filename { get; set; }

    public byte[]? XtraReport { get; set; }
}
