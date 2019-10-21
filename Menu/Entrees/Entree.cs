using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Entree
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets and sets the ingredients
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public string[] Special { get; }
    }
}
