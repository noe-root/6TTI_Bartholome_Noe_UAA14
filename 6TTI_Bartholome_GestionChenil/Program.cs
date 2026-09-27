using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _6TTI_Bartholome_GestionChenil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables pour les informations des chiens
            string nomChien1 = "";
            string raceChien1 = "";
            int ageChien1 = 0;
            string nomChien2 = "";
            string raceChien2 = "";
            int ageChien2 = 0;
            string nomChien3 = "";
            string raceChien3 = "";
            int ageChien3 = 0;
            string infoUser;
            do
            {
                //Lecture des informations pour les trois chiens
                Console.Clear();
                Console.WriteLine("=== Bienvenu dans mon chenil ===");                       
                Console.WriteLine("=== Chien 1 ===");
                do
                {
                    Console.WriteLine("Entrez le nom du chien 1: ");
                    nomChien1 = Console.ReadLine();                
                }
                while (nomChien1 == "");
                do
                {
                    Console.WriteLine("Entrez la race du chien 1: ");
                    raceChien1 = Console.ReadLine();                
                }
                while (raceChien1 == "");
                do
                {
                    Console.WriteLine("Entrez l'âge du chien 1: ");                                            
                }
                while (!int.TryParse(Console.ReadLine(), out ageChien1) || ageChien1 <= 0);
                Console.WriteLine("=== Chien 2 ===");
                do
                {
                    Console.WriteLine("Entrez le nom du chien 2: ");
                    nomChien2 = Console.ReadLine();                
                }
                while (nomChien2 == "");
                do
                {
                    Console.WriteLine("Entrez la race du chien 2: ");
                    raceChien2 = Console.ReadLine();                
                }
                while (raceChien2 == "");
                do
                {
                    Console.WriteLine("Entrez l'âge du chien 2: ");                           
                }
                while (!int.TryParse(Console.ReadLine(), out ageChien2) || ageChien2 <= 0);
                Console.WriteLine("=== Chien 3 ===");
                do
                {
                    Console.WriteLine("Entrez le nom du chien 3: ");
                    nomChien3 = Console.ReadLine();                
                }
                while (nomChien3 == "");
                do
                {
                    Console.WriteLine("Entrez la race du chien 3: ");
                    raceChien3 = Console.ReadLine();
                
                }
                while (raceChien3 == "");
                do
                {
                    Console.WriteLine("Entrez l'âge du chien 3: ");
                }
                while (!int.TryParse(Console.ReadLine(), out ageChien3) || ageChien3 <= 0);
                // Création des objets Chien avec les informations saisies
                Chien monChien1 = new Chien(nomChien1, raceChien1, ageChien1);
                Chien monChien2 = new Chien(nomChien2, raceChien2, ageChien2);            
                Chien monChien3 = new Chien(nomChien3, raceChien3, ageChien3);
                Console.Clear();
                // Affichage des informations des chiens
                Console.WriteLine("=== Informations sur les chiens ===");
                Console.WriteLine("=== Chien 1 ===");
                Console.WriteLine(monChien1.InfoChien());
                Console.WriteLine("=== Chien 2 ===");
                Console.WriteLine(monChien2.InfoChien());
                Console.WriteLine("=== Chien 3 ===");
                Console.WriteLine(monChien3.InfoChien());
                Console.WriteLine("Souhaitez-vous recommencer ? (espace pour recommencer, autre touche pour quitter) ");
                infoUser = Console.ReadLine();
            }
            while (infoUser == " ");
        }
    }
}
