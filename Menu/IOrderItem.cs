using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of an item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Gets a description
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Gest the special
        /// </summary>
        string[] Special { get; }
    }
}
