using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public Side Side { get; set; }

        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(side);
                this.Side = side;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side != null)
                this.Side.Size = size;
        }

        protected void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        protected void OnSelectTriceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        protected void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        public void AddFrcyceritops(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                order.Items.Add(new Fryceritops());
            }

            //OrderControl order = (Order)DataContext;
            //order.Items.Add(new Fryceritops());
            BtnAddFryceritops.IsEnabled = false;
            BtnAddTriceritops.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
        }

        protected void PickLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        protected void PickMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void PickSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
    }
}
