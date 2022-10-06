namespace ReportCommander.Application.Dtos;

public class UserProfileDto
{
    public int UserID { get; set; }

    public bool IsAdmin { get; set; }

    public string FirstName { get; set; } = String.Empty;

    public string LastName { get; set; } = String.Empty;

    public bool DarkModeEnabled { get; set; }

    public string? EmailAddress { get; set; }

    public byte[]? ProfilePhoto { get; set; }
}
