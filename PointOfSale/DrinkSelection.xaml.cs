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

        //Private backing variable for flavor
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

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
                this.Drink.Size = size;
        }

        /// <summary>
        /// Event handler for selecting a flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            flavor = true;
            SweetDecafFlavor.Content = "Flavor";
            SweetDecafFlavor.IsEnabled = true;
            HoldIce.IsEnabled = true;
            HoldIce.Content = "Hold Ice";
            AddLemon.IsEnabled = false;
            SelectDrink(new Sodasaurus());
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
            SelectDrink(new JurassicJava());
            SweetDecafFlavor.Content = "Decaf";
            SweetDecafFlavor.IsEnabled = true;
            AddLemon.IsEnabled = false;
            HoldIce.IsEnabled = true;
            HoldIce.Content = "Add Ice";
        }

        /// <summary>
        /// Event handler for selecting a Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            flavor = false;
            SelectDrink(new Water());
            HoldIce.IsEnabled = true;
            HoldIce.Content = "Hold Ice";
            AddLemon.IsEnabled = true;
            SweetDecafFlavor.IsEnabled = false;
        }

        /// <summary>
        /// Event handler for the Large button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Event handler for the Medium button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void  SelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Event handler for the Small button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
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
        /// Event handler for selecting the Add Lemon button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectAddLemon(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
                tea.Lemon = true;
            else if (Drink is Water water)
                water.Lemon = true;
        }

        /// <summary>
        /// Event handler for the Hold Ice button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectHoldIce(object sender, RoutedEventArgs args)
        {
            if (Drink is Drink drink)
            {
                Drink.HoldIce();
                //Drink.HoldIce = true;
            }
            else if (Drink is JurassicJava coffee)
                coffee.Ice = true;
        }

        /// <summary>
        /// Event handler for the Done button
        ///     Navigates back to the main page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
