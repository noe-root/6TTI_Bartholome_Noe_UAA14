namespace _6TTI_Bartholome_Heritage_Abstrait_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans mon programme !");
            Velo velo = new Velo("VTT", "Commencal", "Rouge", 10000, "VTT", true);
            Voiture voiture = new Voiture("C4", "Citroen", "Blanc", 15000, "Essence", true);
            Console.WriteLine("\nVoici les caractéristiques du vélo :");
            velo.AfficherCaracteristiques();
            Console.WriteLine("\nVoici les caractéristiques de la voiture :");
            voiture.AfficherCaracteristiques();
        }
    }
}
