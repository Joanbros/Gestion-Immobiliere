using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Immobilière.Data.Models
{
    public class Logement : Bien
    {
        public int LogementId { get; set; }
        public int NbPieces { get; set; }
        public int NbChambre { get; set; }
        public bool Cave { get; set; }
        public bool Parking { get; set; }

        public Logement() 
        {

        }

        public Logement(string unNom, int uneValeur, string uneAdresse, int uneSurface, int unNbPieces, int unNbChambre, bool uneCave, bool unParking)
            :base(unNom, uneValeur, uneAdresse, uneSurface)
        {
            this.NbPieces = unNbPieces;
            this.NbChambre = unNbChambre;
            this.Cave = uneCave;
            this.Parking = unParking;
        }

        public override int estimerValeurBien()
        {
            int valeurTotal = 0;

            if (this.Cave == true)
            {
                valeurTotal += 5000;
            }
            if (this.Parking == true)
            {
                valeurTotal += 8000;
            }
            valeurTotal += this.NbPieces * 2000;

            return base.estimerValeurBien() + valeurTotal;
        }
    }
}
