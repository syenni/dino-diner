using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        //Private backing variables
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola; //backing variable, same name as the property but camel case format
        private Size size = Size.Small;
        private bool ice = true;
        private uint calories = 112;
        private double price = 1.50;

        /// <summary>
        /// Property for the calories
        /// </summary>
        public uint Calories { get => calories; }
        /// <summary>
        /// Property for the price
        /// </summary>
        public double Price { get => price; }
        /// <summary>
        /// Property for the ingredients
        /// </summary>
        public List<string> Ingredients { get => new List<string> { "Water", "Natural Flavors", "Cane Sugar" }; }
        /// <summary>
        /// Gets the description of a sodasaurus
        /// </summary>
        public string Description { get => this.ToString(); }
        /// <summary>
        /// Gets the list of items for special instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!ice) special.Add("Hold Ice");
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
        /// Gets or sets the flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value; //sets it to backing variable, flavor (Sodasaurus.Flavor = ______)
            }
        }

        //public double Price { get; set; }
        //public uint Calories { get; set; }

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
                        price = 2.50;
                        calories = 208;
                        NotifyOfPropertyChange("Size");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Medium:
                        price = 2.00;
                        calories = 156;
                        NotifyOfPropertyChange("Size");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Small:
                        price = 1.50;
                        calories = 112;
                        NotifyOfPropertyChange("Size");
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Description");
                        break;
                }
            }
        }

        /// <summary>
        /// Returns the drink identity string
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            //return size + " " + flavor + " Sodasaurus";
            return $"{Size} {Flavor} Sodasaurus";
        }

        /// <summary>
        /// Constructor for the defualt values
        /// </summary>
        public Sodasaurus()
        {
            //this.Calories = 112;
            //this.Price = 1.50;
            //this.Ingredients = new List<string> { "Water", "Natural Flavors", "Cane Sugar" };
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
        /// Method to hold ice
        /// </summary>
        public void HoldIce()
        {
            ice = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

    }
}
