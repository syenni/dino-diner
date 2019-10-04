 using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the Dino Nugget entree
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Private uint to keep track of the amount of nuggets
        /// </summary>
        private uint nuggetCount = 6;

        /// <summary>
        /// Constructor to set calories and price
        /// </summary>
        public DinoNuggets()
        {
            this.Calories = 59 * 6;
            this.Price = 4.25;
        }

        /// <summary>
        /// Gets the ingredients based on the indegredient options for this entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (uint i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Adds a nugget to the total amoung of nuggets
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            Price += 0.25;
            Calories += 59;
        }


        /*private uint nuggetCount = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (uint i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }
        
        public void AddNugget()
        {
            nuggetCount++;
            Price += 0.25;
            Calories += 59;
        }*/
    }
}
