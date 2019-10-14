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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for selecting Brontowurst Combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectBrontoworstCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Event handler for selecting Dino-Nuggets Combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Event handler for selecting Prehistoric PB&J Combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Event handler for selecting Pterodactyl Wings Combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPterodactylWingsCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Event handler for selecting Steakosaurus Burger Combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSteakosaurusBurgerCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Event handler for selecting T-Rex Kingburger Combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTRexKingburgerCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Event handler for selecting Veloci-Wrap Combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectVelociWrapCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
