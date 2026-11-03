using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Act2
{
    internal class Entrainement
    {
        private string _nomCoureur;
        private string _prenomCoureur;
        private int _distance;
        private int _temps;

        public string NomCoureur { get => _nomCoureur; }
        public string PrenomCoureur { get => _prenomCoureur; }
        public int Distance { get => _distance; }
        public int Temps { get => _temps; }
        public Entrainement(string nomCoureur, string prenomCoureur,int distance, int temps)
        {
            _nomCoureur = nomCoureur;
            _prenomCoureur = prenomCoureur;
            _distance = distance;
            _temps = temps;
        }
        public double VitesseMoyenne()
        {
            if (_temps <= 0)
            {
                return 0;
            }          
            return (double)_distance / _temps * 3.6;
        }
        public int EcartParRapportAuMeilleur(int meilleurTemps)
        {
            return _temps - meilleurTemps;
        }
    }
}
