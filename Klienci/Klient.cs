using System;
using System.Collections.Generic;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    class Klient : IKlient
    {
        public string imie { get; set; }

        public string nazwisko { get; set; }

        public List<IBilet> bilety { get; set; }
        public List<IRezerwacja> rezerwacje { get; set; }
        public Klient(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
           /* bilety = new List<IBilet>();
            rezerwacje = new List<IRezerwacja>();*/
        }

        public void PokazBilety()
        {
            Console.WriteLine($"{imie}: Bilety");
            foreach (IBilet b in bilety)
            {
                b.WyswietlInfo();
            }
        }

        public void PokazRezerwacje()
        {
            Console.WriteLine($"{imie}: Rezerwacje");
            foreach (IRezerwacja r in rezerwacje)
            {
                r.WyswietlInfo();
            }
        }

        public void Rezerwuj(Rezerwacja rezerwacja)
        {
            rezerwacje.Add(rezerwacja); 
            rezerwacja.zarezerwowanyBilet.przelot.OdejmijPasazerow(rezerwacja.zarezerwowanyBilet.liczbaDoroslych + rezerwacja.zarezerwowanyBilet.liczbaDzieci);
            Console.WriteLine("Zarezerwowano bilet");
        }

        public void Kup(IBilet bilet)
        {
            bilet.przelot.OdejmijPasazerow(bilet.liczbaDoroslych + bilet.liczbaDzieci);
            bilety.Add(bilet);
            Console.WriteLine("Zakupiono bilet");
        }
        public void Kup(IBilet bilet, Rezerwacja rezerwacja)
        {
            ZdejmijRezerwacje(rezerwacja);
            bilet.przelot.OdejmijPasazerow(bilet.liczbaDoroslych + bilet.liczbaDzieci);
            bilety.Add(bilet);
            Console.WriteLine("Zakupiono bilet z rezerwacji");
        }

        public void ZdejmijRezerwacje(Rezerwacja rezerwacja)
        {
            //Zlikwidowanie miejsc widmo
            rezerwacja.zarezerwowanyBilet.przelot.DodajPasazerow(rezerwacja.zarezerwowanyBilet.liczbaDoroslych + rezerwacja.zarezerwowanyBilet.liczbaDzieci);

            rezerwacje.Remove(rezerwacja);
            Console.WriteLine("Wykorzystano rezerwację");
        }
    }
}
