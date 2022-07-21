using System;

namespace kamp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Kurs kurslar1 = new Kurs();
            kurslar1.KursAdi = "java";
            kurslar1.Egıtmen = "Enver";
            kurslar1.IzlenmeOrani = 70;

            Kurs kurslar2 = new Kurs();
            kurslar2.KursAdi = "R";
            kurslar2.Egıtmen = "eren";
            kurslar2.IzlenmeOrani = 100;

            Kurs kurslar3 = new Kurs();
            kurslar3.KursAdi = "pyhton";
            kurslar3.Egıtmen = "sena";
            kurslar3.IzlenmeOrani = 86;

            Kurs[] kurslar = new Kurs[] {kurslar1, kurslar2, kurslar3  };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "=" + kurs.Egıtmen);
            }
        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egıtmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}
