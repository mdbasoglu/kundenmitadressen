using System;
namespace Uebung55_KundeMitAdressen_pbbgh20aba
{
    class Kunde
    {
        private string name;
        private Adresse rechnungsadresse;
        private Adresse lieferadresse;


        public string Name { get => name; set => name = value; }
        public Adresse Rechnungsadresse { get => rechnungsadresse; set => rechnungsadresse = value; }
        public Adresse Lieferadresse { get => lieferadresse; set => lieferadresse = value; }


        public Kunde(string name, Adresse rechnungsadresse)
        {
            Name = name;
            Rechnungsadresse = rechnungsadresse;
            Lieferadresse = new Adresse(rechnungsadresse.Strasse, rechnungsadresse.Ort);
        }


        public Kunde(string name, Adresse rechnungsadresse, Adresse lieferadresse)
        {
            Name = name;
            Rechnungsadresse = rechnungsadresse;
            Lieferadresse = lieferadresse;
        }

        public override string ToString()
        {
            return $"Kunde [ Name ={Name}, Rechnungsadresse={Rechnungsadresse}, Lieferadresse={Lieferadresse} ]";
        }



    }
}
