using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the definitions of Steakosaurus Burger
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        //Private varialbes to indicate what options to include with the entree
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Gets the ingredients to use for this entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Steakburger Pattie" };
                if (bun)
                    ingredients.Add("Whole Wheat Bun");
                if (pickle)
                    ingredients.Add("Pickle");
                if (ketchup)
                    ingredients.Add("Ketchup");
                if (mustard)
                    ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor to set price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Method to check and see if the bun is to be included with the entree
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Method to check and see if a pickle is to be included with the entree
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Method to check and see if ketchup is to be included with the entree
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Method to check and see if mustard is to be included with the entree
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
