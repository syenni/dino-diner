using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class definitions for the order class
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Represents items sadaded to an order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }
        
        /// <summary>
        /// Calculates the total price from the prices of all order items
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                if (SubtotalCost > 0) return SubtotalCost;
                return 0;
            }
        }

        /// <summary>
        /// Gets and sets the sales rate tax
        /// </summary>
        public double SalesRateTax { get; protected set; }
        /// <summary>
        /// Gets the sales tax cost
        /// </summary>
        public double SalesTaxCost { get; }
        /// <summary>
        /// Gets the total cost
        /// </summary>
        public double TotalCost { get; }
    }
}
