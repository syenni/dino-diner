using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the defintions for the Pterodactyl Wings
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Gets the ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// The PropertyChanged Event Handler; notifies of changes to the Price, Description, and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper Function for notifying of property changes
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets the description
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public string[] Special { get; }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        /// <summary>
        /// Constructor to set price and calories
        /// </summary>
        public PterodactylWings()
        {
            //this.Price = 7.21;
            //this.Calories = 318;
        }

        /// <summary>
        /// Property for the calories
        /// </summary>
        public uint Calories { get => 318; }

        /// <summary>
        /// Property for the price
        /// </summary>
        public double Price { get => 7.21; }
    }
}
