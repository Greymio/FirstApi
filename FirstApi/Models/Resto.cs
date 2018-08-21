using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApi.Models
{
    public class Resto
    {
        private string _Nom;
        private int _nbPlaces;
        private float _PrixMoyen;
        private string _Adresse;
        private List<string> _JourOuverture;
        private int _cote;

        public int Cote
        {
            get { return _cote; }
            set { _cote = value; }
        }

        public List<string> JourOuverture
        {
            get { return _JourOuverture=_JourOuverture?? new List<string>(); }
            set { _JourOuverture = value; }
        }

        public string Adresse
        {
            get { return _Adresse; }
            set { _Adresse = value; }
        }

        public float PrixMoyen
        {
            get { return _PrixMoyen; }
            set { _PrixMoyen = value; }
        }

        public int NbPlaces
        {
            get { return _nbPlaces; }
            set { _nbPlaces = value; }
        }
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }
        
    }
}