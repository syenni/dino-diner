using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the defintions of Fryceritops
    /// </summary>
    public class Fryceritops : Side
    {
        //public override List<string> Ingredients
        //{
        //    get
        //    {
        //        return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        //    }
        //}

        /// <summary>
        /// Insstance of the object Size
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
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        //Default constructor to set the price, calories, and ingredients
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" }; //works because of the protected set in Side.cs
        }


        
    }
}
