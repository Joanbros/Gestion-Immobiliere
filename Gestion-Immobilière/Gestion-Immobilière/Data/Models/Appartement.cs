using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Immobilière.Data.Models
{
    public class Appartement : Logement
    {
        public int AppartementId { get; set; }
        public int Etage { get; set; }
        public int Assenceur { get; set; }
        public bool ChauffCommun { get; set; }

        public Appartement(string unNom, int uneValeur, string uneAdresse, int uneSurfrace, int unNbPieces, int unNbChambre, bool uneCave, bool unParking, int unEtage, int unAssenceur, bool unChauffCommun)
            :base(unNom, uneValeur, uneAdresse, uneSurfrace, unNbPieces, unNbChambre, uneCave, unParking)
        {
            this.Etage = unEtage;
            this.Assenceur = unAssenceur;
            this.ChauffCommun = unChauffCommun;
        }

        public override int estimerValeurBien()
        {
            int valeurTotal = 0;

            if (this.ChauffCommun == true)
            {
                valeurTotal += 6500;
            }
            if (this.Assenceur == 1)
            {
                valeurTotal += 5000;
            }
            if (this.Etage == 0)
            {
                valeurTotal -= 3000;
            }

            return base.estimerValeurBien() + valeurTotal;
        }

        public override string ToString()
        {
            return "=========== " + this.Nom + " ===========" +
                   "\nAdresse : " + this.Adresse +
                   "\nValeur : " + this.Valeur +
                   "\nSurface : " + this.Surface +
                   "\nBénéfice net : " + calculerRentabiliteNetMensuel() + " €" +
                   "\nNombre de pièces : " + this.NbPieces +
                   "\nNombre de chambres : " + this.NbChambre +
                   "\nCaves : " + (this.Cave ? "Oui" : "Non") +
                   "\nParking : " + (this.Parking ? "Oui" : "Non") +
                   "\nAscenseur : " + (this.Assenceur == 1 ? "Oui" : "Non") +
                   "\nChauffage Commun : " + (this.ChauffCommun ? "Oui" : "Non");
        }
    }
}
