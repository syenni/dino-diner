using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the defintions of the Veloci Wrap entree
    /// </summary>
    public class VelociWrap : Entree
    {
        //Private variables indicating to include the options in the entree
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        /// <summary>
        /// Gets the ingredients to include in the entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing)
                    ingredients.Add("Ceasar Dressing");
                if (lettuce)
                    ingredients.Add("Romaine Lettuce");
                if (cheese)
                    ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor for the price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// Method to hold the dressing
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Method to hold the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Method to hold the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
