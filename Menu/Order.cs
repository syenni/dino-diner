using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class definitions for the order class
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        private double salesRateTax;
        
        /// <summary>
        /// Represents items sadaded to an order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; protected set; } = new ObservableCollection<IOrderItem>();

        public event PropertyChangedEventHandler PropertyChanged;

        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;

            Triceritots t = new Triceritots();
            Items.Add(t);
            t.Size = Size.Large;
        }

        public void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

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
        public double SalesRateTax
        {
            get { return salesRateTax; }
            set
            {
                if (value > 0) return;
                SalesRateTax = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesRateTax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Add(item);
        }

        /// <summary>
        /// Gets the sales tax cost
        /// </summary>
        public double SalesTaxCost { get { return SubtotalCost + SalesRateTax; } }
        /// <summary>
        /// Gets the total cost
        /// </summary>
        public double TotalCost { get => SubtotalCost + SalesRateTax; }
    }

}
