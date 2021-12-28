using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    class Klient : IKlient
    {
        public string imie { 
            get { return imie; }
            set { imie = value; }
        }

        public string nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public Klient(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public List<IBilet> bilety { get; set; }
        public List<IRezerwacja> rezerwacje { get; set; }

        public void PokazBilety()
        {
            Console.WriteLine($"{imie}: Bilety");
            foreach (IBilet b in bilety)
            {
                Console.WriteLine($"Dzień odlotu - {b.przelot.dzienOdlotu}, godzina -  {b.przelot.godzinaOdlotu}, cena - {b.cena}\n" +
                    $"Linia lotnicza - {b.liniaLotnicza}");
            }
        }

        public void PokazRezerwacje()
        {
            Console.WriteLine($"{imie}: Rezerwacje");
            foreach (IRezerwacja r in rezerwacje)
            {
                Console.WriteLine($"Dzień odlotu - {r.przelot.dzienOdlotu}, godzina -  {r.przelot.godzinaOdlotu}, liczba osób - {r.ileDoroslych+r.ileDzieci}\n" +
                    $"Linia lotnicza - {r.liniaLotnicza}");
            }
        }

        public void Rezerwuj()
        {
            throw new NotImplementedException();
            //TODO rezerwowanie biletów
        }

        public void Kup()
        {
            throw new NotImplementedException();
            //TODO zakup biletow
        }
    }
}
