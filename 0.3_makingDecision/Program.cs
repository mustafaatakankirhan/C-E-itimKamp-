using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._3_makingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region karar yapıları if-else

            //Console.WriteLine("lütfen size gönderilen 6 haneli kodu giriniz:");
            //Console.WriteLine("---------------------------------------------------");
            //string gelenKod = Console.ReadLine();
            //string sistemdeKayıtlıKod = "191919";
            //if (gelenKod == sistemdeKayıtlıKod)
            //{
            //    Console.WriteLine("koda erişim sağlandı, hoşgeldiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("girdiğiniz kod hatalı, lütfen tekrar deneyiniz.");
            //}










            #endregion

            #region if else üniversite not hesaplama örneği 

            //Console.WriteLine("üniversitenothesapla.com'a hoşgeldiniz.");
            //Console.WriteLine("---------------------------------------------------");
            //double vizeNotu, FinalNotu, ÖdevNotu, QuizNotu, OrtalamaNotu;
            //string genelDurum = "hatalı değer girdiniz!";

            //Console.Write("lütfen vize notunuzu giriniz: ");
            //vizeNotu = double.Parse(Console.ReadLine());
            //Console.Write("lütfen final notunuzu giriniz: ");
            //FinalNotu = double.Parse(Console.ReadLine());
            //Console.Write("lütfen ödev notunuzu giriniz: ");
            //ÖdevNotu = double.Parse(Console.ReadLine());
            //Console.Write("lütfen quiz notunuzu giriniz: ");
            //QuizNotu = double.Parse(Console.ReadLine());
            //OrtalamaNotu = (vizeNotu * 0.3) + (FinalNotu * 0.4) + (ÖdevNotu * 0.15) + (QuizNotu * 0.15);
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("ortalama notunuz: " + OrtalamaNotu);
            //if (OrtalamaNotu >= 85)
            //{
            //    genelDurum = "AA - Mükemmel";
            //}
            //else if (OrtalamaNotu >= 70)
            //{
            //    genelDurum = "BB - Çok İyi";
            //}
            //else if (OrtalamaNotu >= 55)
            //{
            //    genelDurum = "CC - İyi";
            //}
            //else if (OrtalamaNotu >= 45)
            //{
            //    genelDurum = "DD - Geçer";
            //}
            //else
            //{
            //    genelDurum = "FF - Kaldı";
            //}
            //Console.WriteLine("genel durumunuz: " + genelDurum);
            //Console.WriteLine("iyi dersler dileriz.");

            #endregion

            #region if else veya koşulu örneği
            //Console.Write("Lütfen Anne ya da Baba adınızı giriniz: ");
            //string ebeveynAd = Console.ReadLine();
            //if (ebeveynAd == "ayşe" | ebeveynAd == "ahmet")
            //{
            //    Console.WriteLine("İki faktörlü kimlik doğrulama başarılı!");

            //}
            //else
            //{
            //    Console.WriteLine("iki faktörlü kimlik doğrulama başarısız");
            //}

            #endregion

            #region if else eşit değilse örneği
            //Console.WriteLine("Tc Kimlik No Doğrulama Sistemine Hoşgeldiniz."); 
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Tc Kimlik No'nuzu doğrulamak için lütfen aşağıya giriniz.");
            //Console.WriteLine("Endişe etme! Tüm verileriniz üçüncü taraf kişilere karşı güvende :)  ");
            //Console.Write("Lütfen Tc Kimlik No Giriniz: ");
            //string tcKimlikNo = Console.ReadLine();
            //string sistemdeKayıtlıTc
            //    = "12345678900";
            //if (tcKimlikNo != sistemdeKayıtlıTc)
            //{
            //    Console.WriteLine("Tc Kimlik No doğrulama başarısız.");
            //    Console.WriteLine("Lütfen Tc Kimlik No'nuzu kontrol ediniz.");

            //}
            //else
            //{
            //    Console.WriteLine("Tc Kimlik No doğrulama başarılı.");
            //    Console.WriteLine("Hoşgeldiniz.");
            //}

            #endregion

            #region Genel Bir Proje Örneği 
         

        Console.WriteLine("Mustafa Atakan Kitapevi'ne Hoşgeldiniz!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Kitap Çeşitlerimiz: ");
            Console.WriteLine("1 - TYT HAZIRLIK KİTAPLARI: ");
            Console.WriteLine("2 - AYT HAZIRLIK KİTAPLARI: ");
            Console.WriteLine("3 - LGS HAZIRLIK KİTAPLARI: ");
            Console.WriteLine("4 - Hikaye Kitapları: ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("İki kitap alımında %10 indirim fırsatını kaçırmayın!");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Lütfen almak istediğiniz kitap çeşidinin numarasını giriniz: ");
            string kitapCesidi = Console.ReadLine();
            if (kitapCesidi == "1")
            {
            
                double kitapFiyatı, kitapAdedi, toplamTutar;
                double indirimOranı = 0.10;
                double indirimliTutar;
                double kitapfiyatı1 = 50.0; // TYT Matematik Kitapları fiyatı
                double kitapfiyatı2 = 40.0; // TYT Türkçe Kitapları fiyatı
                double kitapfiyatı3 = 60.0; // TYT Fen Bilimleri Kitapları fiyatı
                double kitapfiyatı4 = 45.0; // TYT Sosyal Bilimler Kitapları fiyatı

                Console.WriteLine("TYT Hazırlık Kitapları seçtiniz. İyi alışverişler dileriz!");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("1 - TYT Matematik Kitapları");
                Console.WriteLine("2 - TYT Türkçe Kitapları");
                Console.WriteLine("3 - TYT Fen Bilimleri Kitapları");
                Console.WriteLine("4 - TYT Sosyal Bilimler Kitapları");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Lütfen almak istediğiniz TYT kitap türünün numarasını giriniz: ");
                double tytKitapTuru = double.Parse(Console.ReadLine());
                if (tytKitapTuru == 1)
                {
                    
                    kitapFiyatı = kitapfiyatı1;
                }
                else if (tytKitapTuru == 2)
                {
                    kitapFiyatı = kitapfiyatı2;
                }
                else if (tytKitapTuru ==3)
                {
                    kitapFiyatı = kitapfiyatı3;
                }
                else if (tytKitapTuru ==4)
                {
                    kitapFiyatı = kitapfiyatı4;
                }
                else
                {
                    Console.WriteLine("Hatalı bir seçim yaptınız. Lütfen tekrar deneyiniz.");
                    return;
                    

                }
                Console.Write("Lütfen almak istediğiniz kitap adedini giriniz: ");
                kitapAdedi = double.Parse(Console.ReadLine());
                toplamTutar = kitapFiyatı * kitapAdedi;
                if (kitapAdedi >= 2)
                {
                    indirimliTutar = toplamTutar - (toplamTutar * indirimOranı);
                    Console.WriteLine("Toplam Tutar (İndirimsiz): " + toplamTutar +"TL");
                    Console.WriteLine("Toplam Tutar (İndirimli): " + indirimliTutar + " TL");
                    Console.WriteLine("İndirim Oranımız  %10 ile sınırlıdır. Bizi Tercih Ettiğiniz İçin Teşekkürler");
                }
                else
                {
                    Console.WriteLine("Toplam Tutar: " + toplamTutar + " TL");
                }
                Console.WriteLine("Alışverişiniz için teşekkür ederiz!");
                
                Console.WriteLine("---------------------------------------------------");

       

                }


            else if(kitapCesidi == "2") 
                {



                    double aytkitapFiyatı, aytkitapAdedi, ayttoplamTutar;
                    double aytindirimOranı = 0.10;
                    double aytindirimliTutar;
                    double aytkitapfiyatı1 = 100.0; // AYT Matematik Kitapları fiyatı
                    double aytkitapfiyatı2 = 140.0; // AYT Fizik Kitapları fiyatı
                    double aytkitapfiyatı3 = 94.0; // AYT Biyoloji Bilimleri Kitapları fiyatı
                    double aytkitapfiyatı4 = 49.90; // AYT Kimya Bilimler Kitapları fiyatı

                    Console.WriteLine("AYT Hazırlık Kitapları seçtiniz. İyi alışverişler dileriz!");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("1 - AYT Matematik Kitapları");
                    Console.WriteLine("2 - AYT Fizik Kitapları");
                    Console.WriteLine("3 - AYT Biyoloji Kitapları");
                    Console.WriteLine("4 - AYT Kimya Kitapları");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Lütfen almak istediğiniz AYT kitap türünün numarasını giriniz: ");
                    double aytKitapTuru = double.Parse(Console.ReadLine());
                    if (aytKitapTuru == 1)
                    {

                        aytkitapFiyatı = aytkitapfiyatı1;
                    }
                    else if (aytKitapTuru == 2)
                    {
                        aytkitapFiyatı = aytkitapfiyatı2;
                    }
                    else if (aytKitapTuru == 3)
                    {
                        aytkitapFiyatı = aytkitapfiyatı3;
                    }
                    else if (aytKitapTuru == 4)
                    {
                        aytkitapFiyatı = aytkitapfiyatı4;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız. Lütfen tekrar deneyiniz.");
                        return;


                    }
                    Console.Write("Lütfen almak istediğiniz kitap adedini giriniz: ");
                    aytkitapAdedi = double.Parse(Console.ReadLine());
                    ayttoplamTutar = aytkitapFiyatı * aytkitapAdedi;
                    if (aytkitapAdedi >= 2)
                    {
                        aytindirimliTutar = ayttoplamTutar - (ayttoplamTutar * aytindirimOranı);
                        Console.WriteLine("Toplam Tutar (İndirimsiz): " + ayttoplamTutar + "TL");
                        Console.WriteLine("Toplam Tutar (İndirimli): " + aytindirimliTutar + " TL");
                        Console.WriteLine("İndirim Oranımız  %10 ile sınırlıdır. Bizi Tercih Ettiğiniz İçin Teşekkürler");
                    }
                    else
                    {
                        Console.WriteLine("Toplam Tutar: " + ayttoplamTutar + " TL");
                    }
                    Console.WriteLine("Alışverişiniz için teşekkür ederiz!");

                    Console.WriteLine("---------------------------------------------------");
                }
            else if(kitapCesidi == "3")
            {


                
                double lgskitapFiyatı, lgskitapAdedi, lgstoplamTutar;
                double lgsindirimOranı = 0.10;
                double lgsindirimliTutar;
                double lgskitapfiyatı1 = 100.0; // LGS Matematik Kitapları fiyatı
                double lgskitapfiyatı2 = 140.0; // LGS Türkçe Kitapları fiyatı
                double lgskitapfiyatı3 = 94.0; // LGS Sosyal Kitapları fiyatı
                double lgskitapfiyatı4 = 49.90; // LGS Fen Bilimleri Kitapları fiyatı

                Console.WriteLine("LGS Hazırlık Kitapları seçtiniz. İyi alışverişler dileriz!");
                Console.WriteLine();    
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("1 - LGS Matematik Kitapları");
                Console.WriteLine("2 - LGS Türkçe Kitapları");
                Console.WriteLine("3 - LGS Sosyal Kitapları");
                Console.WriteLine("4 - LGS Fen Bilimleri Kitapları");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Lütfen almak istediğiniz AYT kitap türünün numarasını giriniz: ");
                double lgsKitapTuru = double.Parse(Console.ReadLine());
                if (lgsKitapTuru == 1)
                {

                    lgskitapFiyatı = lgskitapfiyatı1;
                }
                else if (lgsKitapTuru == 2)
                {
                    lgskitapFiyatı = lgskitapfiyatı2;
                }
                else if (lgsKitapTuru == 3)
                {
                    lgskitapFiyatı = lgskitapfiyatı3;
                }
                else if (lgsKitapTuru == 4)
                {
                    lgskitapFiyatı = lgskitapfiyatı4;
                }
                else
                {
                    Console.WriteLine("Hatalı bir seçim yaptınız. Lütfen tekrar deneyiniz.");
                    return;


                }
                Console.Write("Lütfen almak istediğiniz kitap adedini giriniz: ");
                lgskitapAdedi = double.Parse(Console.ReadLine());
                lgstoplamTutar = lgskitapFiyatı * lgskitapAdedi;
                if (lgskitapAdedi >= 2)
                {
                    lgsindirimliTutar = lgstoplamTutar - (lgstoplamTutar * lgsindirimOranı);
                    Console.WriteLine("Toplam Tutar (İndirimsiz): " + lgstoplamTutar + "TL");
                    Console.WriteLine("Toplam Tutar (İndirimli): " + lgsindirimliTutar + " TL");
                    Console.WriteLine("İndirim Oranımız  %10 ile sınırlıdır. Bizi Tercih Ettiğiniz İçin Teşekkürler");
                }
                else
                {
                    Console.WriteLine("Toplam Tutar: " + lgstoplamTutar + " TL");
                }
                Console.WriteLine("Alışverişiniz için teşekkür ederiz!");

                Console.WriteLine("---------------------------------------------------");

                
                
            }
            else if(kitapCesidi == "4")
            {
                double hikayekitapFiyatı, hikayekitapAdedi, hikayetoplamTutar;
                double hikayeindirimOranı = 0.10;
                double hikayeindirimliTutar;
                double hikayekitapfiyatı1 = 79.90; // Roman Kitapları fiyatı
                double hikayekitapfiyatı2 = 100.0; // Ansiklopedi Türkçe Kitapları fiyatı
                double hikayekitapfiyatı3 = 39.99; // Çocuk Hikaye Kitapları fiyatı
                double hikayekitapfiyatı4 = 49.90; // Ortaöğretim Nutuk Kitapları fiyatı

                Console.WriteLine("Hikaye Kitapları seçtiniz. İyi alışverişler dileriz!");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("1 - Roman  Kitapları");
                Console.WriteLine("2 - Ansiklopedi Kitapları");
                Console.WriteLine("3 - Çocuk Hikaye Kitapları");
                Console.WriteLine("4 - Ortaöğretim Nutuk Kitapları");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Lütfen almak istediğiniz kitap türünün numarasını giriniz: ");
                double hikayeKitapTuru = double.Parse(Console.ReadLine());
                if (hikayeKitapTuru == 1)
                {

                    hikayekitapFiyatı = hikayekitapfiyatı1;
                }
                else if (hikayeKitapTuru == 2)
                {
                    hikayekitapFiyatı = hikayekitapfiyatı2;
                }
                else if (hikayeKitapTuru == 3)
                {
                    hikayekitapFiyatı = hikayekitapfiyatı3;
                }
                else if (hikayeKitapTuru == 4)
                {
                    hikayekitapFiyatı = hikayekitapfiyatı4;
                }
                else
                {
                    Console.WriteLine("Hatalı bir seçim yaptınız. Lütfen tekrar deneyiniz.");
                    return;


                }
                Console.Write("Lütfen almak istediğiniz kitap adedini giriniz: ");
                hikayekitapAdedi = double.Parse(Console.ReadLine());
                hikayetoplamTutar = hikayekitapFiyatı * hikayekitapAdedi;
                if (hikayekitapAdedi >= 2)
                {
                    hikayeindirimliTutar = hikayetoplamTutar - (hikayetoplamTutar * hikayeindirimOranı);
                    Console.WriteLine("Toplam Tutar (İndirimsiz): " + hikayetoplamTutar + "TL");
                    Console.WriteLine("Toplam Tutar (İndirimli): " + hikayeindirimliTutar + " TL");
                    Console.WriteLine("İndirim Oranımız  %10 ile sınırlıdır. Bizi Tercih Ettiğiniz İçin Teşekkürler");
                }
                else
                {
                    Console.WriteLine("Toplam Tutar: " + hikayetoplamTutar + " TL");
                }
                Console.WriteLine("Alışverişiniz için teşekkür ederiz!");

                Console.WriteLine("---------------------------------------------------");



            

        }
            
            }
        }
            #endregion
        }
    

    


























