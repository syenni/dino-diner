using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public abstract class Drink
    {

        public double Price { get; set; }

        public uint Calories { get; set; }


        public abstract Size Size { get; set; }

        public List<string> Ingredients { get; protected set; }

    }
}
