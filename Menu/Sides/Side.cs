using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class for the defintions of Side
    /// </summary>
    public class Side : IOrderItem
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
        /// Gets and sets the ingredients list
        /// </summary>
        public List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public string[] Special { get; }

        public string Description => Size + this.ToString();
    }
}
