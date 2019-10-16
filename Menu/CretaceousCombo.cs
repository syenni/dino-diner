using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class definitions of CretaceousCombo
    /// </summary>
    public class CretaceousCombo
    {
        //Private backing variable
        private Size size = Size.Small;

        //Property definitions for getting and setting
        public Entree Entree { get; set; }
        public Drink Drink { get; set; }
        public Side Side { get; set; }

        /// <summary>
        /// Default constructor that cannot be envoked because it is set to private
        /// </summary>
        private CretaceousCombo() { }

        /// <summary>
        /// Constructor with an entree passed in
        /// </summary>
        /// <param name="entree">The entree for a combo</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
            }
        }

        /// <summary>
        /// Gets the price
        /// </summary>
        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
        }

        /// <summary>
        /// ToString Method implementation to return the name of the combo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        /// <summary>
        /// Gets the calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }
        }

        /// <summary>
        /// Gets the ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Special); //need to implement IOrderItem on the base classes
                ingredients.Add(Side.ToString()); //or Side.Description
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.Add(Drink.Special);
                return ingredients.ToArray();
            }
        }
    }
}
