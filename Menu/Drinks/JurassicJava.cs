using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink, IMenuItem
    {
        //Private backing variables
        private bool ice = false;
        private bool roomForCream = false;
        private bool decaf = false;
        private Size size = Size.Small;
        private uint calories = 2;
        private double price = 0.59;

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
        public List<string> Ingredients { get => new List<string> { "Water", "Coffee" }; }

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
        /// Gets or sets the roomForCream
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
            }
        }

        /// <summary>
        /// Property for decaf
        /// </summary>
        public bool Decaf { get => decaf; set { decaf = value; } }

        /// <summary>
        /// Gets or sets the values for a size
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
                        price = 1.49;
                        calories = 8;
                        break;
                    case Size.Medium:
                        price = 0.99;
                        calories = 4;
                        break;
                    case Size.Small:
                        price = 0.59;
                        calories = 2;
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
            if (decaf)
                return size + " Decaf Jurassic Java";
            else
                return size + " Jurassic Java";
        }

        /// <summary>
        /// Construcotr to set deafult values
        /// </summary>
        public JurassicJava()
        {
            //this.Calories = 2;
            //this.Price = 0.59;
            //this.Ingredients = new List<string> { "Water", "Coffee" };
        }

        /// <summary>
        /// Method to leave room for cream in the coffee
        /// </summary>
        public void LeaveRoomForCream()
        {
            roomForCream = true;
        }

        /// <summary>
        /// Adds ice to the coffee
        /// </summary>
        public void AddIce()
        {
            ice = true;
        }
    }
}
