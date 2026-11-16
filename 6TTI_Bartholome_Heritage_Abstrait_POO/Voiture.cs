using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_Bartholome_Heritage_Abstrait_POO
{
    internal class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;

        public string Motorisation { get => _motorisation; set => _motorisation = value; }
        public bool Gps { get => _gps; set => _gps = value; }

        public Voiture(string modele, string marque, string couleur, decimal prix, string motorisation, bool gps) : base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }
        public override void AfficherCaracteristiques()
        {
            AfficherCaracteristiquesCommunes();
            Console.WriteLine($"Motorisation : {_motorisation} \nGPS : {_gps}");
        }
    }
}
