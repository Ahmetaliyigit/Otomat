namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
              Random ayyuberk = new Random();
              int baa = ayyuberk.Next(1,6);
            
              if ( baa == 1)
              {
                   #region yekulu

                   Console.WriteLine(" Ekranda verilen arapça kelimenin türkçesini yazın ");
                   Console.WriteLine();
                   string dediki = "  yekulu  ";
                   Console.WriteLine(dediki);
                   string yekulu = "diyor";
                   Console.WriteLine();   
                    
                   for (int i = 3; i > 0; i--)
                   {
                       string a = Console.ReadLine();
                  
                       if (a == yekulu || a == " o söylüyor" || a == "o diyor" || a == "söylüyor")
                       {
                           Console.WriteLine("Doğru");
                           i = 0;
                       }
                       else
                       {
                           Console.WriteLine(" Yanlış seçim bir daha dene ");
                       }
                   }
                           Console.WriteLine(yekulu);
                           Console.WriteLine("Sıradaki seçim");
                           Thread.Sleep(2000);
                           Console.Clear();

                  #endregion
              }
              else if ( baa == 2)
              {
                   #region yuhaggigu

                   Console.WriteLine(" Ekranda verilen arapça kelimenin türkçesini yazın ");
                   Console.WriteLine();
                   string gercek = "  yuhaggigu  ";
                   Console.WriteLine(gercek);
                   string yuhaggigu = "gerçekleştiriyor";
                   Console.WriteLine();

                for (int i = 3; i > 0; i--)
                {
                    string b = Console.ReadLine();
                    if (b == yuhaggigu || b == "o gerçekleştiriyor" )
                    {
                        Console.WriteLine("Doğru");
                        i = 0;
                    }
                    else
                    {
                        Console.WriteLine(" Yanlış!!  bir daha dene ");
                    }
                }
                    Console.WriteLine(yuhaggigu);
                    Console.WriteLine("Sıradaki seçim");
                    Thread.Sleep(2000);
                    Console.Clear();

            #endregion
              }
              else if ( baa == 3)
              {
                   #region yaglem

                   Console.WriteLine(" Ekranda verilen arapça kelimenin türkçesini yazın ");
                   Console.WriteLine();
                   string ögretiyor = "  yaglem  ";
                   Console.WriteLine(ögretiyor);
                   string yaglem = "öğretiyor";
                   Console.WriteLine();

                   for (int i = 3; i > 0; i--)
                   {
                       string c = Console.ReadLine();
                       if (c == yaglem || c == "o öğretiyor")
                       {
                           Console.WriteLine("Doğru");
                           i = 0;
                       }
                       else
                       {
                           Console.WriteLine(" Yanlış seçim bir daha dene ");
                       }
                   }
                    Console.WriteLine(yaglem);
                   Console.WriteLine("Sıradaki seçim");
                   Thread.Sleep(2000);
                   Console.Clear();

            #endregion 
              }
              else if ( baa == 4)
              {
                   #region yüdevviru

                    Console.WriteLine(" Ekranda verilen arapça kelimenin türkçesini yazın ");
                    Console.WriteLine();
                    string geliştir = "  yüdevviru  ";
                    Console.WriteLine(geliştir);
                    string yüdevviru = "geliştiriyor";
                    Console.WriteLine();
                    for (int i = 3; i > 0; i--)
                    {
                        string d = Console.ReadLine();
                        if (d == yüdevviru || d == "o geliştiriyor")
                        {
                            Console.WriteLine("Doğru");
                            i = 0;
                        }
                        else
                        {
                            Console.WriteLine(" Yanlış seçim bir daha dene ");
                        }
                    }
                    Console.WriteLine(yüdevviru);
                    Console.WriteLine("Sıradaki seçim");
                    Thread.Sleep(2000);
                    Console.Clear();

                    #endregion
              }
              else if ( baa == 5)
              {
                   #region yeteğallem

                    Console.WriteLine(" Ekranda verilen arapça kelimenin türkçesini yazın ");
                    Console.WriteLine();
                    string öğreniyor = "  yeteğallem  ";
                    Console.WriteLine(öğreniyor);
                    string yetegallem = "öğreniyor";
                    Console.WriteLine();

                    for (int i = 3; i > 0;i--)
                    {
                        string e = Console.ReadLine();
                        if (e == yetegallem || e == "o öğreniyor")
                        {
                            Console.WriteLine("Doğru");
                            i = 0;
                        }
                        else
                        {
                            Console.WriteLine(" Yanlış seçim bir daha dene ");
                        }
                    }

                    Console.WriteLine(yetegallem);
                    Console.WriteLine("Sıradaki seçim");
                    Thread.Sleep(2000);
                    Console.Clear();

                    #endregion
              }
              else
              {
                    #region yüseğidu

                    Console.WriteLine(" Ekranda verilen arapça kelimenin türkçesini yazın ");
                    Console.WriteLine();
                    string yardım = "  yüseğidu  ";
                    Console.WriteLine(yardım);
                    string yüseğidu = "yardım ediyor";
                    Console.WriteLine();
                    for (int i = 3; i > 0; i--)
                    {
                        string e = Console.ReadLine();
                        if (e == yüseğidu || e == "o yardım ediyor")
                        {
                            Console.WriteLine("Doğru");
                            i = 0;
                        }
                        else
                        {
                            Console.WriteLine(" Yanlış seçim bir daha dene ");
                        }
                    }
                    Console.WriteLine(yüseğidu);
                    Console.WriteLine("Sıradaki seçim");
                    Thread.Sleep(2000);
                    Console.Clear();

                    #endregion
              }
            }
            

        }
    }
}
