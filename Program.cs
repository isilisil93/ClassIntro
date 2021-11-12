﻿// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        string adi = "Engin";
        int yasi = 36;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demiroğ";
        kurs1.IzlenmeOrani = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Ali Durmuş";
        kurs2.IzlenmeOrani = 60;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Veli Can";
        kurs3.IzlenmeOrani = 80;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "C++";
        kurs4.Egitmen = "Damla Tatar";
        kurs4.IzlenmeOrani = 90;



        //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

        foreach (var kurs in kurslar)
        {
            //Console.WriteLine(kurs.KursAdi);
            //Console.WriteLine(kurs.IzlenmeOrani);

            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " - İlerleme Seviyesi " + kurs.IzlenmeOrani);

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + " - " + "İlerleme Seviyesi:" + kurs1.IzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Egitmen + " - " + "İlerleme Seviyesi:" + kurs2.IzlenmeOrani);
            //Console.WriteLine(kurs3.KursAdi + " : " + kurs3.Egitmen + " - " + "İlerleme Seviyesi:" + kurs3.IzlenmeOrani);
        }


    }

}


class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}

