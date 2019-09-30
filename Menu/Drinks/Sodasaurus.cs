using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        //Private backing variables
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola; //backing variable, same name as the property but camel case format
        private Size size = Size.Small;
        private bool ice = true;

        /// <summary>
        /// Gets or sets the flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value; //sets it to backing variable, flavor (Sodasaurus.Flavor = ______)
            }
        }

        //public double Price { get; set; }
        //public uint Calories { get; set; }

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
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                }
            }
        }

        /// <summary>
        /// Constructor for the defualt values
        /// </summary>
        public Sodasaurus()
        {
            this.Calories = 112;
            this.Price = 1.50;
            this.Ingredients = new List<string> { "Water", "Natural Flavors", "Cane Sugar" };
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
        /// Method to hold ice
        /// </summary>
        public void HoldIce()
        {
            ice = false;
        }

    }
}
