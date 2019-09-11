using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class VelociWrap
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        public double Price { get; set; }
        private uint Calories { get; set; }

        private List<string> ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Romaine Lettuce" };
                if (dressing)
                    ingredients.Add("Ceasar Dressing");
                if (lettuce)
                    ingredients.Add("Lettuce");
                if (cheese)
                    ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }


    }
}
