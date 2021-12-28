using System;
using System.Collections.Generic;
using System.Text;

namespace Linie_Lotnicze_Przemyslaw_Pawluk.LinieLotnicze
{
    //Klasa jako produkt dla budowniczego
    class LiniaLotnicza : ILiniaLotnicza 
    {
        public int id { get; set; }
        public string nazwa { get; set; }
        public string bagazPodreczny { get; set; }
        public double bagazRejestrowany { get; set; }
        public string symbolSamolotu { get; set; }
        public bool rezerwacjaMiejsc { get; set; }
        public bool posilekNaPokladzie { get; set; }
        public bool pierwszaKlasa { get; set; }
        public List<IPrzelot> przeloty { get; set; }

        public void WyswitlInfo()
        {
            Console.WriteLine($"{id}. {nazwa}: oferuje przeloty samolotem\n" +
                $"\tPodstawowe informacje:\n" +
                $"\tBagaż podręczny - {bagazPodreczny}\n" +
                $"\tBagaż rejestrowany - do {bagazRejestrowany} kg");
            if (rezerwacjaMiejsc) Console.WriteLine("\tMożliwość rezerwacji miejsc");
            if (posilekNaPokladzie) Console.WriteLine("\tPoczęstunek w samolocie");
            if (pierwszaKlasa) Console.WriteLine("\tOferuje lot pierwszą klasą");
            Console.WriteLine("\n-----------------------------------------\n");
        }
        public void WyswietlPrzeloty()
        {
            foreach(Przelot p in przeloty)
            {
                Console.WriteLine(p.DajInfo());
                Console.WriteLine("\n-----------------------------------------\n");
            }
        }
    }
}
