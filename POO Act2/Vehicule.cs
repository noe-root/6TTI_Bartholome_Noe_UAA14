using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Act2
{
    internal class Vehicule
    {
        private string _plaque;
        private string _marque;
        private string _modele;
        private float _capaciteMaximumReservoir;
        private float _niveauJaugeCarburant;
        public string Plaque { get => _plaque; set => _plaque = value; }
        public string Marque { get => _marque; }
        public string Modele { get => _modele; }
        public float CapaciteMaximumReservoir { get => _capaciteMaximumReservoir; }
        public float NiveauJaugeCarburant
        {
            get
            {
                return _niveauJaugeCarburant;
            }

            set
            {
                if (value < 0)
                {
                    _niveauJaugeCarburant = 0;
                }
                else if (value > _capaciteMaximumReservoir)
                {
                    _niveauJaugeCarburant = _capaciteMaximumReservoir;
                }
                else
                {
                    _niveauJaugeCarburant = value;
                }
            }
        }
        public Vehicule(string plaque, string marque, string modele, float capaciteMaximumReservoir, float niveauJaugeCarburant)
        {
            _plaque = plaque;
            _marque = marque;
            _modele = modele;
            _capaciteMaximumReservoir = capaciteMaximumReservoir;
            _niveauJaugeCarburant = niveauJaugeCarburant;
        }
        public string TypeVehicule()
        {
            return $"Plaque: {_plaque}, Marque: {_marque}, Modèle: {_modele}, Capacité maximale du réservoir: {_capaciteMaximumReservoir} litres, Niveau de carburant: {_niveauJaugeCarburant} litres";
        }
        public void FaireLePlein()
        {
            NiveauJaugeCarburant = CapaciteMaximumReservoir;
        }
        public void AjouterCarburant(float nbrCarburant)
        {
            if (nbrCarburant > 0)
            {
                NiveauJaugeCarburant += nbrCarburant;
            }
        }
    }
}
