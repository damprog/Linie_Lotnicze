﻿using Linie_Lotnicze_Przemyslaw_Pawluk.Klienci;
using Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze;
using Linie_Lotnicze_Przemyslaw_Pawluk.TypyWyliczeniowe;
using System;
using System.Collections.Generic;

namespace Linie_Lotnicze_Przemyslaw_Pawluk
{
    // Zastosowane wzorce
    // - Fabryka prosta - w konstruktorze klasy Przelot
    // - Budowniczy - do tworzenia lini lotniczych
    // - Dekorator - do zmodyfikowania biletu.. modyfikuje sposób obliczania 
    //      ceny dla biletów kupionych z rezerwacji
    // - Pełnomocnik - do pozwalania lub blokowania działań klienta, określa czy można zakupić bilet
    // - 
    // - 

    class Program
    {
        static List<LiniaLotnicza> linieLotnicze = new List<LiniaLotnicza>();
        static string imie;
        static string nazwisko;
        static LiniaLotnicza liniaLotnicza;
        static Przelot przelot;
        static KlientProxy klient;
        static RodzajBiletu rodzaj;
        static int liczbaDoroslych;
        static int liczbaDzieci;
        static bool pierwszaKlasa;
        static IBilet bilet;
        static List<KlientProxy> klienci = new List<KlientProxy>();

        static void Main(string[] args)
        {
            StworzLinieLotnicze();

            NaglowekProgramu();
            // Tworzenie użytkownika
            klient = TworzenieUzytkownika();
            klienci.Add(klient);
            //Formularz potrzebny do zebrania informacji wymaganych do zakupu biletu
            Formularz();
            //Tworzenie biletu na podstawie zebranych informacji
            bilet = new Bilet(imie, nazwisko, rodzaj, pierwszaKlasa, liczbaDoroslych, liczbaDzieci, liniaLotnicza, przelot);
            //Informacje potrzebne do zezwolenia na działanie
            klient.PrzekazInformacje(przelot, liczbaDzieci, liczbaDoroslych);

            bool x = true;
            while (x)
            {
                Console.WriteLine("Wybierz następny krok");
                Console.WriteLine("1 - Zarezerwuj bilet");
                Console.WriteLine("2 - Kup bilet");
                Console.WriteLine("3 - Zobacz rezerwacje");
                Console.WriteLine("4 - Zobacz zakupione bilety");
                Console.WriteLine("0 - Wyjście z programu");
                int idWybor = int.Parse(Console.ReadLine());
                if (idWybor == 1)
                {
                    Console.Clear();
                    NaglowekProgramu();
                    klient.ZarezerwujBilet(bilet, przelot);
                    Console.ReadLine();
                    Console.Clear();
                    NaglowekProgramu();
                }
                else if (idWybor == 2)
                {
                    Console.Clear();
                    NaglowekProgramu();
                    klient.KupBilet(bilet, przelot);
                    Console.ReadLine();
                    Console.Clear();
                    NaglowekProgramu();
                }
                else if (idWybor == 3)
                {
                    Console.Clear();
                    NaglowekProgramu();
                    klient.PokazRezerwacje();
                    Console.ReadLine();
                    Console.Clear();
                    NaglowekProgramu();
                }
                else if (idWybor == 4)
                {
                    Console.Clear();
                    NaglowekProgramu();
                    klient.PokazBilety();
                    Console.ReadLine();
                    Console.Clear();
                    NaglowekProgramu();
                }
                else if(idWybor == 0)
                {
                    Environment.Exit(0);
                }
            }
        }

        private static void Formularz()
        {
            NaglowekFormularza();
            liniaLotnicza = WyborLiniLotniczej();
            Console.WriteLine($"Wybrano {liniaLotnicza.nazwa}");
            liniaLotnicza.WyswitlInfo();
            Console.WriteLine("Potwierdz wciskając dowolny przycisk...");
            Console.ReadLine();
            Console.Clear();
            NaglowekProgramu();
            NaglowekFormularza();

            przelot = WyborPrzelotu();
            Console.WriteLine("Wybrany przelot");
            przelot.WyswietlInfo();
            Console.WriteLine("Potwierdz wciskając dowolny przycisk...");
            Console.ReadLine();
            Console.Clear();
            NaglowekProgramu();
            NaglowekFormularza();

            // Jeżeli linia lotnicza nie oferuje przewozu pierwszą klasą.
            if (liniaLotnicza.pierwszaKlasa)
            {
                pierwszaKlasa = WyborKlasy();
            }
            else
            {
                pierwszaKlasa = false;
            }

            PodajOsoby();
            rodzaj = WybierzRodzajBiletu();
        }

        private static void NaglowekKlient()
        {
            Console.WriteLine($" > Użytkownik - {imie} {nazwisko}\n");
        }
        private static void NaglowekProgramu()
        {
            Console.WriteLine("\t\tLoty samolotem");
            Console.WriteLine("-----------------------------------------------");
        }

        private static void NaglowekFormularza()
        {
            Console.WriteLine("Wypełnij formularz potrzebny do utworzenia biletu");
            Console.WriteLine($" > Użytkownik - {imie} {nazwisko}\n");
        }

        private static KlientProxy TworzenieUzytkownika()
        {
            KlientProxy klient;
            try
            {
                Console.WriteLine("Wypełnij prosty formularz aby przejść dalej");
                Console.WriteLine("Podaj swoje imie");
                imie = Console.ReadLine();
                Console.WriteLine("Teraz podaj swoje nazwisko");
                nazwisko = Console.ReadLine();
                klient = new KlientProxy(imie, nazwisko);
                Console.WriteLine($"Utworzyliśmy użytkownika: {imie} {nazwisko}\n");
                Console.ReadLine();
                Console.Clear();
                NaglowekProgramu();
                return klient;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                NaglowekProgramu();
                return TworzenieUzytkownika();
            }
        }

