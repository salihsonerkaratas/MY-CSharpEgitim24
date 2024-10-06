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
            #region Dubole Değişkenler

            //double number;
            //number = 4.85;

            //Console.WriteLine(number);
            //Console.WriteLine("*-*-*-*-*-*-*-* FİYAT LİSTESİ *-*-*-*-*-*-*-*-*");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 50.75;
            //potatoPrice = 9.25;
            //tomatoPrice = 10;

            //Console.WriteLine("------ Elma Birim Fiyatı: " + applePrice +" TL");
            //Console.WriteLine("------ Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("------ Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("------ Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("------ Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.115;
            //orangeGram = 2.324;
            //strawberryGram = 0.750;
            //potatoGram = 4.976;
            //tomatoGram = 3.480;

            //Console.WriteLine();

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma | " + "Birim Fiyat: " + applePrice + " | Gramaj: " + appleGram + " | Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal | " + "Birim Fiyat: " + orangePrice + " | Gramaj: " + orangeGram + " | Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek | " + "Birim Fiyat: " + strawberryPrice + " | Gramaj: " + strawberryGram + " | Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates | " + "Birim Fiyat: " + potatoPrice + " | Gramaj: " + potatoGram + " | Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates | " + "Birim Fiyat: " + tomatoPrice + " | Gramaj: " + tomatoGram + " | Toplam Tutar: " + tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //String ifadeler " işareti ile char değişkenler ' ile gösterilir.
            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri "String"

            //Console.WriteLine("******* CSharp Hava Yolları Yolcu Bilgisi ********");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No: " + passengerIdentityNumber + "| Yolcu: " +passengerName +" "+ passengerSurname + " İkamet : " + passengerDistrict + " / " + passengerCity + " Yaş : " + passengerAge);

            #endregion

            #region Veri Girişleri ve Tip Dönüşümleri "int"

            //int shoesPrice, computerPrice, phonePrice, chairPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //phonePrice = 15000;
            //chairPrice = 1000;

            //int shoesCount, computerCount, phoneCount, chairCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız telefon sayısını giriniz: ");
            //phoneCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + phoneCount * phonePrice + chairCount * chairPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Not Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Cinsiyer Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyer: " + gender);

            #endregion

            Console.Read();
        }
    }
}
