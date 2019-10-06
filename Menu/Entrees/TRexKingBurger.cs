﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the defintions of the TRex King Burger
    /// </summary>
    public class TRexKingBurger : Entree, IMenuItem
    {
        //Local private varialbes to indicate to include options for the entree
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;
        private int pattieCount = 3;

        /// <summary>
        /// Gets the ingredients for the entree
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < pattieCount; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (bun)
                    ingredients.Add("Whole Wheat Bun");
                if (lettuce)
                    ingredients.Add("Lettuce");
                if (tomato)
                    ingredients.Add("Tomato");
                if (onion)
                    ingredients.Add("Onion");
                if (pickle)
                    ingredients.Add("Pickle");
                if (ketchup)
                    ingredients.Add("Ketchup");
                if (mustard)
                    ingredients.Add("Mustard");
                if (mayo)
                    ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor to set the default price and calories
        /// </summary>
        public TRexKingBurger()
        {
            //this.Price = 8.45;
            //this.Calories = 728;
        }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }

        /// <summary>
        /// Property for the calories
        /// </summary>
        public uint Calories { get => 728; }

        /// <summary>
        /// Property for the price
        /// </summary>
        public double Price { get => 8.45; }

        /// <summary>
        /// Method to hold the bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Method to hold the luttuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Method to hold the tomato
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Method to hold the onion
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Method to hold the pcikle
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Method to hold the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Method to hold the mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Method to hold the mayo
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
