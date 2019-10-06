using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class defintions of Menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Gets the AvailableMenuItems
        /// </summary>
        public List<IMenuItem> AvailableMenuItems { get; }
        /// <summary>
        /// Gets the AvailableEntrees
        /// </summary>
        public List<Entree> AvailableEntrees { get; }
        /// <summary>
        /// Gets the AvailableSides
        /// </summary>
        public List<Side> AvailableSides { get; }
        /// <summary>
        /// Gets the AvailableDrinks
        /// </summary>
        public List<Drink> AvailableDrinks { get; }
        /// <summary>
        /// Gets the AvailableCombos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos { get; }

        /// <summary>
        /// ToString method overridden to print out menu items
        /// </summary>
        /// <returns>the menu items</returns>
        public override string ToString()
        {
            List<IMenuItem> menu = new List<IMenuItem>();
            List<string> menuList = new List<string>();
            foreach(IMenuItem item in menu)
            {
                menuList.Add(item.ToString() + "\n");
            }
            return menuList.ToString();
        }
    }
}
