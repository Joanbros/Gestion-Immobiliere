using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Immobilière.Data.Models
{
    public class Prestataire
    {
        public int PrestataireId { get; set; }
        public string RaisonSociale { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }

        public Prestataire(string uneRaisonSociale, string unNom, string unPrenom, string unTelephone, string uneAdresse)
        {
            this.RaisonSociale = uneRaisonSociale;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Telephone = unTelephone;
            this.Adresse = uneAdresse;
        }
    }
}
