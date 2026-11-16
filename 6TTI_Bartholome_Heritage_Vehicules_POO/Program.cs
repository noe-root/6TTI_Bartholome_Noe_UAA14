namespace _6TTI_Bartholome_Heritage_Vehicules_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans mon programme !");
            Vehicule vehicule = new Vehicule("2A4M", "Leopard", "Noir", 5300000);
            Velo velo = new Velo("VTT", "Commencal", "Rouge", 10000, "VTT", true);
            Voiture voiture = new Voiture("C4", "Citroen", "Blanc", 15000, "Essence", true);
            Console.WriteLine("\nVoici les caractéristiques du véhicule :");
            vehicule.AfficherCaracteristiques();
            Console.WriteLine("\nVoici les caractéristiques du vélo :");
            velo.AfficherCaracteristiques();
            Console.WriteLine("\nVoici les caractéristiques de la voiture :");
            voiture.AfficherCaracteristiques();
        }
    }
}
