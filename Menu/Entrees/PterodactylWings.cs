using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the defintions for the Pterodactyl Wings
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem
    {
        /// <summary>
        /// Gets the ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        /// <summary>
        /// Constructor to set price and calories
        /// </summary>
        public PterodactylWings()
        {
            //this.Price = 7.21;
            //this.Calories = 318;
        }

        /// <summary>
        /// Property for the calories
        /// </summary>
        public uint Calories { get => 318; }

        /// <summary>
        /// Property for the price
        /// </summary>
        public double Price { get => 7.21; }
    }
}
