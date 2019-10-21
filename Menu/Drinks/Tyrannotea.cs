using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that hold the definitions of Tyrannotea
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Backing variables
        /// </summary>
        private bool sweet = false;
        private bool lemon = false;
        private bool ice = true;
        private Size size = Size.Small;
        private uint calories = 8;
        private double price = 0.99;

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
                if (sweet) special.Add("Make Sweet");
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
        /// Gets or sets Sweet
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
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
        /// Gets or sets the values for size
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
                switch (size)
                {
                    case Size.Large:
                        price = 1.99;
                        if (sweet)
                            calories = 64;
                        else
                            calories = 32;
                        NotifyOfPropertyChange("Size");
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Medium:
                        price = 1.49;
                        if (sweet)
                            calories = 32;
                        else
                            calories = 16;
                        NotifyOfPropertyChange("Size");
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Small:
                        price = 0.99;
                        if (sweet)
                            calories = 16;
                        else
                            calories = 8;
                        NotifyOfPropertyChange("Size");
                        NotifyOfPropertyChange("Price");
                        break;
                }
            }
        }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            if (sweet)
                return size + " Sweet Tyrannotea";
            else
                return size + " Tyrannotea";
        }

        /// <summary>
        /// Constructor for default values
        /// </summary>
        public Tyrannotea()
        {
            //this.Price = 0.99;
            //this.Calories = 8;
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
                ingredients.Add("Tea");
                if (lemon)
                    ingredients.Add("Lemon");
                if (sweet)
                {
                    ingredients.Add("Cane Sugar");
                    NotifyOfPropertyChange("Ingredients");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Method to add a lemon
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            Ingredients.Add("Lemon");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the ice
        /// </summary>
        public void HoldIce()
        {
            ice = false;
            NotifyOfPropertyChange("Special");
        }

    }
}
