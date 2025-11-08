using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2_değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler double
            #region
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine(" --- *** galerisi ---");
            //double mercedesFiyat = 750000.99;
            //double bmwFiyat = 680000.50;
            //double audiFiyat = 720000.75;
            //Console.WriteLine("Mercedes Fiyatı: " + mercedesFiyat);
            //Console.WriteLine("BMW Fiyatı: " + bmwFiyat);
            //Console.WriteLine("Audi Fiyatı: " + audiFiyat); 
            //Console.WriteLine("---------------------------------------------------");

            //Console.WriteLine("");
            //Console.WriteLine(" --- *** Satın Alınan Araçlar ---");
            //Console.WriteLine("");

            //double mercedesadet = 3;
            //double bmwadet = 4;
            //double audiadet = 2;
            //double toplamFiyat = (mercedesFiyat * mercedesadet) + (bmwFiyat * bmwadet) + (audiFiyat * audiadet);
            //Console.WriteLine("Toplam Satın Alınan Araç Fiyatı: " + toplamFiyat);   
            //Console.Read();
            #endregion


            #region klavyeden string veri alma

            // Console.WriteLine(" -****- Mustafa Atakan Araba Galerisi -****-  ");
            // Console.WriteLine("-------------------------------------------------");
            // Console.WriteLine("mercedes marka araçlarımız mevcuttur.");
            // Console.WriteLine("-------------------------------------------------");
            // string mercedes = "m";
            // Console.WriteLine("istediğiniz araba markasının baş harfini tuşlayınız.");
            // Console.WriteLine("mercedes için m tuşlayınız. ");
            // Console.WriteLine("UYARI! ŞUAN SADECE MERCEDES MARKA ARAÇ SATIŞI VARDIR!");
            // mercedes =Console.ReadLine();
            // Console.WriteLine("-------------------------------------------------");
            // Console.WriteLine("Teşekkürler, istediğiniz araba markası mercedes'tir.");
            // Console.WriteLine("-------------------------------------------------");
            // Console.WriteLine(""); 
            // Console.Write("Lütfen bilgi almak istediğiniz araba markasının baş harfini yazınız. ");

            // mercedes = Console.ReadLine();


            // Console.WriteLine("***----------------------------------------***");
            // Console.WriteLine("Seçtiğiniz araç markasının bilgisi aşağıdadır.");
            // Console.WriteLine("Araç Markası: Mercedes");
            // Console.WriteLine("Model Yılı: 2022");
            // Console.WriteLine("Renk: Siyah");
            //Console.WriteLine("Fiyat: 750.000,99 TL");
            // Console.WriteLine("***----------------------------------------***");
            // Console.WriteLine("güvenli yolculuklar.");

            // Console.WriteLine("***----------------------------------------***");

            // Console.WriteLine("bizi tercih ettiğiniz için teşekkürler <3 ");









            #endregion

            #region klavyeden tam sayı veri alma ve dönüştürme 

            // Console.WriteLine("Muzo Tarım Ürünleri Satış Mağazası");
            // int elmaFiyat, armutFiyat, muzFiyat, toplamFiyat, elmaAdet, armutAdet, muzAdet;
            // elmaFiyat = 5;
            // armutFiyat = 7;
            // muzFiyat = 10;
            // Console.WriteLine("-------------------------------------------------------------");
            // Console.WriteLine("");
            // Console.WriteLine("Ürün adet Fiyatları Aşağıdadır.");
            // Console.WriteLine("Elma Fiyatı: " + elmaFiyat);
            // Console.WriteLine("Armut Fiyatı: " + armutFiyat);
            // Console.WriteLine("Muz Fiyatı: " + muzFiyat);
            // Console.WriteLine("");
            // Console.WriteLine("Lütfen almak istediğiniz ürün adetlerini sırayla giriniz.");

            // Console.WriteLine("armut adetini giriniz:");
            // armutAdet =int.Parse( Console.ReadLine());
            // Console.WriteLine("muz adetini giriniz:");
            // muzAdet =int.Parse( Console.ReadLine());
            // Console.WriteLine("elma adetini giriniz:");
            // elmaAdet =int.Parse( Console.ReadLine());
            // toplamFiyat = (elmaFiyat * elmaAdet) + (armutFiyat * armutAdet) + (muzFiyat * muzAdet);
            // Console.WriteLine("");
            // Console.WriteLine(" --- *** Muzo Tarım Ürünleri Satış Mağazası *** --- ");
            // Console.WriteLine("-------------------------------------------------------------");
            // Console.WriteLine("toplam fiyat aşağıdadır.");
            // Console.WriteLine("Toplam Tutar: " + toplamFiyat); 
            // Console.WriteLine("-------------------------------------------------------------");
            //Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler. ");









            #endregion

            #region klavyeden ondalıklı sayı alma ve dönüştürme



            //double sınav1, sınav2, ortalama;
            //Console.Write("1. Sınav Notunuzu Giriniz: ");
            //sınav1=double.Parse( Console.ReadLine());
            //Console.Write("2. Sınav Notunuzu Giriniz: ");   
            //sınav2=double.Parse( Console.ReadLine());
            //ortalama = (sınav1 + sınav2) / 2;
            //Console.WriteLine("Ortalamanız: " + ortalama);
            //Console.WriteLine(ortalama >= 50 ? "Tebrikler, Sınıfı Geçtiniz!" : "Maalesef, Sınıfta Kaldınız.");




            #endregion

            #region klavyeden karakter alma
        //    Console.WriteLine("Lütfen bir karakter giriniz:");
        //    char karakter = Char.Parse(Console.ReadLine());

        //Console.WriteLine("Girdiğiniz karakter: " + karakter);
            #endregion





            Console.Read(); 
        }
    }
}
