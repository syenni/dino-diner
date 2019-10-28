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
        private double salesRateTax = 0;
        List<IOrderItem> items = new List<IOrderItem>();
        
        /// <summary>
        /// Represents items sadaded to an order
        /// </summary>
        //public ObservableCollection<IOrderItem> Items { get; protected set; } = new ObservableCollection<IOrderItem>();

        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// The PropertyChanged event handler; notifies when an order is added
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public Order()
        {
            //items = new ObservableCollection<IOrderItem>();
            //items.CollectionChanged += OnCollectionChanged;

            Triceritots t = new Triceritots();
            items.Add(t);
            t.Size = Size.Large;
        }

        /// <summary>
        /// Adds a new item to our order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertyChanged()
            //NotifyOfPropertyChanged("Items");
            //NotifyOfPropertyChanged("SubTotalCost");
            //NotifyOfPropertyChanged("SalesTaxCost");
            //NotifyOfPropertyChanged("TotalCost");
        }


        public bool Remove(IOrderItem item)
        {
            bool flag = items.Remove(item);
            if(flag)
            {

            }
            return flag;

        }

        protected void NotifyAllPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        //public void OnCollectionChanged(object sender, EventArgs args)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotalCost"));
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        //}

        /// <summary>
        /// Calculates the total price from the prices of all order items
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double total = 0;
                foreach (IOrderItem item in Items)
                {
                    total += item.Price;
                }
                return total;
                //if (SubtotalCost > 0) return SubtotalCost;
                //else return 0;
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

        //public void Add(IOrderItem item)
        //{
        //    item.PropertyChanged += OnCollectionChanged;

        //    items.Add(item);
        //    NotifyOfPropertyChanged("Items");

        //}

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertyChanged();
            //NotifyOfPropertyChanged("Items");
            //NotifyOfPropertyChanged("SubTotalCost");
            //NotifyOfPropertyChanged("SalesTaxCost");
            //NotifyOfPropertyChanged("TotalCost");
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
