using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;

            //           number = 4.85;
            //         Console.WriteLine(number);
            //       Console.Read();

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawyberryPrice, potatoPrice, tomatoPrice;

            //applePrice=14.85;
            //orangePrice = 20.95;
            //strawyberryPrice = 45;
            //potatoPrice  = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice +" TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawyberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.560;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice=appleGram*applePrice;
            //double orangeTotalPrice=orangeGram*orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawyberryPrice;
            //double potatoTotalPrice=potatoGram*potatoPrice; 
            //double tomatoTotalPrice=tomatoGram*tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - "  + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam tutar: " + appleTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam tutar: " + orangeTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawyberryPrice + " - Gramaj: " + strawberryGram + " - Toplam tutar: " + strawberryTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam tutar: " + potatoTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam tutar: " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + " TL");



            //Console.Read();

            #endregion


            #region Char Değişkenler

            //char symbol;
            //symbol= 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik NO: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();


            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passangerIdentityNumber + " Yolcu Ad Soyad: " + passangerName + " " + passangerSurname + "" + "Diğer Bilgiler: " + passangerDistrict + passangerCity + passangerAge );


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount,computerCount,chairCount,tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız TV Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine("Ödemeniz Gereken Tutar: " + totalPrice + "TL");
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            double exam1, exam2, exam3,result;

            Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            exam1=double.Parse(Console.ReadLine());


            Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            exam2 =double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            exam3 =double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion
            Console.Read();
        }
       
    }
}
