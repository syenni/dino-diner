using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus
    {
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola; //backing variable, same name as the property but camel case format
        private Size size = Size.Small;
        private bool ice = true;

        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value; //sets it to backing variable, flavor (Sodasaurus.Flavor = ______)
            }
        }

        public double Price { get; set; }
        public uint Calories { get; set; }

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
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                }
            }
        }

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

        public void HoldIce()
        {
            ice = false;
        }

    }
}
