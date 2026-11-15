namespace _6TTI_Bartholome_AllumerLampe_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans mon programme !");
            string recommencer = "";

            do
            {
                Lampe[] lampes =
                {
                    new Lampe("Rouge", false, 1),
                    new Lampe("Bleue", false, 2),
                    new Lampe("Verte", false, 3),
                    new Lampe("Jaune", false, 4)
                };

                Interrupteur[] interrupteurs =
                {
                    new Interrupteur("Blanc", 101, lampes[0]),    
                    new Interrupteur("Blanc", 102, lampes[1]),
                    new Interrupteur("Blanc", 103, lampes[2]),
                    new Interrupteur("Blanc", 104, lampes[3])
                };

                Console.WriteLine("Test 1 :");
                Console.Write("Entrez le code d'une lampe (1 à 4) : ");

                int code;

                while (!int.TryParse(Console.ReadLine(), out code) || code < 1 || code > 4)
                {
                    Console.Write("Code invalide. Réessayez : ");
                }

                for (int i = 0; i < lampes.Length; i++)
                {
                    if (lampes[i].Code == code)
                    {
                        interrupteurs[i].Actionner();

                        Console.WriteLine(lampes[i].InfoLampe());
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Test 2 :");

                for (int i = 0; i < lampes.Length; i++)
                {
                    if (lampes[i].Statut == true)
                    {
                        lampes[i].Eteindre();
                        interrupteurs[i].Statut = false;
                    }

                    interrupteurs[i].Actionner();

                    Console.WriteLine(lampes[i].InfoLampe());
                }

                Console.WriteLine("\nToutes les lampes sont allumées.");
                Console.Write("\nVoulez-vous recommencer ? (O/N) : ");
                recommencer = Console.ReadLine();
            } while (recommencer.ToUpper() == "O");

        Console.WriteLine("\nFin du programme.");
        }
    }    
}
