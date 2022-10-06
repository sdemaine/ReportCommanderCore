using ReportCommander.Core;

namespace ReportCommander.Application.Dtos
{
    public class UserDto : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
