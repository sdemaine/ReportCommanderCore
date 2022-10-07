using ReportCommander.Core;
using ReportCommander.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportCommander.Core.Entities;

[Table("UserProfiles")]
public class UserProfile : BaseEntity, IUserProfile
{
    public int UserID { get; set; }

    public bool IsAdmin { get; set; }

    public string FirstName { get; set; } = String.Empty;

    public string LastName { get; set; } = String.Empty;

    public bool DarkModeEnabled { get; set; }

    public string? EmailAddress { get; set; }

    public byte[]? ProfilePhoto { get; set; }

    public string SpragueLogin { get; set; }

}
