using System;
namespace Uebung55_KundeMitAdressen_pbbgh20aba
{
    class Adresse
    {
        private string strasse;
        private string ort;


        public string Strasse { get => strasse; set => strasse = value; }
        public string Ort { get => ort; set => ort = value; }

        public Adresse(string strasse, string ort)
        {
            Strasse = strasse;
            Ort = ort;
        }

        public override string ToString()
        {
            return $"Adresse [Straße={Strasse}, Ort={ort} ]";
        }



    }
}
