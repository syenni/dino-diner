using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the definitions of the Prehistoric PBJ
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem
    {
        //Private varialbes for options with the entree
        private bool peanutButter = true;
        private bool jelly = true;
        
        /// <summary>
        /// Gets the ingredients based on what options are indicated
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };

                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// ToString override print the object
        /// </summary>
        /// <returns>The object in a string</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Property for the calories
        /// </summary>
        public uint Calories { get => 483; }

        /// <summary>
        /// Property for the price
        /// </summary>
        public double Price { get => 6.52; }

        /// <summary>
        /// Default constructor for the price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            //this.Price = 6.52;
            //this.Calories = 483;
        }

        /// <summary>
        /// Method to hold peanut butter or not on the entree
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Method to hold jelly or not on the entree
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
