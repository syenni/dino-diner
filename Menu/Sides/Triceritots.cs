using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class definitions for Triceritots
    /// </summary>
    public class Triceritots : Side, IMenuItem
    {
        //Private backing varialbes
        private uint calories = 352;
        private double price = 0.99;

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
                        calories = 590;
                        break;
                    case Size.Medium:
                        price = 1.45;
                        calories = 410;
                        break;
                    case Size.Small:
                        price = 0.99;
                        calories = 352;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        public override string ToString()
        {
            return size + " Triceritots";
        }

        public Triceritots()
        {
            //this.Price = 0.99;
            //this.Calories = 352;
            //this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }
    }
}
