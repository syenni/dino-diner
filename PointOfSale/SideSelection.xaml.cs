﻿using System;
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
        public SideSelection()
        {
            InitializeComponent();
        }

        public void AddFrcyceritops(object sender, RoutedEventArgs args)
        {
            OrderControl order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            BtnAddFryceritops.IsEnabled = false;
            BtnAddTriceritops.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
        }
    }
}
