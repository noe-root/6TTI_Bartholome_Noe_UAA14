using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_Bartholome_Heritage_Vehicules_POO
{
    internal class Vehicule
    {
        protected string _modele;
        protected string _marque;
        protected string _couleur;
        protected decimal _prix;

        protected string Modele { get => _modele; }
        protected string Marque { get => _marque; }
        protected string Couleur { get => _couleur; set => _couleur = value; }
        protected decimal Prix { get => _prix; set => _prix = value; }

        public Vehicule(string modele, string marque, string couleur, decimal prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }
        public virtual void AfficherCaracteristiques()
        {
            Console.WriteLine($"Modèle : {_modele} \nMarque : {_marque} \nCouleur : {_couleur} \nPrix : {_prix} ");            
        }
    }
}
