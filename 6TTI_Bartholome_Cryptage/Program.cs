namespace _6TTI_Bartholome_Cryptage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phraseClaire = "";
            string cleCryptage;
            string[,] matriceVigenere;
            string[,] matriceAffine;
            string texteMatrice;
            int coefficientA;
            int coefficientB;
            bool saisieValide;
            int choixUser;
            string infoUser;

            Console.WriteLine("Bienvenue dans le programme de chiffrement !");            
            do
            {
                Console.WriteLine("Voulez-vous chiffrer une phrase avec le chiffrement de Vigenère et le chiffrement affine ? (1 / 2)");
                choixUser = int.Parse(Console.ReadLine());
                Console.Write("Veuillez saisir la phrase à chiffrer : ");
                phraseClaire = Console.ReadLine() ?? "";
                if (choixUser == 1)
                {
                    do
                    {
                        Console.Write("Veuillez saisir la clé de Vigenère : ");
                        cleCryptage = Console.ReadLine() ?? "";

                        MethodeProjet.NettoyagePhraseVigenere(ref phraseClaire, ref cleCryptage);

                        if (phraseClaire.Length == 0 || cleCryptage.Length == 0)
                        {
                            Console.WriteLine("La phrase et la clé doivent contenir au moins une lettre.");
                        }
                    }while (phraseClaire.Length == 0 || cleCryptage.Length == 0);
                    MethodeProjet.CryptVigenere(phraseClaire,cleCryptage,out matriceVigenere);
                    Console.WriteLine("\nMatrice du chiffrement de Vigenère :");
                    MethodeProjet.ConcateneMatrice(matriceVigenere, out texteMatrice);
                    Console.WriteLine(texteMatrice);
                
                }
                else
                {
                    MethodeProjet.NettoyagePhraseAffine(ref phraseClaire);
                    do
                    {
                        Console.Write("Veuillez saisir le coefficient a : ");
                        saisieValide = int.TryParse(Console.ReadLine(), out coefficientA);

                        if (!saisieValide|| coefficientA < 1|| coefficientA > 25|| coefficientA % 2 == 0|| coefficientA == 13)
                        {
                            saisieValide = false;
                            Console.WriteLine("Le coefficient a doit être impair, compris entre 1 et 25 et différent de 13.");
                        }
                    }
                    while (!saisieValide);
                    do
                    {
                        Console.Write("Veuillez saisir le coefficient b : ");
                        saisieValide = int.TryParse(Console.ReadLine(), out coefficientB);

                        if (!saisieValide || coefficientB < 0 || coefficientB > 25)
                        {
                            saisieValide = false;
                            Console.WriteLine("Le coefficient b doit être compris entre 0 et 25.");
                        }
                    }while (!saisieValide);
                    MethodeProjet.CryptAffine(phraseClaire,coefficientA,coefficientB,out matriceAffine);
                    Console.WriteLine("Matrice du chiffrement affine :");
                    MethodeProjet.ConcateneMatrice(matriceAffine, out texteMatrice);
                    Console.WriteLine(texteMatrice);                
                }
                Console.WriteLine("Voulez-vous recommencer le programme ? (espace pour oui | autres touches pour non) ");
                infoUser = Console.ReadLine();
            }
            while (infoUser == " ");


            

        }
    }
}
