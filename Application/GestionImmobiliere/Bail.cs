using System;
using System.Collections.Generic;
using System.Text;

namespace GestionImmobiliere
{
    public class Bail
    {
        public int BailId { get; set; }
        public double Loyer { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }

        public Bail(double unLoyer, DateTime uneDateDebut, DateTime? uneDateFin)
        {
            this.Loyer = unLoyer;
            this.DateDebut = uneDateDebut;
            this.DateFin = uneDateFin;
        }

        public Bail()
        {

        }

        public override string ToString()
        {
            return "=== Bail" +
                   "\nLoyer : " + this.Loyer + " €" +
                   "\nDate début : " + this.DateDebut +
                   "\nDate début : " + this.DateFin;

        }
    }
}
