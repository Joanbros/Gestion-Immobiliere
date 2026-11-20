using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gestion_Immobilière.View.SubViews
{
    /// <summary>
    /// Logique d'interaction pour NavigationView.xaml
    /// </summary>
    public partial class NavigationView : Page
    {
        public NavigationView()
        {
            InitializeComponent();
            this.MainFrame.Navigate(new HomeView());
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new BienView());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new HomeView());
        }

        private void btnPrets_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new PretView());
        }

        private void btnPrestataire_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new PrestataireView());
        }
    }
}
