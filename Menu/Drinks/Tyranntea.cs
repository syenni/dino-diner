using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyranntea : Drink
    {
        /// <summary>
        /// Backing variables
        /// </summary>
        private bool sweet = false;
        private bool lemon = false;
        private bool ice = true;
        private Size size = Size.Small;
        
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
        /// Gets or sets Sweet
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
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
        /// Gets or sets the values for size
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
                switch (size)
                {
                    case Size.Large:
                        Price = 1.99;
                        if (sweet)
                            Calories = 64;
                        else
                            Calories = 32;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (sweet)
                            Calories = 32;
                        else
                            Calories = 16;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        if (sweet)
                            Calories = 16;
                        else
                            Calories = 8;
                        break;
                }
            }
        }

        /// <summary>
        /// Constructor for default values
        /// </summary>
        public Tyranntea()
        {
            this.Price = 0.99;
            this.Calories = 8;
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
                ingredients.Add("Tea");
                if (lemon)
                    ingredients.Add("Lemon");
                if (sweet)
                    ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Method to add a lemon
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            Ingredients.Add("Lemon");
        }

        /// <summary>
        /// Method to hold the ice
        /// </summary>
        public void HoldIce()
        {
            ice = false;
        }

    }
}
