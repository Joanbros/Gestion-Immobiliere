using Gestion_Immobilière.Data.DAL;
using Gestion_Immobilière.Data.Models;
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
    /// Logique d'interaction pour ListBienView.xaml
    /// </summary>
    public partial class ListBienView : Page
    {
        public ListBienView()
        {
            InitializeComponent();
            AddBiens();
        }

        private void lstBiens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void AddBiens()
        {
            Context ctx = new Context();

            foreach (Bien b in ctx.Biens)
            {
                this.lstBiens.Items.Add(b);
            }
        }
    }
}
