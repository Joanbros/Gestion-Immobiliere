using System;
using System.Windows;
using System.Windows.Controls;
using Gestion_Immobilière.Data.DAL;
using Gestion_Immobilière.Data.Models;

namespace Gestion_Immobilière.View.Forms
{
    public partial class GererAppartementForm : Page
    {
        public GererAppartementForm()
        {
            InitializeComponent();
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string adresse = txtAdresse.Text.Trim();

            int valeur = int.Parse(txtValeur.Text);
            int surface = int.Parse(txtSurface.Text);

            int nbPieces = int.Parse(txtNbPiece.Text);
            int nbChambre = int.Parse(txtNbChambre.Text);
            bool cave = txtCave.IsChecked ?? false;
            bool parking = txtParking.IsChecked ?? false;

            int etage = int.Parse(txtEtage.Text.Trim());
            int ascenseur = int.Parse(txtAscenseur.Text.Trim());
            bool chauffCommun = txtChauffCommun.IsChecked ?? false;

            try
            {
                using Context context = new Context();
                Appartement nouvelAppart = new Appartement(nom, valeur, adresse, surface, nbPieces, nbChambre, cave, parking, etage, ascenseur, chauffCommun);

                context.Biens.Add(nouvelAppart);
                context.SaveChanges();

                System.Windows.MessageBox.Show("L'appartement a ete ajoutee avec succes.", "Confirmation", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
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

        private void txtSurface_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtEtage_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtCave_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void txtAscenseur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtValeur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
