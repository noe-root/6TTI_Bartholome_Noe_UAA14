using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_Bartholome_Heritage_Abstrait_POO
{
    internal class Velo : Vehicule
    {
        private string _type;
        private bool _estElectrique;

        public string Type { get => _type; }
        public bool EstElectrique { get => _estElectrique; set => _estElectrique = value; }

        public Velo(string modele, string marque, string couleur, decimal prix, string type, bool estElectrique) : base(modele, marque, couleur, prix)
        {
            _type = type;
            _estElectrique = estElectrique;
        }

        public override void AfficherCaracteristiques()
        {
            AfficherCaracteristiquesCommunes();
            Console.WriteLine($"Type : {_type} \nEst électrique : {_estElectrique}");
        }
    }
}
