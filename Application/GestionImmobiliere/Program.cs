using System;
using System.Globalization;
using System.Text;

namespace GestionImmobiliere
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            sortieConsole();
 
            using (var db = new Context())
            {
                // Creation d'un nouveau Bien
                Console.Write("Entrez le nom d'un nouveau bien : ");
                var name = Console.ReadLine();
 
                var bien = new Box(name, 15000, "chez moi", 10);
                db.Biens.Add(bien);
                db.SaveChanges();
 
                // Affichage de tous les biens de la base
                var query = from b in db.Biens
                            orderby b.Nom
                            select b;
 
                Console.WriteLine("Tous les biens dans la base :\n");
                foreach (var item in query)
                {
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
                Console.WriteLine("Appuyez sur une touche pour quitter...");
                Console.ReadKey();
            }

        }

        public static void sortieConsole()
        {
            // Création des objets avec les valeurs de l'exemple
            Box garage = new Box("Garage Oullins", 12000, "128 avenue de gaulle, 07100 Annonay", 12);
            Maison manoir = new Maison("Manoir Mathat", 5500000, "hameau des guidons, 07690 Villeocance", 220, 10, 6, true, true);
            Appartement appart = new Appartement("L'appart", 270000, "53 boulevard des canards, 69007 Lyon", 78, 4, 3, true, true, 9, 1, true);

            Pret pretGarage = new Pret(2000, 200, 0.0, 50, new DateTime(2019, 9, 1));
            Pret pretAppart = new Pret(30000, 1000, 0.0, 240, new DateTime(2012, 4, 22));

            Bail bailManoir = new Bail(4500, new DateTime(2019, 10, 25), new DateTime(2022, 2, 20));
            Bail bailAppart = new Bail(1200, new DateTime(2020, 10, 25), new DateTime(2022, 2, 20));

            Locataire locPinot = new Locataire("Pinot", "Julian", 25, "UX Designer");
            Locataire locBroutier = new Locataire("Broutier", "Thomas", 25, "Entrepreneur");

            // Sortie
            Console.WriteLine(garage);
            Console.WriteLine(pretGarage);
            Console.WriteLine();

            Console.WriteLine(manoir);
            Console.WriteLine(bailManoir);
            Console.WriteLine(locPinot);
            Console.WriteLine();

            Console.WriteLine(appart);
            Console.WriteLine(pretAppart);
            Console.WriteLine(bailAppart);
            Console.WriteLine(locBroutier);
            Console.WriteLine(locPinot);
            Console.WriteLine();
        }
    }
}
