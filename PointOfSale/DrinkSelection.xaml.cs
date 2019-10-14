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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for selecting a flavo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            SweetDecafFlavor.IsEnabled = true;
            HoldIce.IsEnabled = true;
            AddLemon.IsEnabled = false;
        }

        /// <summary>
        /// Event handler for selecting a flavo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {

            if (SweetDecafFlavor.IsEnabled && HoldIce.IsEnabled && !AddLemon.IsEnabled)
                NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Event handler for selecting a Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            SweetDecafFlavor.IsEnabled = true;
            HoldIce.IsEnabled = true;
            AddLemon.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for selecting a Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCoffee(object sender, RoutedEventArgs args)
        {
            SweetDecafFlavor.IsEnabled = true;
            AddLemon.IsEnabled = false;
            HoldIce.IsEnabled = false;
        }

        /// <summary>
        /// Event handler for selecting a Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            HoldIce.IsEnabled = true;
            AddLemon.IsEnabled = true;
            SweetDecafFlavor.IsEnabled = false;
        }
    }
}
