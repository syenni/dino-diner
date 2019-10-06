﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the definitions of MeteorMacAndCheese
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem
    {
        //Private backing varialbes
        private uint calories = 420;
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
        public List<string> Ingredients { get => new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" }; }


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
                        calories = 520;
                        break;
                    case Size.Medium:
                        price = 1.45;
                        calories = 490;
                        break;
                    case Size.Small:
                        price = 0.99;
                        calories = 420;
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
            return size + " Meteor Mac and Cheese";
        }

        public MeteorMacAndCheese()
        {
            //this.Price = 0.99;
            //this.Calories = 420;
            //this.Ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
        }
    }
}
