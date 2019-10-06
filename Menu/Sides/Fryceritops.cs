using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the defintions of Fryceritops
    /// </summary>
    public class Fryceritops : Side, IMenuItem
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
        /// Insstance of the object Size
        /// </summary>
        protected Size size;

        public Size Size
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
                        break;
                    case Size.Medium:
                        price = 1.45;
                        calories = 365;
                        break;
                    case Size.Small:
                        price = 0.99;
                        calories = 222;
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
            return size + " Friceritops";
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
