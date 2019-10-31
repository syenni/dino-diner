using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for properties of a menu item
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Gets the Price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the Calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets the Ingredients
        /// </summary>
        List<string> Ingredients { get; }
    }
}
