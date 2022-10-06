namespace ReportCommander.Core.Interfaces;

public interface IReportScheduleForViewDto
{
  string BlankReportEmailRecipient { get; set; }
  int CommandTimeout { get; set; }
  string DatabaseName { get; set; }
  string DatabaseServer { get; set; }
  string Delimiter { get; set; }
  string EmailAttachmentMessage { get; set; }
  int EmailBodyRowCountLimit { get; set; }
  bool EmailDelimitedFile { get; set; }
  string EmailDescription { get; set; }
  bool EmailExcelFile { get; set; }
  string EmailTemplate { get; set; }
  bool EmailXtraReport { get; set; }
  string Filename { get; set; }
  bool FreezeTopRow { get; set; }
  string FTPDestinationFolder { get; set; }
  string FTPHost { get; set; }
  string FTPPassword { get; set; }
  string FTPUsername { get; set; }
  bool HighPriority { get; set; }
  int Id { get; set; }
  bool IsActive { get; set; }
  string MailHost { get; set; }
  string OutputFolder { get; set; }
  string ParameterList { get; set; }
  List<IParameterQueryDto> ParameterQueries { get; set; }
  string RecipientEmailAddressList { get; set; }
  bool RenderInBody { get; set; }
  int ReportOwnerUserID { get; set; }
  string RowColorList { get; set; }
  bool RunOnFriday { get; set; }
  bool RunOnMonday { get; set; }
  bool RunOnSaturday { get; set; }
  bool RunOnSunday { get; set; }
  bool RunOnThursday { get; set; }
  bool RunOnTuesday { get; set; }
  bool RunOnWednesday { get; set; }
  bool SaveDelimitedFile { get; set; }
  bool SaveExcelFile { get; set; }
  bool SaveXtraReport { get; set; }
  string ScheduleDescription { get; set; }
  string ScheduleName { get; set; }
  string ScheduleTime { get; set; }
  bool SecureFTP { get; set; }
  string SenderEmailAddress { get; set; }
  bool SendFTP { get; set; }
  bool ShowHeaders { get; set; }
  bool SkipWhenEmpty { get; set; }
  string SQLPassword { get; set; }
  string SQLUsername { get; set; }
  string SSHFingerprint { get; set; }
  string StoredProcedureName { get; set; }
  string SubjectLine { get; set; }
  string XtraReportParameters { get; set; }
}
