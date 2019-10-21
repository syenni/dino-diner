using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the defintions of the Veloci Wrap entree
    /// </summary>
    public class VelociWrap : Entree, IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        //Private variables indicating to include the options in the entree
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

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
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets the ingredients to include in the entree
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing)
                    ingredients.Add("Ceasar Dressing");
                if (lettuce)
                    ingredients.Add("Romaine Lettuce");
                if (cheese)
                    ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// Default constructor for the price and calories
        /// </summary>
        public VelociWrap()
        {
            //this.Price = 6.86;
            //this.Calories = 356;
        }

        /// <summary>
        /// Property for the calories
        /// </summary>
        public uint Calories { get => 356; }

        /// <summary>
        /// Property for the price
        /// </summary>
        public double Price { get => 6.86; }

        /// <summary>
        /// Method to hold the dressing
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
    }
}
