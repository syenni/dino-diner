using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the defintions of Brontowurst
    /// </summary>
    public class Brontowurst : Entree, IMenuItem//, IOrderItem
    {
        //Private variables for class
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// Constructor to set calories and price
        /// </summary>
        public Brontowurst()
        {
            //this.Calories = 498;
            //this.Price = 5.36;
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
        /// Property for the calories
        /// </summary>
        public override uint Calories { get => 498; }
        /// <summary>
        /// Property for the price
        /// </summary>
        public override double Price { get => 5.36; }

        /// <summary>
        /// Gets the ingredients based on the indegredient options for this entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun)
                    ingredients.Add("Whole Wheat Bun");
                if (peppers)
                    ingredients.Add("Peppers");
                if (onions)
                    ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Method to hold the bun or not based on user input
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Method to hold the peppers or not based on user input
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Method to hold the onions or not based on user input
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
