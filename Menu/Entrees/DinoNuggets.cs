 using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the Dino Nugget entree
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Private uint to keep track of the amount of nuggets
        /// </summary>
        private uint nuggetCount = 6;
        private uint calories = 59 * 6;
        private double price = 4.25;

        /// <summary>
        /// Constructor to set calories and price
        /// </summary>
        public DinoNuggets()
        {
            //this.Calories = 59 * 6;
            //this.Price = 4.25;
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
                if (nuggetCount > 6) special.Add((nuggetCount - 6) + " Extra Nuggets");
                return special.ToArray();
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
        /// Property for the calories
        /// </summary>
        public uint Calories { get => calories; }

        /// <summary>
        /// Property for the price
        /// </summary>
        public double Price { get => price; }

        /// <summary>
        /// Gets the ingredients based on the indegredient options for this entree
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (uint i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Adds a nugget to the total amoung of nuggets
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            price += 0.25;
            calories += 59;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /*private uint nuggetCount = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (uint i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }
        
        public void AddNugget()
        {
            nuggetCount++;
            Price += 0.25;
            Calories += 59;
        }*/
    }
}
