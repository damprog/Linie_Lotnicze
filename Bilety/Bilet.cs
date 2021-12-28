using Linie_Lotnicze_Przemyslaw_Pawluk.Bilety;
using Linie_Lotnicze_Przemyslaw_Pawluk.TypyWyliczeniowe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    class Bilet : BiletAbstract
    {
        public Bilet(string imie, string nazwisko, RodzajBiletu rodzaj, bool pierwszaKlasa, int liczbaDoroslych, int liczbaDzieci, ILiniaLotnicza liniaLotnicza, IPrzelot przelot)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rodzaj = rodzaj;
            this.pierwszaKlasa = pierwszaKlasa;
            this.liczbaDoroslych = liczbaDoroslych;
            this.liczbaDzieci = liczbaDzieci;
            this.liniaLotnicza = liniaLotnicza;
            this.przelot = przelot;
        }

        public override void ObliczCene()
        {
            double dzieci = 0.8 * liczbaDzieci;
            double dorosli = liczbaDoroslych;
            double mnoznik = 1;
            double baza = 300;
            if (pierwszaKlasa) mnoznik = 1.5;
            cena = (dzieci + dorosli) * mnoznik * baza;
            if (rodzaj == RodzajBiletu.W_obie_strony) cena *= 2;
            Console.WriteLine("Obliczono cenę biletu");
        }

        public override void WyswietlInfo()
        {
            Console.WriteLine($"Bilet na lot samolotem\n" +
                $"Linia: {liniaLotnicza.nazwa}\n" +
                $"Osoba: {imie} {nazwisko}\n" +
                $"Liczba osób {liczbaDoroslych+liczbaDzieci} w tym {liczbaDzieci} dzieci\n" +
                $"Data: {przelot.dzienOdlotu} - godz. {przelot.godzinaOdlotu}\n" +
                $"Cena: {cena}");
            Console.WriteLine("\n---------------------------------------------------\n");
        }
    }
}
