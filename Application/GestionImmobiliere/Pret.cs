using System;
using System.Collections.Generic;
using System.Text;

namespace GestionImmobiliere
{
    public class Pret
    {
        // Variables
        public int PretId { get; set; }
        public double Apport { get; set; }
        public double Montant { get; set; }
        public double TauxInteret { get; set; }
        public int Duree { get; set; }
        public DateTime DateDebut { get; set; }


        // Constructeur
        public Pret(double unApport, double unMontant, double unTauxInteret, int uneDuree, DateTime uneDateDebut)
        {
            this.Apport = unApport;
            this.Montant = unMontant;
            this.TauxInteret = unTauxInteret;
            this.Duree = uneDuree;
            this.DateDebut = uneDateDebut;
        }

        public Pret()
        {

        }

        // Méthodes
        public double calculerMensualite(double unMontant, double unTauxInteret, int uneDuree) /* source : ' https://www.angelotti.fr/infos-pratiques/blog/comment-calculer-les-mensualites-d-un-pret-immobilier ' */
        {
            double mensualite = ((unMontant * unTauxInteret) / 12) / (1 - (1 + (unTauxInteret / 12)) - uneDuree);
            return mensualite;
        }

        public int obtenirNbMoisRestant()
        {

            int nbMoisTotal = 0;


            int anneesEcoulees = DateTime.Now.Year - this.DateDebut.Year;
            int moisEcoulesDansAnnee = DateTime.Now.Month - this.DateDebut.Month;

            int nbMoisEcoules = (anneesEcoulees * 12) + moisEcoulesDansAnnee;

            // impossible que ce soit un nb négatif
            if (nbMoisEcoules < 0)
            {
                nbMoisEcoules = 0;
            }

            int nbMoisRestant = nbMoisTotal - nbMoisEcoules;

            if (nbMoisRestant < 0)
            {
                nbMoisRestant = 0;
            }

            return nbMoisRestant;
        }

        public double calculerCapitalRestantARembourser()
        {

            double capitalRestant;

            capitalRestant = obtenirNbMoisRestant() * calculerMensualite(this.Montant, this.TauxInteret, this.Duree);

            return capitalRestant;
        }

        public override string ToString()
        {
            return "=== Prêt" +
                   "\nApport : " + this.Apport + " €" +
                   "\nMensualité : " + this.calculerMensualite(this.Montant, this.TauxInteret, this.Duree) + " €" +
                   "\nDurée : " + this.Duree +
                   "\nDate début : " + this.DateDebut +
                   "\nCapital restant : " + calculerCapitalRestantARembourser() + " €";
        }
    }
}
