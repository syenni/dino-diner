using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {

        PrehistoricPBJ pbj;

        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        private void OnHoldPeanuteButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                //NavigationService
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}