using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGIT
{
    class CD
    {
        private List<Brano> _brani;
        private string _titolo;
        private string _autore;

        public CD(string autore, string titolo)
        {
            _brani = new List<Brano>();

        }

        public string Titolo
        {
            get { return _titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Titolo non valido");


                _titolo = value;
            }
        }
        public string Autore
        {
            get { return _autore; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Autore non valido");


                _autore = value;
            }
        }
        public override string ToString()
        {
            string titoli = "";
            foreach (Brano b in _brani)
            {
                titoli += "" + b.Titolo;
            }

            return titoli;
        }
        public float Durata()
        {
            float durata = 0;
            foreach (Brano b in _brani)
            {
                durata += b.Durata;
            }

            return durata;
        }
    }
}
