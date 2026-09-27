using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_Bartholome_GestionChenil
{
    internal class Chien
    {
        private string _nom;
        private string _race;
        private int _age;
        public Chien(string nom, string race, int age)
        {
            _nom = nom;
            _race = race;
            _age = age;
        }
        public string InfoChien()
        {
            return "Nom: " + _nom + "\n" + "Race: " + _race + "\n" + "Age: " + _age + " ans";
        }
    }
}
