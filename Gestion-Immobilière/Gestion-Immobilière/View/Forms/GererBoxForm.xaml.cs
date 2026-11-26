using System;
using System.Windows;
using System.Windows.Controls;
using Gestion_Immobilière.Data.DAL;
using Gestion_Immobilière.Data.Models;

namespace Gestion_Immobilière.View.Forms
{
    public partial class GererBoxForm : Page
    {
        public GererBoxForm()
        {
            InitializeComponent();
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string adresse = txtAdresse.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(adresse))
            {
                System.Windows.MessageBox.Show("Veuillez saisir le nom et l'adresse.", "Erreur", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(txtValeur.Text, out int valeur) || !int.TryParse(txtSurface.Text, out int surface))
            {
                System.Windows.MessageBox.Show("La valeur et la surface doivent etre des nombres entiers.", "Erreur", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
                return;
            }

            if (valeur < 0 || surface <= 0)
            {
                System.Windows.MessageBox.Show("La valeur doit etre positive et la surface doit etre superieure a zero.", "Erreur", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
                return;
            }

            try
            {
                using Context context = new Context();
                Box nouvelleBox = new Box(nom, valeur, adresse, surface);

                context.Biens.Add(nouvelleBox);
                context.SaveChanges();

                System.Windows.MessageBox.Show("La Box a ete ajoutee avec succes.", "Confirmation", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
                txtNom.Clear();
                txtValeur.Clear();
                txtAdresse.Clear();
                txtSurface.Clear();
            }
            catch (Exception exception)
            {
                System.Windows.MessageBox.Show("Impossible d'ajouter la Box : " + exception.Message, "Erreur", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }
    }
}
