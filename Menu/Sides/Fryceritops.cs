using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        //public override List<string> Ingredients
        //{
        //    get
        //    {
        //        return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        //    }
        //}

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

        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" }; //works because of the protected set in Side.cs
        }


        
    }
}
