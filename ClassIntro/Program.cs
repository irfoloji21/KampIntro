using System;

namespace ClassIntro
{
    class Program
    {

        static void Main(string[] args)
        {

            string adi = "İrfan";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "İrfan Meşe";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Valör";
            kurs2.Egitmen = "Eşşek Kero";
            kurs2.IzlenmeOrani = 59;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "minimalizm";
            kurs3.Egitmen = "Aydın Kiracı";
            kurs3.IzlenmeOrani = 35;


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 } ;

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


           // Console.WriteLine("hi bitches");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
