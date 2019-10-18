using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        public ObservableCollection<IOrderItem> Items { get; set; }
        
        public double SubtotalCost
        {
            get
            {
                if (SubtotalCost > 0) return SubtotalCost;
                return 0;
            }
        }

        public double SalesRateTax { get; protected set; }

        public double SalesTaxCost { get; }

        public double TotalCost { get; }
    }
}
