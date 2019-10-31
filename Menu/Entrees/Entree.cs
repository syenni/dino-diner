using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Entree : IOrderItem, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets and sets the ingredients
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public virtual string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.Add(new Brontowurst().Special.ToString());
                special.Add(new DinoNuggets().Special.ToString());
                special.Add(new PrehistoricPBJ().Special.ToString());
                special.Add(new PterodactylWings().Special.ToString());
                special.Add(new SteakosaurusBurger().Special.ToString());
                special.Add(new TRexKingBurger().Special.ToString());
                special.Add(new VelociWrap().Special.ToString());
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets the description
        /// </summary>
        public virtual string Description => this.ToString();

        /// <summary>
        /// Notifies of changes made to the properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies is a property changes
        /// </summary>
        /// <param name="name"></param>
        public void NotifyOfPropertyChange(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
