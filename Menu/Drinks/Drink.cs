﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class for the properties of the drinks
    /// </summary>
    public class Drink : IOrderItem
    {
        /// <summary>
        /// Bascking varialbe for ice in a drink
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets or sets the ingredients
        /// </summary>
        public List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public string[] Special { get; }

        public string Description => Size + this.ToString();

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method to hold ice in a drink
        /// </summary>
        public void HoldIce()
        {
            ice = false;
        }
    }
}
