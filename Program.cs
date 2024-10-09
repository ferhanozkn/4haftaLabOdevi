using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci(2010206508, "Ferhan", "Özkan", 75, 80, 85, "Karabük Üniversitesi");

            while (true)
            {
                Console.WriteLine("\n\nOGRENCI BILGI SISTEMI (OBS)\n");
                Console.WriteLine("1-Ogrencinin Bilgilerini Goster.");
                Console.WriteLine("2-Ogrencinin Ders Ortalamasini Goster.");
                Console.WriteLine("3-Ogrencinin Okudugu Okulun Ismini Goster.");
                Console.WriteLine("4-Sistemden Cikis Yap.\n");

                Console.WriteLine("Seciminiz : ");
                string secim= Console.ReadLine();
                Console.WriteLine("\n");

                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGoster();
                        break;
                    case "2":
                        Console.WriteLine("Not Ortalamasi : " + ogrenci1.ortalamaBul());
                        break;
                    case "3":
                        Console.WriteLine("Okulun Ismi : " + ogrenci1.okulGetir());
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Gecersiz Secim!!! Tekrar Deneyiniz.");
                        break;
                }
            }
        }
    }

    class Ogrenci
    {
        private int ogrNo;
        private string isim;
        private string soyisim;
        private double vize;
        private double quiz;
        private double final;
        private string okulIsmi;

        public Ogrenci(int ogrNo, string isim, string soyisim, double vize, double quiz, double final, string okulIsmi)
        {
            this.ogrNo = ogrNo;
            this.isim = isim;
            this.soyisim = soyisim;
            this.vize = vize;
            this.quiz = quiz;
            this.final = final;
            this.okulIsmi = okulIsmi;
        }

        public double ortalamaBul() { return (vize * 30 / 100) + (quiz * 10 / 100) + (final * 60 / 100); }

        public string okulGetir()
        {
            return okulIsmi;
        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Ogrenci No : " + ogrNo);
            Console.WriteLine("Ogrencinin Ismi : " + isim);
            Console.WriteLine("Ogrencinin Soyismi : " + soyisim);
            Console.WriteLine("Ogrencinin Vize Notu : " + vize);
            Console.WriteLine("Ogrencinin Quiz Notu : " + quiz);
            Console.WriteLine("Ogrencinin Final Notu : " + final);
            Console.WriteLine("Ogrencinin Okudugu Okul : " + okulIsmi);
        }
    }
}

