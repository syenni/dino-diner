using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the defintions of Fryceritops
    /// </summary>
    public class Fryceritops : Side, IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        //public override List<string> Ingredients
        //{
        //    get
        //    {
        //        return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        //    }
        //}
        //Private backing variables
        private uint calories = 222;
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
        public List<string> Ingredients { get => new List<string>() { "Potato", "Salt", "Vegetable Oil" }; }

        /// <summary>
        /// Instance of the object Size
        /// </summary>
        protected Size size;

        public override Size Size
        {
            set
            {
                size = value;
                //if (size == Size.Large)
                //   Price = 1.95;
                switch (size)
                {
                    case Size.Large:
                        price = 1.95;
                        calories = 480;
                        NotifyOfPropertyChange("Size");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Medium:
                        price = 1.45;
                        calories = 365;
                        NotifyOfPropertyChange("Size");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Small:
                        price = 0.99;
                        calories = 222;
                        NotifyOfPropertyChange("Size");
                        NotifyOfPropertyChange("Description");
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
            return size + " Fryceritops";
        }

        //Default constructor to set the price, calories, and ingredients
        public Fryceritops()
        {
            //this.Price = 0.99;
            //this.Calories = 222;
            //this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" }; //works because of the protected set in Side.cs
        }


        
    }
}
