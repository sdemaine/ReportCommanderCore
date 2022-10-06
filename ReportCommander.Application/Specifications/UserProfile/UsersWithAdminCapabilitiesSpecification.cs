using ReportCommander.Core.Entities;

namespace ReportCommander.Application.Specifications;

public class UsersWithAdminCapabilitiesSpecification : BaseSpecification<UserProfile>
{
    public UsersWithAdminCapabilitiesSpecification() : base(x => x.IsAdmin == true)
    {

    }
}
