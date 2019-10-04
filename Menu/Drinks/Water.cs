using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        //Private backing variables
        private bool lemon = false;
        private bool ice = true;
        private Size size = Size.Small;

        /// <summary>
        /// Gets or sets the values for a size
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Price = 0.10;
                Calories = 0;
            }
        }

        /// <summary>
        /// Gets or sets the ice
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// Gets or sets the lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// Constructor for default values
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
        }

        /// <summary>
        /// Gets the respected ingredients to the list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (lemon)
                    ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Method to add a lemon to water
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
        }

        /// <summary>
        /// Method to hold ice
        /// </summary>
        public void HoldIce()
        {
            ice = false;
        }
    }
}
