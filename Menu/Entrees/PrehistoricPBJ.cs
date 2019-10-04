using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the definitions of the Prehistoric PBJ
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        //Private varialbes for options with the entree
        private bool peanutButter = true;
        private bool jelly = true;
        
        /// <summary>
        /// Gets the ingredients based on what options are indicated
        /// </summary>
        public override List<string> Ingredients
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
        /// Default constructor for the price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
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
