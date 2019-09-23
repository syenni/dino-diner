using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the defintions for the Pterodactyl Wings
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Gets the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor to set price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
