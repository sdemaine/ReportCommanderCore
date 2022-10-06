namespace ReportCommander.Core.Interfaces;

public interface IUserProfileDTO
  {
      bool IsValid();

      bool DarkModeEnabled { get; set; }
      int Id { get; set; }
      bool IsAdmin { get; set; }
      int UserID { get; set; }
  }
