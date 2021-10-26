using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hot_Drinks_Machine.Models
{
    public abstract class HotDrink
    {
        public abstract string DrinkName();
        public abstract string[] PrepareDrink();

        public string BoilWater()
        {
            return "Boil some water";
        }

        public string PourDrink(string drink)
        {
            return $"Pour {drink} in the cup";
        }

        public string AddAdditionalIngredient(string ingredient)
        {
            return $"Add {ingredient}";
        }
    }
}
