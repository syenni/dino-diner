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
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new Brontowurst());
                items.Add(new DinoNuggets());
                items.Add(new PrehistoricPBJ());
                items.Add(new PterodactylWings());
                items.Add(new SteakosaurusBurger());
                items.Add(new TRexKingBurger());
                items.Add(new VelociWrap());
                items.Add(new Fryceritops());
                items.Add(new MeteorMacAndCheese());
                items.Add(new MezzorellaSticks());
                items.Add(new Triceritots());
                return items;
            }
        }
        /// <summary>
        /// Gets the AvailableEntrees
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> entree = new List<Entree>();
                return entree;
            }
        }
        /// <summary>
        /// Gets the AvailableSides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> side = new List<Side>();
                return side;
            }
        }
        /// <summary>
        /// Gets the AvailableDrinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> drink = new List<Drink>();
                return drink;
            }
        }
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
