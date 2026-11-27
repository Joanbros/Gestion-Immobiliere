using System.Windows.Controls;

namespace Gestion_Immobilière.View.Forms
{
    /// <summary>
    /// Permet de choisir le type de bien puis d'afficher son formulaire.
    /// </summary>
    public partial class GererBienForm : Page
    {
        public GererBienForm()
        {
            InitializeComponent();

            frmBien.Navigate(new GererBoxForm());
        }

        private void CboTypesBien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboTypesBien.SelectedIndex == 0 && frmBien != null)
            {
                frmBien.Navigate(new GererBoxForm());
            }
            else if (cboTypesBien.SelectedIndex == 1 && frmBien != null)
            {
                frmBien.Navigate(new GererAppartementForm());
            }
            else if (cboTypesBien.SelectedIndex == 2 && frmBien != null)
            {
                frmBien.Navigate(new GererMaisonForm());
            }
        }
    }
}
