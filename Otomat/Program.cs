namespace Otomat
{
    internal class Program
    {
        static void Main(string[] args)
        {     

            int para = 0;
            string[] urunler = { "Fanta", "Kola", "Çikolata" };
            int[] fiyatlar = { 40, 60, 30 };
            int Satıs = 0;


            while (true) // Ana menü için
            {
                Console.WriteLine(" Otomata hoşgeldin \n  Bir ürün seç ");

                for (int i = 0; i < urunler.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {urunler[i]} - {fiyatlar[i]} TL");
                }

                Console.WriteLine(/* Boşluk */);

                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim > urunler.Length) 
                {
                    Console.WriteLine(" Lütfen geçerli ürünlerden 1 ini gir!!!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }  // Yanlış seçim 
                else if (secim > 0)
                {
                    while (true)
                    {
                        Console.WriteLine(" Para yatırınız ");
                        para = para + Convert.ToInt32(Console.ReadLine());

                        int urunFiyati = fiyatlar[secim - 1];
                        string urunAdi = urunler[secim - 1];

                        if (urunFiyati > para)
                        {

                            Console.WriteLine(" Girdiğiniz para miktarı ürün fiyatından küçük !!! \n Para girişi için 1'i \n Para iadesi için 2 'yi tuşlayınız ");
                            int secim2 = Convert.ToInt32(Console.ReadLine());

                            if (secim2 == 1)
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(" Paranız çekiliyor Lütfen bekleyin...");
                                Thread.Sleep(2000);
                                para = 0;
                                Console.WriteLine(" Paranız başarıyla çekidi , paranızı almayı unutmayınız ");
                                Thread.Sleep(2000);
                                break;
                            }


                        }
                        else if (urunFiyati < para)
                        {
                            Console.WriteLine(" Ürününüzü ve para üstünüzü almayı unnutmayınız ! :) ");
                            Console.WriteLine(" Para üstünüz : " + (para - fiyatlar[secim - 1]));
                            Thread.Sleep(4000);
                            para = 0;
                            Satıs++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(" Ürününüzü almayı unutmayın , Afiyet olsun");
                            Thread.Sleep(2000);
                            Satıs++;
                            break;
                        }                     
                    }

                }          // Müsteri Paneli
                else if (secim < 0)
                {
                    Console.WriteLine("Admin Panele Hoşgeldin \n Yeni ürün ekle 1\r\n Ürün Güncelle 2\r\n Ürün Sil 3\r\n Ürünleri Listele 4\r\n Günsonu toplam satış 5  ");
                    int secim25 = Convert.ToInt32(Console.ReadLine());

                    if (secim25 == 1)
                    {

                        /* !!! Aşağıdaki kurala göre doldur 

                        //string[] ad = { "ALİ", "Veli", "Kayra" };

                        //string[] yeniad = new string[ad.Length + 1];

                        //for (int i = 0; i < ad.Length; i++)
                        //{
                        //    yeniad[i] = ad[i];               
                        //}

                        //ad = yeniad;

                        //ad[3] = "MAL";


                        //foreach (string item in ad)
                        //{
                        //    Console.WriteLine(item);
                        //}  */

                        string[] yeniürünler = new string[urunler.Length + 1];
                        int[] yenifiyatlar = new int[fiyatlar.Length + 1];

                        for (int i = 0; i < urunler.Length; i++)
                        {
                            yeniürünler[i] = urunler[i];
                            yenifiyatlar[i] = fiyatlar[i];
                        }

                        urunler = yeniürünler;
                        fiyatlar = yenifiyatlar;

                        Console.WriteLine(" Eklenecek ürünün ismini yazınız ");
                        urunler[yeniürünler.Length - 1] = Console.ReadLine();
                        Console.WriteLine(" Eklenecek ürünün fiyatını  yazınız ");
                        fiyatlar[yenifiyatlar.Length - 1] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine(" Ürününüz başarıyla kaydedildi ");
                        Thread.Sleep(2000);


                    } //   Yeni ürün ekle
                    else if (secim25 == 2) 
                    {
                        Console.WriteLine(" Güncellenecek ürünü seçiniz ");
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {urunler[i]} - {fiyatlar[i]} TL");
                        }

                        Console.WriteLine(/* Boşluk */);

                        int secim2 = Convert.ToInt32(Console.ReadLine());

                        if (secim2 > urunler.Length) 
                        {
                            Console.WriteLine(" Lütfen geçerli ürünlerden 1 ini gir!!!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            continue;
                        }
                        else if (secim2 > 0) 
                        {
                            Console.WriteLine(" Seçilen ürünün yenifiyatını girin :  ");
                            fiyatlar[secim2-1] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ürünün fiyatı değiştirildi");                           
                            Thread.Sleep(2000);
                            Console.Clear();
                            continue;
                        }

                    } //   Ürün Güncelle 
                    else if (secim25 == 3) 
                    {
                       
                        Console.WriteLine(" Silinecek ürünü seçiniz ");                      

                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {urunler[i]} - {fiyatlar[i]} TL");
                        }
                        int silsecim = Convert.ToInt32(Console.ReadLine());

                        if (silsecim > urunler.Length)
                        {
                            Console.WriteLine(" Lütfen geçerli ürünlerden 1 ini gir!!!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            continue;
                        }
                        else if (silsecim > 0)
                        {
                            //  Bu kodu kulllandığımda yeni eklediğim ürünü silemiyorum :( (Benim yazdığım kod)
                            /*  Array.Clear(urunler, silsecim, 1);
                                Array.Clear(fiyatlar, silsecim, 1); */

                                // Bu kodu Chatgbt den aldım ve anladım                                
                                // Yeni diziler oluşturuluyor
                               string[] yeniUrunler = new string[urunler.Length - 1];
                               int[] yeniFiyatlar = new int[fiyatlar.Length - 1];
                               
                               // Elemanları kopyalayıp silinecek olanı atlıyoruz
                               int yeniIndex = 0;
                               for (int i = 0; i < urunler.Length; i++)
                               {
                                   if (i == silsecim - 1) continue; // Silinecek elemanı atla
                                   yeniUrunler[yeniIndex] = urunler[i];
                                   yeniFiyatlar[yeniIndex] = fiyatlar[i];
                                   yeniIndex++;
                               }
                               
                               // Eski diziler yeni dizilerle değiştiriliyor
                               urunler = yeniUrunler;
                               fiyatlar = yeniFiyatlar;
                            
                        }

                        Console.WriteLine(" Ürününüz başarıyla silindi");
                        Thread.Sleep(2000);
                        Console.Clear();

                    } //   Ürün Sil 3 
                    else if (secim25 == 4)
                    {
                        foreach (string item in urunler)
                        {
                            Console.WriteLine(item);
                        }
                    } //   Ürünleri Listele 4
                    else if (secim25 == 5) 
                    {
                        Console.WriteLine($" Günün sonunda toplam satış {Satıs} ");
                        Thread.Sleep(2000);
                    } //   Günsonu toplam satış 5  

                }          // Admin Paneli
                                                
                Console.Clear();
            }

            /*//      OTOMAT MAKİNESİ

          //   ürünler ve fiyatları önceden tanımlanacak

          //   Program başlarken kullanıcıya ürünler ve fiyatları lsitelenecek

          //   fanta: 40
          //   Kola: 40
          //   Çikolata: 30

          //   kullanıcıdan bir ürün seçmesi beklenecek
          //   ürün seçildikten sonra para girişi yapılacak
          //   yatıran para yeterli ise "afiyet olsun"
          //   yatırılan para fazla ise "afiyet olsun para üstü:10 alınız."
          //   yatırılan para az ise "yetersiz bakiye" "Para ekle 1, Para iade 2"


          //   ADMİN PANEL
          //   Yeni ürün ekle 1
          //   Ürün Güncelle 2
          //   Ürün Sil 3
          //   Ürünleri Listele 4
          //   Günsonu toplam satış 5                           */

        }
    }
}
