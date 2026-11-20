using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Immobilière.Data.Models
{
    public static class UtilSaisie
    {
        public static Pret saisirPretPourBien()
        {
            Console.WriteLine("Saisir le prêt pour le bien :");
            Console.WriteLine("apport : ");
            double apport = double.Parse(Console.ReadLine());

            Console.WriteLine("montant : ");
            double montant = double.Parse(Console.ReadLine());

            Console.WriteLine("tauxInteret : ");
            double tauxInteret = double.Parse(Console.ReadLine());

            Console.WriteLine("duree : ");
            int duree = int.Parse(Console.ReadLine());

            Console.WriteLine("dateDebut : ");
            DateTime dateDebut = DateTime.Parse(Console.ReadLine());

            Pret cePret = new Pret(apport, montant, tauxInteret, duree, dateDebut);

            return cePret;
        }
    }
}
