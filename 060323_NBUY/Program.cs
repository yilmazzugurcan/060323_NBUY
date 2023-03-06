using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace _060323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)

        {

            #region İslem Yaptırma Metodu
            /* static void islem()
             {
             go:
                 Console.WriteLine("islem seciniz - Toplama - Çıkarma - Bölme - Çarpma");
                 string kelime = Console.ReadLine();
                 kelime = kelime.ToLower();

                 if (kelime == "toplama")
                 {
                     Console.WriteLine("Sayıları Gir");
                     int a = Convert.ToInt32(Console.ReadLine());
                     int b = Convert.ToInt32(Console.ReadLine());
                     int toplam = a + b;
                     Console.WriteLine("Sonuc :" + " " + toplam);
                 }
                 else if (kelime == "bölme")
                 {
                     Console.WriteLine("Sayıları Gir");
                     int a = Convert.ToInt32(Console.ReadLine());
                     int b = Convert.ToInt32(Console.ReadLine());
                     double bölme = a / b;
                     Console.WriteLine("Sonuc :" + " " + bölme);
                 }
                 else if (kelime == "çıkarma")
                 {
                     Console.WriteLine("Sayıları Gir");
                     int a = Convert.ToInt32(Console.ReadLine());
                     int b = Convert.ToInt32(Console.ReadLine());
                     double fark = a - b;
                     Console.WriteLine("Sonuc :" + " " + fark);
                 }
                 else if (kelime == "çarpma")
                 {
                     Console.WriteLine("Sayıları Gir");
                     int a = Convert.ToInt32(Console.ReadLine());
                     int b = Convert.ToInt32(Console.ReadLine());
                     double çarpım = a * b;
                     Console.WriteLine("Sonuc :" + " " + çarpım);
                 }
                 else
                 {
                     Console.WriteLine("Hatalı Giriş");
                 }
                 goto go; */
            #endregion

            #region Alan Hesap Metodu
            /* static void alan()
             {
                 Console.WriteLine("Neyin Alanı Hesaplansın : Kare,Dikdörtgen,Silindir");
                 string alan = Console.ReadLine();
                 alan = alan.ToLower();
                 switch (alan)
                 {
                     case "kare":
                         Console.WriteLine("Kenar Uzunluğu Gir");
                         int a = int.Parse(Console.ReadLine());
                         int alan1 = a * a;
                         Console.WriteLine("Karenin Alanı : " + " " + alan1);
                         break;
                     case "dikgörtgen":
                         Console.WriteLine("Dikdörtgen Uzunluklarını Gir :");
                         int b = int.Parse(Console.ReadLine());
                         int c = int.Parse(Console.ReadLine());
                         int alan2 = b * c;
                         Console.WriteLine("Dikdörtgen Alanı :" + " " + alan2);
                         break;
                     case "silindir":
                         Console.WriteLine("Yarıçap Gir");
                         int r = int.Parse(Console.ReadLine());
                         int h = int.Parse(Console.ReadLine());
                         double alan3 = 3.14 * r * r * h;
                         Console.WriteLine("Silinidir Alanı :" + " " + alan3);
                         break;
                     default:
                         Console.WriteLine("HATALI SEÇİM");
                         break;
                 } */
            #endregion

            #region Futbol Turnuvası
            /*  int[] takımlar = new int[8];
               for (int i = 0; i < 8; i++)
               {
                   takımlar[i] = i + 1;
               }
               int sayac = 0, sayac2 = 0, sayac3 = 0, sayac4 = 0;
               Random ran = new Random();
               int[] dizi2 = new int[takımlar.Length / 2];
               int[] dizi3 = new int[takımlar.Length / 2];
               for (int i = 0; i < takımlar.Length;)
               {
                   int eleman = ran.Next(1, 9);
                   for (int j = 0; j < dizi2.Length; j++)
                   {
                       if (eleman == dizi2[j])
                       {
                           sayac++;
                       }
                       if (eleman == dizi3[j])
                       {
                           sayac++;
                       }
                   }
                   if (sayac2 % 2 == 1)
                   {
                       if (sayac == 0)
                       {
                           dizi2[sayac3] = eleman;
                           i++;
                           sayac3++;
                           sayac2++;
                       }
                   }
                   else if (sayac2 % 2 == 0)
                   {
                       if (sayac == 0)
                       {
                           dizi3[sayac4] = eleman;
                           i++;
                           sayac4++;
                           sayac2++;
                       }
                   }
                   sayac = 0;
               }
               Console.WriteLine("İlk Turnuva Maçları\n----------------------");
               for (int i = 0; i < dizi2.Length; i++)
               {
                   Console.WriteLine("Takım" + dizi2[i] + " Vs " + "Takım" + dizi3[i]);
               }
               for (int i = 0; i < dizi2.Length; i++)
               {
                   int mac = ran.Next(1, 3);
                   if (mac == 1)
                   {
                       dizi2[i] = 0;
                   }
                   else if (mac == 2)
                   {
                       dizi3[i] = 0;
                   }
               }
               int[] dizi4 = new int[4];
               int sayac5 = 0;
               Console.WriteLine("Maçlar Başlasın mı ?");
               Console.Read();
               Console.WriteLine("!!!!!...Turnuva 1 Başlıyor...!!!!");
               for (int i = 0; i < dizi2.Length; i++)
               {
                   Console.Write((i + 1) + ". Maç Yapılıyor.");
                   System.Threading.Thread.Sleep(1000);
                   Console.Write(".");
                   System.Threading.Thread.Sleep(1000);
                   Console.Write(".\n");
                   System.Threading.Thread.Sleep(1000);
                   if (dizi2[i] != 0)
                   {
                       Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi2[i]);
                       dizi4[sayac5] = dizi2[i];
                       sayac5++;
                   }
                   else if (dizi3[i] != 0)
                   {
                       Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi3[i]);
                       dizi4[sayac5] = dizi3[i];
                       sayac5++;
                   }
               }

               int[] dizi5 = new int[2];
               int[] dizi6 = new int[2];
               sayac4 = 0;
               sayac3 = 0;
               sayac5 = 0;
               sayac2 = 0;
               for (int i = 0; i < 4;)
               {
                   int eleman = ran.Next(0, 4);
                   for (int j = 0; j < dizi5.Length; j++)
                   {
                       if (dizi4[eleman] == dizi5[j])
                       {
                           sayac++;
                       }
                       if (dizi4[eleman] == dizi6[j])
                       {
                           sayac++;
                       }
                   }
                   if (sayac2 % 2 == 1)
                   {
                       if (sayac == 0)
                       {
                           dizi5[sayac3] = dizi4[eleman];
                           i++;
                           sayac3++;
                           sayac2++;
                       }
                   }
                   else if (sayac2 % 2 == 0)
                   {
                       if (sayac == 0)
                       {
                           dizi6[sayac4] = dizi4[eleman];
                           i++;
                           sayac4++;
                           sayac2++;
                       }
                   }
                   sayac = 0;
               }
               Console.WriteLine("5 Sn Sonra 1. Tur Turnuva Maçları Bitiyor");
               System.Threading.Thread.Sleep(5000);
               Console.Clear();
               Console.WriteLine("2. Turnuva Maçları\n----------------------");
               for (int i = 0; i < dizi5.Length; i++)
               {
                   Console.WriteLine("Takım" + dizi5[i] + " Vs " + "Takım" + dizi6[i]);
               }
               for (int i = 0; i < dizi6.Length; i++)
               {
                   int mac = ran.Next(1, 2);
                   if (mac == 1)
                   {
                       dizi5[i] = 0;
                   }
                   else if (mac == 2)
                   {
                       dizi6[i] = 0;
                   }
               }
               Console.WriteLine();
               sayac5 = 0;
               int[] dizi7 = new int[2];
               Console.WriteLine("!!!!!...Turnuva 2 Başlıyor...!!!!");
               Console.WriteLine("5 Sn Sonra 2. Turnuva Maçları Başlıyor");
               System.Threading.Thread.Sleep(5000);
               for (int i = 0; i < dizi5.Length; i++)
               {
                   Console.Write((i + 1) + ". Maç Yapılıyor.");
                   System.Threading.Thread.Sleep(1000);
                   Console.Write(".");
                   System.Threading.Thread.Sleep(1000);
                   Console.Write(".\n");
                   System.Threading.Thread.Sleep(1000);
                   if (dizi2[i] != 0)
                   {
                       Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi5[i]);
                       dizi7[sayac5] = dizi5[i];
                       sayac5++;
                   }
                   else if (dizi3[i] != 0)
                   {
                       Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi6[i]);
                       dizi7[sayac5] = dizi6[i];
                       sayac5++;
                   }
               }
               Console.WriteLine("!!!! Final !!!!\n----------------");
               Console.WriteLine("Takım" + dizi7[0] + " Vs " + "Takım" + dizi7[1]);
               Console.WriteLine("Final 5 Sn sonra Başlıyacak ?");
               System.Threading.Thread.Sleep(5000);
               Console.Clear();
               Console.WriteLine();
               Console.WriteLine("!!!!!...Final Başlıyor...!!!!");
               System.Threading.Thread.Sleep(2000);
               Console.WriteLine("Maç Yapılıyor " + "Takım" + dizi7[0] + " Vs " + "Takım" + dizi7[1]);
               System.Threading.Thread.Sleep(3000);
               Console.Clear();
               int mac2 = ran.Next(3, 5);
               if (mac2 == 3)
               {
                   Console.WriteLine("Final Maçın Kazananı = Takım" + dizi7[0]);
               }
               else if (mac2 == 4)
               {
                   Console.WriteLine("Final Maçın Kazananı = Takım" + dizi7[1]);
               }*/
            #endregion

            #region Kullanıcıdan Alınan Mesajı Kaç Kere Yazılacagını Alan Metod
            /*  Console.WriteLine("Yazdırılacak Mesajı Girin :");
              string ileti = Console.ReadLine();
              Console.WriteLine("Kaç Adet Yazdırılacak :");
              int adet = int.Parse(Console.ReadLine());


              mesaj(ileti, adet);



          }
          static void mesaj(string ileti, int adet)
          {
              for (int i = 0; i < adet; i++)
              {
                  Console.WriteLine(ileti);
              }
          } */
            #endregion

            #region Tek Cift Parametreli Metod
            /*  tekcift(3);

              static void tekcift(int a)
              {

                  if (a % 2 == 0)
                  {
                      Console.WriteLine("ÇİFT");
                  }
                  else
                  {
                      Console.WriteLine("TEK");
                  }
              } */
            #endregion

            #region Us Alma Metodu
            /*  Console.WriteLine("Hangi Sayinin Üssü Alınacak");
              int a = int.Parse(Console.ReadLine());
              Console.WriteLine("Kaç Üssü Alınacak");
              int b = int.Parse(Console.ReadLine());


              us(a, b);

          }
          static void us(int a, int b)
          {
              double sayi1 = Math.Pow(a, b);
              Console.WriteLine("Sonuc" + " " + sayi1);
          } */
            #endregion

            #region Silindir Hacmi Parametreli Metod İle Hesap
            /*   Console.WriteLine("Yarıçap gir");
               double r = double.Parse(Console.ReadLine());
               Console.WriteLine("Yükseklik Gir");
               double h = double.Parse(Console.ReadLine());

               hacim(r, h);


           }
           static void hacim(double r, double h)
           {
               double hacim = Math.PI * r * r * h;
               Console.WriteLine("Sonuc" + " " + hacim);

           } */
            #endregion

            #region return ile toplama yazdırma
            /*     int x, y;
                 Console.WriteLine(sayi());

                 int sayi()
                 {
                     Console.WriteLine("Sayıları Gir");
                     x = int.Parse(Console.ReadLine());
                     y = int.Parse(Console.ReadLine());
                     return x + y;

                 } */
            #endregion

            #region yol hız zaman kullanıcının istediğini hesaplayan metod
            /* Console.WriteLine(problem());

             static int problem()
             {

                 int sonuc = 0;
                 Console.WriteLine("Ne hesaplansın:\tHIZ?\tYOL?\tZAMAN?");
                 string islem1 = Console.ReadLine();
                 islem1 = islem1.ToLower();

                 switch (islem1)
                 {
                     case "hız":
                         Console.WriteLine("Yol ve zaman gir");
                         int yol = int.Parse(Console.ReadLine());
                         int zaman = int.Parse(Console.ReadLine());
                         sonuc = yol / zaman;
                         return sonuc;
                         break;

                     case "zaman":
                         Console.WriteLine("Yol ve hiz gir");
                         int yol3 = int.Parse(Console.ReadLine());
                         int hiz3 = int.Parse(Console.ReadLine());
                         sonuc = yol3 / hiz3;
                         return sonuc;
                         break;

                     case "yol":
                         Console.WriteLine("Yol ve hiz gir");
                         int zaman2 = int.Parse(Console.ReadLine());
                         int hiz2 = int.Parse(Console.ReadLine());
                         sonuc = zaman2 * hiz2;
                         return sonuc;
                         break;

                     default:
                         return 0;
                         break;
                 }
             } */
            #endregion

            #region kullanıcı secımı menü
            /*  Console.WriteLine(" Ne Yemek İstersiniz Secim Yapınız ");
              Console.WriteLine("1- HAMBURGER + MEŞRUBAT \n2- OSMANLI TOKADI + MEŞRUBAT");
              string secim = Console.ReadLine();

              hesap(secim);

              static void hesap(string secim)
              {
                  if (secim == "1")
                  {
                      Console.WriteLine("HAMBURGER 40 TL");
                      Console.WriteLine("MEŞRUBAT 20 TL");
                      Console.WriteLine("HESABINIZ 60 TL'DİR");
                  }
                  else if (secim == "2")
                  {
                      Console.WriteLine("OSMANLI TOKADI 70 TL");
                      Console.WriteLine("MEŞRUBAT 20 TL");
                      Console.WriteLine("HESABINIZ 90 TL'DİR");
                  }
              } */
            #endregion

            #region HESAP ALMA SORUSU(YİYECEK / İÇECEK)
            /*

                        static void Main(string[] args)
                        {
                            Console.WriteLine("Hesap = " + HesapAl(Yiyecek(), Icecek()) + " TL");

                            Console.Read();

                        }
                        static int Yiyecek()
                        {
                            Console.WriteLine("Ne Yemek İstiyorsunuz?\n");

                            Console.WriteLine("Yiyecek Menüsü:");
                            Console.WriteLine("1-Hamburger Menüsü:");
                            Console.WriteLine("2-Çiğköfte Menüsü:");
                            Console.WriteLine("3-Kebap/İskender Menüsü:");
                            int fiyat = 0;
                            int menu = Convert.ToInt32(Console.ReadLine());
                            if (menu == 1)
                            {
                                fiyat = 80;
                            }
                            else if (menu == 2)
                            {
                                fiyat = 30;
                            }
                            else if (menu == 3)
                            {
                                fiyat = 70;
                            }

                            return fiyat;

                        }
                        static int Icecek()
                        {
                            Console.WriteLine("Ne İçmek İstiyorsunuz?\n");

                            Console.WriteLine("İçecek Menüsü:");
                            Console.WriteLine("1-Kola");
                            Console.WriteLine("2-Şalgam");
                            Console.WriteLine("3-Ayran");
                            Console.WriteLine("4-Ice Tea");
                            Console.WriteLine("5-Limonata");
                            int fiyat = 0;
                            int menu = Convert.ToInt32(Console.ReadLine());
                            if (menu == 1)
                            {
                                fiyat = 15;
                            }
                            else if (menu == 2)
                            {
                                fiyat = 10;
                            }
                            else if (menu == 3)
                            {
                                fiyat = 7;
                            }
                            else if (menu == 4)
                            {
                                fiyat = 12;
                            }
                            else if (menu == 5)
                            {
                                fiyat = 20;
                            }

                            return fiyat;

                        }

                        static int HesapAl(int y, int i)
                        {
                            return y + i;
                        }

                    }*/
            #endregion

            #region kitap ad,yazar,sayfa,fiyat yazdırma metodu
         /*   kitap("Suc ve ceza", 58, "ahmet veli", 500);

            static void ogrenci(string ad, string soyad, int dt, int no)
            {
                Console.WriteLine("Öğrenci Adı Giriniz");
                string isim = Console.ReadLine();
                Console.WriteLine("Öğrenci Soyadı Giriniz");
                string soyisim = Console.ReadLine();
                Console.WriteLine("Doğum Tarihi Giriniz");
                int dogum = int.Parse(Console.ReadLine());
                Console.WriteLine("Öğrenci Numarası Girin");
                int ogrno = int.Parse(Console.ReadLine());
            }

            static void kitap(string adi, int sayfa, string yazar, int fiyat)
            {
                Console.WriteLine("kitabın adı" + ":" + adi + "\n" + "sayfa sayısı" + ":" + sayfa + "\n" + "yazarın adı" + ":" + yazar + "\n" + "fiyatı" + ":" + fiyat);
            } */
            #endregion

          

        }
    }
}

