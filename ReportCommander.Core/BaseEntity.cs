using ReportCommander.Core.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportCommander.Core;

public abstract class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedByUserId { get; set; }

    public bool IsDeleted { get; set; } = false;

    public void Save(IUserProfile userProfile)
    {
        if (Id != 0)
        {
            UpdatedByUserId = userProfile.UserID;
            UpdatedDate = DateTime.Now;
        }

        if (Id == 0)
        {
            CreatedByUserId = userProfile.UserID;
            CreatedDate = DateTime.Now;
        }
    }
}
