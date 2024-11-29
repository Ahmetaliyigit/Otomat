using System;

public class Program
{
    static public void Main()
    {


        string sifre = "ab18";
    GIRIS:
        Console.WriteLine("      ~ BANKAMATIGE HOSGELDINIZ ~");
        Console.Write("Sifre girin:  ");

        string pass = Console.ReadLine();
        int bakiye = 25000;
        long kartno1 = 123456789012;

        if (sifre != pass)
        {
            Console.WriteLine("Yanlis sifre lutfen dogrusunu girin");
            Thread.Sleep(2000);
            Console.Clear();
            goto GIRIS;
        }

    Menu:
        Console.Clear();
        Console.WriteLine("     ANA MENU    ");
        Console.WriteLine(" Para cekmek icin    1'i");
        Console.WriteLine(" Para yatirmak icin  2'yi");
        Console.WriteLine(" Para Transferleri icin   3'u");
        Console.WriteLine(" Egitim Odemeleri icin     4'u");
        Console.WriteLine(" Odemeler icin            5'i");
        Console.WriteLine(" Bilgi Guncelleme icin    6'yi tuslayiniz");
        Console.WriteLine();

        int Menusayi = Convert.ToInt32(Console.ReadLine());

        if (Menusayi < 1 || Menusayi > 6)
        {
            Console.WriteLine("Lutfen islem icin gecerli sayiyi girin");
            Thread.Sleep(3000);
            goto Menu;
        }
        else if (Menusayi == 1)
        {
        CEKPARA:
            Console.Clear();
            Console.WriteLine("      **Para Cekme**   ");
            Console.WriteLine("Cekilecek para miktarini girin: ");
            int Cekpara = Convert.ToInt32(Console.ReadLine());




            if (bakiye < Cekpara)
            {
                Console.WriteLine("Bakiyeniz yetersiz lütfen tekrar deneyin ");
                Thread.Sleep(2000);
                goto CEKPARA;
            }
            else
            {
                Console.WriteLine("Paraniz cekiliyor lutfen bekleyin");
                Thread.Sleep(4000);
                bakiye = bakiye - Cekpara;
                Console.WriteLine("  Paranis basariyla cekildi");
                Console.WriteLine("  Mevcut bakiyeniz:" + bakiye);


            }
        }
        else if (Menusayi == 2)
        {
        YATIRMA:
            Console.Clear();
            Console.WriteLine(" **Para yatirma**");
            Console.WriteLine("Kredi kartiniza ise 1 ,  Kendi hesabiniza ise 2 yi tuslayiniz");
            int secim2 = Convert.ToInt32(Console.ReadLine());

            if (secim2 != 2 && secim2 != 1)
            {
                Console.WriteLine("Lutfen gecerli secenek no sunu girin");
                Thread.Sleep(2000);
                goto YATIRMA;
            }


            if (secim2 == 1)
            {
            EBEB:
                Console.WriteLine("Kredi kart no sunu girin");
                long kartno = Convert.ToInt64(Console.ReadLine());
                int uzunluk = kartno.ToString().Length;

            Kartno:
                if (uzunluk != 12)
                {
                    Console.WriteLine("Lutfen 12 basamak girin!");
                    Thread.Sleep(3000);
                    goto EBEB;
                }
                else
                {

                Parayatirma:
                    Console.Clear();
                    Console.WriteLine(" Karta yatirilicak miktari girin");
                    int Yatfiyat = Convert.ToInt32(Console.ReadLine());



                    if (Yatfiyat > bakiye)
                    {
                        Console.WriteLine("Yetersiz bakiye");
                        goto Parayatirma;
                    }
                    else
                    {
                        Console.WriteLine("Paraniz karta yatiriliyor lutfen bekleyin");
                        Thread.Sleep(4000);
                        Console.WriteLine("Paranis kartiniza basariyla yatirildi");
                        bakiye = bakiye - Yatfiyat;
                        Console.WriteLine("Mevcut bakiyeniz: " + bakiye);

                    }
                }
            }
            else if (secim2 == 2)
            {
            HESAPPARA:
                Console.Write("Lutfen hesaba yatirilicak parayi girin:  ");
                int hesappara = Convert.ToInt32(Console.ReadLine());
                if (hesappara <= 0)
                {
                    Console.WriteLine("Lutfen gecerli miktar girin!");
                    //Thread.Sleep(4000);
                    goto HESAPPARA;
                }
                else
                {
                    Console.Write("Paraniz yatiriliyor lutfen beileyin");
                    //Thread.Sleep(4000);
                    Console.WriteLine("Paranis hesabiniza basariyla yatirildi");
                    bakiye = bakiye + hesappara;
                    Console.WriteLine("Mevcut bakiyeniz: " + bakiye);

                    Console.WriteLine(" (ANA MENU ICIN 9 a) ");
                    Console.WriteLine(" (CIKIS icin 0 a) ");


                }

            }

        }  
        else if (Menusayi == 3)
        {
            // **************** 3 numarali tus icin

            /*           Başka Hesaba EFT    1
                         Başka Hesaba Havale 2
                         //---------------------------------
                         //--1
                         EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı  işlemleri doğru ise
                         yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse */
            //Transver:						
            Console.Clear();
            Console.WriteLine("  **Para transverleri**  ");
            Console.WriteLine("Baska hesaba EFT gondermek icin 1 i , Baska hesaba Havale gondermek icin 2 yi tiklayiniz");
            int efthavale = Convert.ToInt32(Console.ReadLine());





 





















        }
        else if ((Menusayi == 4)) { }
        else if ((Menusayi == 5)) { }
        else if ((Menusayi == 6)) { }

       
        Console.WriteLine("Menü için 9 a ");
        Console.WriteLine("Çıkıs icin 0 a basınız ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 9)
        {
            goto Menu;
        }
        else   
        {
            goto GIRIS;
        }
        
    }
}