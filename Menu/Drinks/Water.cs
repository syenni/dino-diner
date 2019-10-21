using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that holds the defintions of Water
    /// </summary>
    public class Water : Drink, IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        //Private backing variables
        private bool lemon = false;
        private bool ice = true;
        private Size size = Size.Small;
        private uint calories = 0;
        private double price = 0.10;

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
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (lemon) special.Add("Add Lemon");
                if (!ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Property for the calories
        /// </summary>
        public uint Calories { get => calories; }
        /// <summary>
        /// Property for the price
        /// </summary>
        public double Price { get => price; }

        /// <summary>
        /// Gets or sets the values for a size
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                price = 0.10;
                calories = 0;
            }
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
        /// Gets or sets the lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            return size + " Water";
        }

        /// <summary>
        /// Constructor for default values
        /// </summary>
        public Water()
        {
            //this.Price = 0.10;
            //this.Calories = 0;
        }

        /// <summary>
        /// Gets the respected ingredients to the list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (lemon)
                    ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Method to add a lemon to water
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold ice
        /// </summary>
        public void HoldIce()
        {
            ice = false;
            NotifyOfPropertyChange("Special");
        }
    }
}
