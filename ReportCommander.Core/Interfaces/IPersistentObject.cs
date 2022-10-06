namespace ReportCommander.Core.Interfaces;

public interface IPersistentObject
{
  void Save(IUserProfile userProfile);

  int CreatedByUserId { get; set; }
  DateTime CreatedDate { get; set; }
  int Id { get; set; }
  bool IsDeleted { get; set; }
  int? UpdatedByUserId { get; set; }
  DateTime? UpdatedDate { get; set; }
}
