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
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Initializes the page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }
        
        private void SelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst brontowurst = new Brontowurst();
                order.Add(brontowurst);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                order.Add(dn);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void SelectAddPBJ(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void SelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings pw = new PterodactylWings();
                order.Add(pw);
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }


    }
}
