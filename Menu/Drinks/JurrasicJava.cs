using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurrasicJava : Drink
    {
        //Private backing variables
        private bool ice = false;
        private bool roomForCream = false;
        private Size size = Size.Small;

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
        /// Gets or sets the values for a size
        /// </summary>
        public override Size Size
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
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        break;
                }
            }
        }
         /// <summary>
         /// Construcotr to set deafult values
         /// </summary>
        public JurrasicJava()
        {
            this.Calories = 2;
            this.Price = 0.59;
            this.Ingredients = new List<string> { "Water", "Coffee" };
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
