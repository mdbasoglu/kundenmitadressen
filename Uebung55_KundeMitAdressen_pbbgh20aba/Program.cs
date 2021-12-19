using System;

namespace Uebung55_KundeMitAdressen_pbbgh20aba
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Adresse akunde1 = new Adresse("Hauptstraße", "Neustadt");

            //Kunde1
            Kunde k1 = new Kunde("Maier", akunde1);
            Console.WriteLine(k1);

            //Kunde2
            Kunde k2 = new Kunde("Schmidt", new Adresse("Bahnhofstraße", "Frankfurt"));
            Console.WriteLine(k2);

            //Kunde3
            Kunde k3 = new Kunde("Schulz", new Adresse("Lindenstaße", "München"));
            Console.WriteLine(k3);

            //Kunde 3 ändert seinen Namen Bauer
            k3.Name = "Bauer";
            Console.WriteLine("Kunde k3 mit neuen Namen: " + k3);

            //Kunde 2 zieht nach Stuttgart, Buchenstraße
            k2.Rechnungsadresse.Ort = "Stuttgart";
            k2.Rechnungsadresse.Strasse = "Buchenstraße";
            //oder
            k2.Rechnungsadresse = new Adresse("Stuttgart", "Buchenstraße");
            Console.WriteLine("Kunde K2 mit neue Adresse: " + k2);

            //Kunde 1 zieht innerhalb Neustadts in die Mozartstraße um
            k1.Rechnungsadresse.Strasse = "Mozartstraße";
            Console.WriteLine("Kunde k1 mit neuer Straße: " + k1);


            Console.WriteLine(k1.Lieferadresse.Ort);






        }
    }
}
