using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class defintions of MezzorellaSticks
    /// </summary>
    public class MezzorellaSticks : Side, IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        //Private backing varialbes
        private uint calories = 540;
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
        public string[] Special { get; }

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
        public List<string> Ingredients { get => new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" }; }


        protected Size size;
        public Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        price = 1.95;
                        calories = 720;
                        NotifyOfPropertyChange("Size");
                        break;
                    case Size.Medium:
                        price = 1.45;
                        calories = 610;
                        NotifyOfPropertyChange("Size");
                        break;
                    case Size.Small:
                        price = 0.99;
                        calories = 540;
                        NotifyOfPropertyChange("Size");
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            return size + " Mezzorella Sticks";
        }

        public MezzorellaSticks()
        {
            //this.Price = 0.99;
            //this.Calories = 540;
            //this.Ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
        }
    }
}
