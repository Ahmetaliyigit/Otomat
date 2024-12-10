using System;
using System.Collections;
using System.Drawing;

namespace Manav
{
    internal class Program
    {
        static  SortedList meyve = new SortedList() { };
        static  SortedList sebze = new SortedList() { };
        static List<string> alinanurunler = new List<string>() { };

        static void Main(string[] args)
        {        
            Hal();
            Manav();
            Yazdir();
        }

        public static void Hal()
        {
           


            string[] manavmeyve = { "Elma", "Armut", "Karpuz", "Muz", "Çilek", "Ayva" };
            string[] manavsebze = { "Domates", "Salatalık", "Biber", "Patlıcan", "Havuç", "Ispanak" };

            while (true)
            {

                Console.WriteLine("HALE HOŞGELDİNİZ\n Meyve için M \n Sebze için S ye basınız.");
                string secim = Console.ReadLine();

                if (secim == "M")
                {
                    int sayac = 1;
                    foreach (string item in manavmeyve)
                    {
                        Console.WriteLine($"{sayac} - {item}");
                        sayac++;
                    }

                    Console.Write(" Almak istediğiniz meyveyi seciniz : ");
                    int secimmeyve = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Kaç kilo alıcağınızı giriniz : ");
                    int kilo = Convert.ToInt32(Console.ReadLine());

                    meyve.Add(manavmeyve[secimmeyve], kilo);



                }
                else if (secim == "S")
                {
                    int sayac = 1;
                    foreach (string item in manavsebze)
                    {
                        Console.WriteLine($"{sayac} - {item}");
                        sayac++;
                    }

                    Console.Write(" Almak istediğiniz sebzeyi seciniz : ");
                    int secimmeyve = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Kaç kilo alıcağınızı giriniz : ");
                    int kilo = Convert.ToInt32(Console.ReadLine());


                    sebze.Add(manavmeyve[secimmeyve], kilo);

                }
                else
                {
                    Console.WriteLine(" Lütfen doğru seçim yapınız ");
                    Thread.Sleep(2000);
                    continue;
                }

               

                Console.WriteLine(" Başka arzunuz varmı \n1-) Evet\n2-) Hayır");
                int arzu = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (arzu == 1) { continue; }
                else { break; }
            }

        }
        public static void Manav()
        {

            while (true)
            {

                Console.WriteLine("MANAVA HOŞGELDİNİZ\n Meyve için M\n Sebze için S ye basınız.");
                string secim = Console.ReadLine();

                if (secim == "M")
                {
                    foreach (var item in meyve)
                    {
                        Console.WriteLine(item);
                    }
                    Console.Write(" Alacağınız meyveyi yazın  :");
                    string secimmeyve = Console.ReadLine();

                    if (meyve.ContainsKey(secimmeyve))
                    {
                        Console.Write(" Kaç kilo alacağınızı yazınız  : ");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if ( kilo > (int)meyve[secimmeyve])
                        {
                            Console.WriteLine(" Lütfen geçerli kiloda isteyin");
                            continue;
                        }
                        else
                        {
                            alinanurunler.Add(secimmeyve);
                            meyve[secimmeyve] = (int)meyve[secimmeyve] - kilo;
                        }
                       

                    }

                }
                else if (secim == "S")
                {
                    foreach (var item in sebze)
                    {
                        Console.WriteLine(item);
                    }
                    Console.Write(" Alacağınız sebbzeyi yazın  :");
                    string secimmeyve = Console.ReadLine();

                    if (sebze.ContainsKey(secimmeyve))
                    {
                        Console.Write(" Kaç kilo alacağınızı yazınız  : ");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (kilo > (int)sebze[secimmeyve])
                        {
                            Console.WriteLine(" Lütfen geçerli kiloda isteyin");
                            continue;
                        }
                        else
                        {
                            alinanurunler.Add(secimmeyve);
                            sebze[secimmeyve] = (int)sebze[secimmeyve] - kilo;
                        }

                       

                    }
                }
                else
                {
                    Console.WriteLine("Yanlış seçim ");
                    Thread.Sleep(2000);
                    continue;
                }

                Console.WriteLine(" Başka arzunuz varmı \n1-) Evet?\n2-) Hayır");
                int arzu = Convert.ToInt32(Console.ReadLine());

                if (arzu == 1) { continue; }
                else { break; }
            }


        }
        public static void Yazdir()        
{
            Console.WriteLine("Alınan ürünler");
            foreach ( var item in alinanurunler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
