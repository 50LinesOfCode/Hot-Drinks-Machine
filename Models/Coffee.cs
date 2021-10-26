using System.Collections.Generic;

namespace Hot_Drinks_Machine.Models
{
    /// <summary>
    ///Coffee
    /// - Boil some water
    /// - Brew the coffee grounds
    /// - Pour coffee in the cup
    /// - Add sugar and milk
    /// </summary>
    public class Coffee : HotDrink
    {
        public override string DrinkName()
        {
            return "Coffee";
        }
        public override string[] PrepareDrink()
        {
            List<string> process = new List<string>();
            process.Add(BoilWater());
            process.Add("Brew the coffee grounds");
            process.Add(PourDrink("coffee"));
            process.Add(AddAdditionalIngredient("sugar and milk"));
            return process.ToArray();
        }

    }
}
