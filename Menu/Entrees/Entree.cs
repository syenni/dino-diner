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
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets and sets the ingredients
        /// </summary>
        public virtual List<string> Ingredients { get; }

        
    }
}
