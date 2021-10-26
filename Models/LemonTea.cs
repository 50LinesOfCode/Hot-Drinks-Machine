using System.Collections.Generic;

namespace Hot_Drinks_Machine.Models
{
    /// <summary>
    /// Lemon Tea
    /// - Boil some water
    /// - Steep the tea in the water
    /// - Pour tea in the cup
    /// - Add lemon
    /// </summary>
    public class LemonTea : HotDrink
    {
        public override string DrinkName()
        {
            return "Lemon Tea";
        }
        public override string[] PrepareDrink()
        {
            List<string> process = new List<string>();
            process.Add(BoilWater());
            process.Add("Steep the tea in the water");
            process.Add(PourDrink("tea"));
            process.Add(AddAdditionalIngredient("lemon"));
            return process.ToArray();
        }
    }

}
