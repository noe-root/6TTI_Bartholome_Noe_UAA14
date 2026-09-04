using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_Bartholome_Classification_de_triangles
{
    public static class UtilitairesConsole
    {
        public static double LireDouble(string message)
        {
            double valeur;
            bool ok;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                ok = double.TryParse(input, out valeur);
                if (!ok)
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre valide.");
                }
            } while (!ok);
            return valeur;
        }
        public static ConsoleColor LireCouleur(string message)
        {
            ConsoleColor couleur;
            bool ok;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                ok = Enum.TryParse(input, true, out couleur) && Enum.IsDefined(typeof(ConsoleColor), couleur);
                if (!ok)
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer une couleur valide.");
                }
            } while (!ok);
            return couleur;
        }
        public static void PersonnaliserConsole(ConsoleColor fond, ConsoleColor police)
        {
            Console.BackgroundColor = fond;
            Console.ForegroundColor = police;
            Console.Clear();
        }
    }

}
