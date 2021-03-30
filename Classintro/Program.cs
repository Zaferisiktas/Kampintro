using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Zafer";
            int yas = 27;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C++";
            kurs1.Egitmen = "Ali";
            kurs1.IzlenmeOrani = 90;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Veli";
            kurs2.IzlenmeOrani = 86;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Mehmet";
            kurs3.IzlenmeOrani = 75;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani);
            }

           //Console.WriteLine("Hello World!");
        }
    }
}


class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}