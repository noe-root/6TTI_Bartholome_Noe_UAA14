using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_Bartholome_AllumerLampe_POO
{
    internal class Lampe
    {
        private string _couleur;
        private bool _statut;
        private int _code;

        public string Couleur { get => _couleur; }
        public bool Statut { get => _statut; set => _statut = value; }
        public int Code { get => _code; }
        public Lampe(string couleur, bool statut, int code)
        {
            _couleur = couleur;
            _statut = statut;
            _code = code;
            statut = false;
        }
        public string InfoLampe()
        {
            return $"La lampe est de couleur {_couleur}, son statut est {_statut} et son code est {_code}.";
        }
        public void Allumer()
        {
            _statut = true;
        }
        public void Eteindre()
        {
            _statut = false;
        }
    }
}
