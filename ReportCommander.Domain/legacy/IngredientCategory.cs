using ReportCommander.Core;

namespace ReportCommander.Domain;

public class IngredientCategory : BaseEntity
{
    public string Name { get; set; }

    public string Description { get; set; }
}
