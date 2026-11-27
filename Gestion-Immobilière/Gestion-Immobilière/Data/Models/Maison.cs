using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Immobilière.Data.Models
{
    public class Maison : Logement
    {
        public int MaisonId { get; set; }
        public Maison(string unNom, int uneValeur, string uneAdresse, int uneSurface, int unNbPieces, int unNbChambre, bool uneCave, bool unParking)
            :base(unNom, uneValeur, uneAdresse, uneSurface, unNbPieces, unNbChambre, uneCave, unParking)
        {

        }

        public Maison()
        {

        }

        public override string ToString()
        {
            string cave = "Non";
            if (this.Cave == true)
            {
                cave = "Oui";
            }

            string parking = "Non";
            if (this.Parking == true)
            {
                parking = "Oui";
            }

            return "=========== " + this.Nom + " ===========" +
                   "\nAdresse : " + this.Adresse +
                   "\nValeur : " + this.Valeur +
                   "\nSurface : " + this.Surface +
                   "\nBénéfice net : " + calculerRentabiliteNetMensuel() + " €" +
                   "\nNombre de pièces : " + this.NbPieces +
                   "\nNombre de chambres : " + this.NbChambre +
                   "\nNombre de caves : " + cave +
                   "\nNombre de parking : " + parking;
        }
    }
}
