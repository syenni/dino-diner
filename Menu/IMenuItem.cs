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
        double Price { get; }

        uint Calories { get; }

        List<string> Ingredients { get; }
    }
}
