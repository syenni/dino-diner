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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Property for a Drink
        /// </summary>
        public Drink Drink { get; set; }

        Drink drink;
        bool flavor = false;

        /// <summary>
        /// Default constuctor to initialize drink selection
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for drink selection if a drink is passed in
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
            if(drink is Drink drinkSelect)
            {
                if (drinkSelect is Sodasaurus s)
                    flavor = true;
                else
                    flavor = false;
            }
        }

        /// <summary>
        /// Selects drink and checks to see if it's a Sodasaurus
        /// </summary>
        /// <param name="drink"></param>
        private void SelectDrink(Drink drink)
        {
            if(DataContext is Order order)
            {
                if(drink is Sodasaurus) flavor = true;
                order.Add(drink);
                this.Drink = drink;
            }
        }

        /// <summary>
        /// Event handler for selecting a flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            SweetDecafFlavor.IsEnabled = true;
            HoldIce.IsEnabled = true;
            AddLemon.IsEnabled = false;
        }


        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
                this.Drink.Size = size;
        }

        /// <summary>
        /// Event handler for selecting the sweet/decaf/flavor button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSweetDecafFlavor(object sender, RoutedEventArgs args)
        {

            if (SweetDecafFlavor.IsEnabled && HoldIce.IsEnabled && !AddLemon.IsEnabled)
                NavigationService.Navigate(new FlavorSelection());
            else if (Drink is Tyrannotea tea)
            {
                tea.Sweet = true;
                SweetDecafFlavor.Content = "Make Sweet";
            }
            else if (Drink is JurassicJava coffee)
            {
                coffee.Decaf = true;
                SweetDecafFlavor.Content = "Decaf";
            }
        }

        /// <summary>
        /// Event handler for selecting a Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            flavor = false;
            SelectDrink(new Tyrannotea());
            SweetDecafFlavor.Content = "Make Sweet";
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
            flavor = false;
            SweetDecafFlavor.Content = "Decaf";
            SweetDecafFlavor.IsEnabled = true;
            AddLemon.IsEnabled = false;
            //HoldIce.IsEnabled = true;
            HoldIce.Content = "Hold Ice";
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
