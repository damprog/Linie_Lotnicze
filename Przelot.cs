using Linie_Lotnicze_Przemyslaw_Pawluk.Interfejsy;
using Linie_Lotnicze_Przemyslaw_Pawluk.Samoloty;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    class Przelot : IPrzelot
    {
        public string dzienOdlotu { get; set; }
        public string godzinaOdlotu { get; set; }
        public double czasLotuMM { get; set; }
        public bool przesiadka { get; set; }
        public ISamolot samolot { get; set; }
        public int aktualnaIlosc { get; set; } = 0;

        public Przelot(string dzienOdlotu, string godzinaOdlotu, double czasLotuMM, bool przesiadka, string symbolSamolotu)
        {
            this.dzienOdlotu = dzienOdlotu;
            this.godzinaOdlotu = godzinaOdlotu;
            this.czasLotuMM = czasLotuMM;
            this.przesiadka = przesiadka;
            //Fabryka prosta do utworzenia odpowiedniego samolotu
            FabrykaSamolotow fs = new FabrykaSamolotow();
            this.samolot = fs.StworzSamolot(symbolSamolotu);
        }

        public void DodajPasazerow(int ile)
        {
            this.aktualnaIlosc += ile;
        }

        public void OdejmijPasazerow(int ile)
        {
            this.aktualnaIlosc -= ile;
        }

        public bool SprawdzDostepnosc(int ileBiletow)
        {
            return (ileBiletow + aktualnaIlosc) <= samolot.liczbaMiejsc;
        }

        public void WyswietlInfo()
        {
            Console.WriteLine($"Dzień odlotu: {dzienOdlotu},\n" +
                $"Start o: {godzinaOdlotu},\n" +
                $"Długość lotu: {czasLotuMM}");
            if (przesiadka == true) Console.WriteLine("Lot z przesiadką");
            
        }

        public string DajInfo()
        {
            string info = $"Dzień odlotu: {dzienOdlotu},\n" +
                $"Start o: {godzinaOdlotu},\n" +
                $"Długość lotu: {czasLotuMM}";
            if (przesiadka == true) info +="Lot z przesiadką";
            return info;
        }
    }
}
