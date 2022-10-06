namespace ReportCommander.Core;

public class RequestDto
{
    public bool LoadChildren { get; set; }

    public bool IsPagingEnabled { get; set; }

    public int PageIndex { get; set; }

    public int PageSize { get; set; }

    public bool GetAll { get; set; }

    public bool ActiveOnly { get; set; } = false;



    public int DeliveryId { get; set; }

    public int UserId { get; set; }

    public string? SearchString { get; set; }
}
