using ReportCommander.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCommander.Application.Specifications
{
    public class RecipesContainingSweetener : BaseSpecification<Recipe>
    {
        public RecipesContainingSweetener() : base(x => x.Ingredients.Any(y => y.IngredientCategoryId == 2))
        {

        }
    }
}
