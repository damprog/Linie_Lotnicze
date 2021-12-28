using Linie_Lotnicze_Przemyslaw_Pawluk.Bilety;
using System;
using System.Collections.Generic;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.Klienci
{
    class KlientProxy 
    {
        public Klient klient;
        

        private Przelot przelot;
        private int liczbaDzieci;
        private int liczbaDoroslych;
        public KlientProxy(string imie, string nazwisko)
        {
            this.klient = new Klient(imie, nazwisko);
            klient.bilety = new List<IBilet>();
            klient.rezerwacje = new List<IRezerwacja>();
        }

        public void PrzekazInformacje(Przelot przelot, int liczbaDzieci, int liczbaDoroslych)
        {
            this.przelot = przelot;
            this.liczbaDzieci = liczbaDzieci;
            this.liczbaDoroslych = liczbaDoroslych;
        }

        private bool SprawdzPozwolenie()
        {
            //Sprawdzenie czy jest wystarczająco dużo miejsc
            if (przelot.SprawdzDostepnosc(liczbaDzieci + liczbaDoroslych))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Przepraszamy, nie ma wystarczająco miejsc, wybierz inny przelot.");
                return false;
            }
        }

        public void KupBilet(IBilet bilet, Przelot przelot)
        {
            if (SprawdzPozwolenie())
            {
                // Sprawdzenie czy klient ma rezerwacje na bilet
                bool czyBylaRezerwacja = false;
                IRezerwacja rezerwacja = klient.rezerwacje.Find(x => x.zarezerwowanyBilet == bilet);
                if (rezerwacja != null) czyBylaRezerwacja = true;
                if (czyBylaRezerwacja)
                {
                    // Jeśli tak to dekorator
                    // Bilet z rabatem
                    BiletZRezerwacji biletZRezerwacji = new BiletZRezerwacji((BiletAbstract)rezerwacja.zarezerwowanyBilet);
                    biletZRezerwacji.bilet.ObliczCene();
                    biletZRezerwacji.bilet.cena = biletZRezerwacji.ObliczCenePoZnizce(biletZRezerwacji.bilet.cena);
                    Kup(biletZRezerwacji.bilet, (Rezerwacja)rezerwacja);
                }
                else
                {
                    // Jeśli nie to zwykly bilet
                    // Bilet bez rabatu
                    bilet.ObliczCene();
                    Kup(bilet);
                }
            }
        }

        public void ZarezerwujBilet(IBilet bilet, Przelot przelot)
        {
            if (SprawdzPozwolenie())
            {
                Rezerwacja rezerwacja = new Rezerwacja(bilet);
                Rezerwuj(rezerwacja);
            }
        }

        public void Kup(IBilet bilet)
        {
            klient.Kup(bilet);
        }

        public void Kup(IBilet bilet, Rezerwacja rezerwacja)
        {
            klient.Kup(bilet, rezerwacja);
        }


        public void Rezerwuj(Rezerwacja rezerwacja)
        {
            klient.Rezerwuj(rezerwacja);
        }

        public void ZdejmijRezerwacje(Rezerwacja rezerwacja)
        {
            klient.ZdejmijRezerwacje(rezerwacja);
        }
        public void PokazBilety()
        {
            klient.PokazBilety();
        }

        public void PokazRezerwacje()
        {
            klient.PokazRezerwacje();
        }
    }
}
