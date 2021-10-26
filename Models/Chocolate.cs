using System.Collections.Generic;

namespace Hot_Drinks_Machine.Models
{
    /// <summary>
    ///Chocolate
    /// - Boil some water
    /// - Add drinking chocolate powder to the water
    /// - Pour chocolate in the cup
    /// </summary>
    public class Chocolate : HotDrink
    {
        public override string DrinkName()
        {
            return "Chocolate";
        }
        public override string[] PrepareDrink()
        {
            List<string> process = new List<string>();
            process.Add(BoilWater());
            process.Add("Add drinking chocolate powder to the water");
            process.Add(PourDrink("chocolate"));
            return process.ToArray();
        }
    }
}
