using ReportCommander.Core;

namespace ReportCommander.Domain;

public class User : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }

    public IEnumerable<Recipe> Recipes { get; set; }
}
