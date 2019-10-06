using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that hold the definitions of Tyrannotea
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem
    {
        /// <summary>
        /// Backing variables
        /// </summary>
        private bool sweet = false;
        private bool lemon = false;
        private bool ice = true;
        private Size size = Size.Small;
        private uint calories = 8;
        private double price = 0.99;

        /// <summary>
        /// Property for the calories
        /// </summary>
        public uint Calories { get => calories; }
        /// <summary>
        /// Property for the price
        /// </summary>
        public double Price { get => price; }

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
        public Size Size
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
                        price = 1.99;
                        if (sweet)
                            calories = 64;
                        else
                            calories = 32;
                        break;
                    case Size.Medium:
                        price = 1.49;
                        if (sweet)
                            calories = 32;
                        else
                            calories = 16;
                        break;
                    case Size.Small:
                        price = 0.99;
                        if (sweet)
                            calories = 16;
                        else
                            calories = 8;
                        break;
                }
            }
        }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            if (sweet)
                return size + " Sweet Tyrannotea";
            else
                return size + " Tyrannotea";
        }

        /// <summary>
        /// Constructor for default values
        /// </summary>
        public Tyrannotea()
        {
            //this.Price = 0.99;
            //this.Calories = 8;
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
