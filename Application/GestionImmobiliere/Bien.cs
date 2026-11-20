using System;
using System.Collections.Generic;
using System.Text;

namespace GestionImmobiliere
{
    public class Bien
    {
        public int BienId { get; set; }
        public string Nom { get; set; }
        public int Valeur { get; set; }
        public string Adresse { get; set; }
        public int Surface { get; set; }

        public List<Bail> Bails { get; set; }
        public List<Pret> Prets { get; set; }
        public List<Intervention> Interventions { get; set; }

        public Bien(string unNom, int uneValeur, string uneAdresse, int uneSurface)
        {
            this.Nom = unNom;
            this.Valeur = uneValeur;
            this.Adresse = uneAdresse;
            this.Surface = uneSurface;

            this.Bails = new List<Bail>();
            this.Prets = new List<Pret>();
            this.Interventions = new List<Intervention>();
        }

        public Bien()
        {

        }

        public double calculerRentabiliteNetMensuel()
        {
            double loyerTotal = 0;
            double mensualiteTotal = 0;

            foreach (Bail lesBails in Bails)
            {
                loyerTotal += lesBails.Loyer;
            }

            foreach (Pret pret in Prets)
            {
                mensualiteTotal += pret.calculerMensualite(pret.Montant, pret.TauxInteret, pret.Duree);
            }

            loyerTotal = loyerTotal - mensualiteTotal;

            return loyerTotal;
        }

        public virtual int estimerValeurBien()
        {
            int valeurTotal = 1400 * this.Surface;
            return valeurTotal;
        }
    }
}