        private static void PodajOsoby()
        {
            try
            {
                Console.WriteLine("Ile dorosłych?");
                liczbaDoroslych = int.Parse(Console.ReadLine());
                Console.WriteLine("Ile dzieci?");
                liczbaDzieci = int.Parse(Console.ReadLine());
                Console.Clear();
                NaglowekProgramu();
                NaglowekFormularza();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                NaglowekProgramu();
                NaglowekFormularza();
                PodajOsoby();
            }
        }

        private static bool WyborKlasy()
        {
            bool pierwszaKlasa = false;
            try
            {
                Console.WriteLine("Wybierz klasę, którą chcesz podróżować");
                Console.WriteLine("1. Pierwsza klasa");
                Console.WriteLine("2. Zwykła klasa");
                int idKlasy = int.Parse(Console.ReadLine());
                if (idKlasy == 1)
                {
                    pierwszaKlasa = true;
                }
                else
                {
                    pierwszaKlasa = false;
                }
                Console.Clear();
                NaglowekProgramu();
                NaglowekFormularza();
                return pierwszaKlasa;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                NaglowekProgramu();
                NaglowekFormularza();
                return WyborKlasy();
            }
        }

        private static RodzajBiletu WybierzRodzajBiletu()
        {
            RodzajBiletu rodzaj = RodzajBiletu.Null;
            try
            {
                Console.WriteLine("Jaki bilet?\n" +
                    "1. W jedną stronę\n" +
                    "2. W obie strony\n");
                int idRodzaju = int.Parse(Console.ReadLine());
                if (idRodzaju == 1) rodzaj = RodzajBiletu.W_jedną_stronę;
                if (idRodzaju == 2) rodzaj = RodzajBiletu.W_obie_strony;
                if (rodzaj.Equals("Null")) throw new Exception("Niepoprawny rodzaj!");
                Console.Clear();
                NaglowekProgramu();
                NaglowekFormularza();
                return rodzaj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                NaglowekProgramu();
                NaglowekFormularza();
                return WybierzRodzajBiletu();
            }
        }

        private static Przelot WyborPrzelotu()
        {
            Przelot przelot;
            int counter = 1;
            try
            {
                Console.WriteLine("Dostępne przloty: ");
                foreach (Przelot p in liniaLotnicza.przeloty)
                {
                    Console.Write(counter + ".");
                    p.WyswietlInfo();
                    Console.WriteLine("\n-------------------------------\n");
                    counter++;
                }
                Console.WriteLine("\nWybierz przelot który Cię interesuje: ");
                int idPrzelotu = int.Parse(Console.ReadLine()) - 1;
                przelot = (Przelot)liniaLotnicza.przeloty[idPrzelotu];
                Console.Clear();
                NaglowekProgramu();
                NaglowekFormularza();
                return przelot;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                NaglowekProgramu();
                NaglowekFormularza();
                return WyborPrzelotu();
            }
        }

        public static LiniaLotnicza WyborLiniLotniczej()
        {
            LiniaLotnicza liniaLotnicza;
            try
            {
                Console.WriteLine("Dostępne linie lotnicze:");
                foreach (LiniaLotnicza l in linieLotnicze)
                {
                    l.WyswitlInfo();
                }
                Console.WriteLine("Wybierz linię lotniczą aby przejść dalej...");
                int idLini = int.Parse(Console.ReadLine());
                liniaLotnicza = linieLotnicze.Find(x => x.id == idLini);
                if (liniaLotnicza == null) throw new Exception("Taka linie lotnicza nie istnieje");
                Console.Clear();
                NaglowekProgramu();
                NaglowekFormularza();
                return liniaLotnicza;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                NaglowekProgramu();
                NaglowekFormularza();
                return WyborLiniLotniczej();
            }
        }

        public static void StworzLinieLotnicze()
        {
            //Kierownik do nadzoru tworzenia lini
            KierownikBudowyLiniLotniczych kierownikLini = new KierownikBudowyLiniLotniczych();

            //tworzenie Air France
            BudowniczyLiniLotniczych BLL1 = new BudowniczyAirFrance();
            kierownikLini.Konstruuj(BLL1);
            LiniaLotnicza airFrance = BLL1.DajWynik();
            linieLotnicze.Add(airFrance);

            BudowniczyLiniLotniczych BLL2 = new BudowniczyLufthansa();
            kierownikLini.Konstruuj(BLL2);
            LiniaLotnicza lufthansa = BLL2.DajWynik();
            linieLotnicze.Add(lufthansa);


            BudowniczyLiniLotniczych BLL3 = new BudowniczyPolskieLinieLotniczeLOT();
            kierownikLini.Konstruuj(BLL3);
            LiniaLotnicza lot = BLL3.DajWynik();
            linieLotnicze.Add(lot);

            BudowniczyLiniLotniczych BLL4 = new BudowniczyRyanair();
            kierownikLini.Konstruuj(BLL4);
            LiniaLotnicza ryanair = BLL4.DajWynik();
            linieLotnicze.Add(ryanair);

            BudowniczyLiniLotniczych BLL5 = new BudowniczyWizzAir();
            kierownikLini.Konstruuj(BLL5);
            LiniaLotnicza wizzAir = BLL5.DajWynik();
            linieLotnicze.Add(wizzAir);
        }
    }
}
