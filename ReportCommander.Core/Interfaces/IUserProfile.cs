namespace ReportCommander.Core.Interfaces;

public interface IUserProfile
{
  public int UserID { get; set; }

  public bool IsAdmin { get; set; }

  public string FirstName { get; set; }

  public string LastName { get; set; }

  public bool DarkModeEnabled { get; set; }

  public string? EmailAddress { get; set; }

  public byte[]? ProfilePhoto { get; set; }
}
