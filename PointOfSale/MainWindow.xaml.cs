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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderList.NavigationService = OrderUI.NavigationService;
            //Order order = (Order)DataContext;
            //order.Add(new Fryceritops());
            //order.Add(new Tyrannotea());
            //OrderList.DataContext = order;
            //OrderInterface.DataContext = order;
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            BindDataContextToPage();
        }

        private void OnDone(object sender, NavigationEventArgs args)
        {
            if (OrderUI.NavigationService.CanGoBack)
            {
                OrderUI.NavigationSerice.GoBack();
            }
            else
            {
                OrderUI.NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void BindDataContextToPage()
        {
            if (OrderUI.Content is FrameworkElement element)
            {
                element.DataContext = OrderUI.DataContext;
            }
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            BindDataContextToPage();
        }
    }
}