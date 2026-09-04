using System.Security.Cryptography.X509Certificates;

namespace _6TTI_Bartholome_Classification_de_triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            string infos;           
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;            
            bool ok = false;
            
            //Personalisation de la console
            ConsoleColor fond = UtilitairesConsole.LireCouleur("Couleur de fond   (ex: Black, DarkBlue...) : ");
            ConsoleColor police = UtilitairesConsole.LireCouleur("Couleur de police (ex: White, Yellow...)   : ");
            UtilitairesConsole.PersonnaliserConsole(fond, police);

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés => A FAIRE
                c1 = UtilitairesConsole.LireDouble("Entrez le premier côté : ");
                c2 = UtilitairesConsole.LireDouble("Entrez le deuxième côté : ");
                c3 = UtilitairesConsole.LireDouble("Entrez le troisième côté : ");

                // ordonner les côtés => APPEL ORDONNECOTES
                MethodesDuProjet.OrdonneCotes(ref c1, ref c2, ref c3);
                // série de test (voir consignes)
                if (MethodesDuProjet.Triangle(c1,c2,c3)) // si on a un triangle...
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    MethodesDuProjet.PrepareAffichage(true, "triangle", out infos);
                    Console.WriteLine(infos);

                    // vérification équilatéral
                    if (MethodesDuProjet.Equi(c1,c2,c3))// si on a un triangle équilatéral...
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        MethodesDuProjet.PrepareAffichage(true, "equilateral", out infos);
                        Console.WriteLine(infos);
                    }
                    else
                    {
                        // vérification triangle rectangle
                        ok = MethodesDuProjet.TriangleRectangle(c1, c2, c3);
                        if (ok)// si on a un triangle rectangle...
                        {
                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            MethodesDuProjet.PrepareAffichage(true, "rectangle", out infos);
                            Console.WriteLine(infos);
                        }
                        else
                        {
                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            MethodesDuProjet.PrepareAffichage(false, "rectangle", out infos);
                            Console.WriteLine(infos);                            
                        }
                        // vérification du cas isocèle et affichage dans le cas positif                                                
                        MethodesDuProjet.Isocele(c1,c2, c3, ref ok);
                        if (ok)
                        {
                        MethodesDuProjet.PrepareAffichage(true, "isocele", out infos);
                        Console.WriteLine(infos);
                        }                        
                        
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    MethodesDuProjet.PrepareAffichage(false, "triangle", out infos);
                    Console.WriteLine(infos);
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
