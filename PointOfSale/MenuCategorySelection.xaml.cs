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
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent(); //Runs the defintions in the xam
        }

        /// <summary>
        /// Event handler for selecting combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection()); //Loads the next page in a frame
        }

        /// <summary>
        /// Event handler for selecting entrees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectEntrees(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// Event handler for selecting sides
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSides(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Event handler for selecting drinks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDrinks(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
