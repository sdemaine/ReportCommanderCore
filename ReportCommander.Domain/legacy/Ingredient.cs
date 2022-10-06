using ReportCommander.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportCommander.Domain
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public int IngredientCategoryId { get; set; }

        public IngredientCategory IngredientCategory { get; set; }
    }
}
