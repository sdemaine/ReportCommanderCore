using System.ComponentModel.DataAnnotations.Schema;
using ReportCommander.Core;
using ReportCommander.Core.Interfaces;

namespace ReportCommander.Core.Entities;

[Table("UserDepartmentAssignments")]
  public class UserDepartmentAssignment : BaseEntity
{

      public int UserProfileId { get; set; }

      public virtual UserProfile? UserProfile { get; set; }

      public int DepartmentId { get; set; }

      public virtual Department? Department { get; set; }

  }

