using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_Bartholome_AllumerLampe_POO
{
    internal class Interrupteur
    {
        private string _couleur;
        private bool _statut;
        private int _code;
        private Lampe _lampeLier;

        public string Couleur { get => _couleur; }
        public bool Statut { get => _statut; set => _statut = value; }
        public int Code { get => _code; }
        public Lampe LampeLier { get => _lampeLier; set => _lampeLier = value;  }
        public Interrupteur(string couleur, int code, Lampe lampe)
        {
            _couleur = couleur;
            _code = code;
            _lampeLier = lampe;
            _statut = false;
        }
        public void Actionner()
        {
            if (_lampeLier == null)
            {
                Console.WriteLine(
                    "Aucune lampe n'est reliée à cet interrupteur."
                );

                return;
            }

            if (_lampeLier.Statut)
            {
                _lampeLier.Eteindre();
            }
            else
            {
                _lampeLier.Allumer();
            }

            _statut = _lampeLier.Statut;
        }

    }
}
