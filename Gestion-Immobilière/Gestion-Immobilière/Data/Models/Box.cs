using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Text;

namespace Gestion_Immobilière.Data.Models
{
    public class Box : Bien
    {
        public int BoxId { get; set; }
        public Box(string unNom, int uneValeur, string uneAdresse, int uneSurface)
            :base(unNom, uneValeur, uneAdresse, uneSurface)
        {

        }

        public override string ToString()
        {
            return "=========== " + this.Nom + " ===========" +
                   "\nAdresse : " + this.Adresse +
                   "\nValeur : " + this.Valeur +
                   "\nSurface : " + this.Surface +
                   "\nBénéfice net : " + calculerRentabiliteNetMensuel() + " €"; // A FIX
        }
    }
}
