using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class for the properties of the drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Bascking varialbe for ice in a drink
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets or sets the ingredients
        /// </summary>
        public List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Method to hold ice in a drink
        /// </summary>
        public void HoldIce()
        {
            ice = false;
        }
    }
}
