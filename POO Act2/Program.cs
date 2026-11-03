namespace POO_Act2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans mon programme !");                        
            string choix;

            do
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Véhicules");
                Console.WriteLine("2. Entraînements");
                Console.WriteLine("0. Quitter");
                Console.Write("Ton choix : ");
                choix = Console.ReadLine();

                Console.WriteLine();

                if (choix == "1")
                {
                    Vehicule[] garage = new Vehicule[]
                    {
                        new Vehicule("1-ABC-123", "Renault", "Clio", 45f, 20f),
                        new Vehicule("2-DEF-456", "Peugeot", "208", 40f, 15f)
                    };

                    foreach (Vehicule voiture in garage)
                    {
                        Console.WriteLine(voiture.TypeVehicule());

                        Console.WriteLine("Carburant : " + voiture.NiveauJaugeCarburant + " litres");

                        voiture.NiveauJaugeCarburant -= 5f;
                        Console.WriteLine("Après consommation : " + voiture.NiveauJaugeCarburant + " litres");

                        voiture.AjouterCarburant(10f);
                        Console.WriteLine("Après ajout : " + voiture.NiveauJaugeCarburant + " litres");

                        voiture.FaireLePlein();
                        Console.WriteLine("Après le plein : " + voiture.NiveauJaugeCarburant + " litres");

                        Console.WriteLine();
                    }
                }
                else if (choix == "2")
                {
                    Entrainement[] entrainements = new Entrainement[]
                    {
                        new Entrainement("Dupont", "Lucas", 5000, 1500),
                        new Entrainement("Martin", "Emma", 5000, 1800)
                    };

                    int meilleurTemps = 1200;

                    foreach (Entrainement course in entrainements)
                    {
                        Console.WriteLine(
                            course.PrenomCoureur + " " + course.NomCoureur);

                        Console.WriteLine("Vitesse moyenne : " + course.VitesseMoyenne() + " km/h");

                        Console.WriteLine("Écart avec le meilleur : " + course.EcartParRapportAuMeilleur(meilleurTemps) + " secondes");

                        Console.WriteLine();
                    }
                }
                else if (choix != "0")
                {
                    Console.WriteLine("Choix incorrect.");
                }

                if (choix != "0")
                {
                    Console.WriteLine("Appuie sur Entrée pour revenir au menu.");
                    Console.ReadLine();
                }

            } while (choix != "0");

            Console.WriteLine("Au revoir !");
        }
    }
}
