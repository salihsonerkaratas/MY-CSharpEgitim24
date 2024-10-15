using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Koşulu

            //Console.Write("Lütfen Şifre Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" || capital == "Ankara" && country == "türkiye" || country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result = "Hata!";

            //Console.Write("1. Sınav Sonucunu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Sonucunu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Sonucunu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + avarage);

            //if (avarage > 0 & avarage <= 50)
            //{
            //    result = "Başarısız";
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "Orta";
            //}
            //if (avarage > 70 & avarage <= 84)
            //{
            //    result = "İyi";
            //}
            //if (avarage > 84)
            //{
            //    result = "Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.Write("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Kullanıcı Adı Giriniz: ");
            //string userName = Console.ReadLine();
            //if (userName != "admin")
            //{
            //    Console.WriteLine("Bu Kullanıcının Giriş Yapma Yetkisi Yoktur!");
            //}
            //else
            //{
            //    Console.WriteLine("Admin Girişi Başarılı..");
            //}



            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Birinci Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. Sayının 2. Sayıya Bölümünden Kalan: " + result);

            //Console.Write("Lütfen Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çift");
            //}
            //else
            //{
            //    Console.Write("Sayı Tek");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen Takım Sembolün Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Takım Bulunamadı");
            //}

            #endregion

            #region Örnek Proje Uygulaması 

            //Console.WriteLine("******** C# Kamp Restoran ********");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını Görmek İstediğiniz Menü Seçimi: ");
            //menuItem = Console.ReadLine();
            //Console.WriteLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Ana Yemekler-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Balık");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Ana Yemekler-----------------");
            //    Console.WriteLine();
            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Çorbalar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-Tarhana Çorbası");
            //    Console.WriteLine("4-Domates Çorbası");
            //    Console.WriteLine("5-Yoğurt Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Çorbalar-----------------");
            //    Console.WriteLine();
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Pizzalar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Dört Peynirli Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Marinara Pizza");
            //    Console.WriteLine("4-Puglia Pizza");
            //    Console.WriteLine("5-Dört Mevsim Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Pizzalar-----------------");
            //    Console.WriteLine();
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------İçecekler-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kahve");
            //    Console.WriteLine("3-Kola");
            //    Console.WriteLine("4-Gazoz");
            //    Console.WriteLine("5-Fanta");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------İçecekler-----------------");
            //    Console.WriteLine();
            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Tatlılar-----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Baklava");
            //    Console.WriteLine("2-Katmer");
            //    Console.WriteLine("3-Künefe");
            //    Console.WriteLine("4-Kazandibi");
            //    Console.WriteLine("5-Triliçe");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Tatlılar-----------------");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Giriş");
            //}

            #endregion

            #region Switch-Case Yapısı

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            
            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak İstediğiniz İşlemi Giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //    default: Console.WriteLine("Hatalı İşlem Girişi");break;

            //}

            #endregion

            Console.Read();
        }
    }
}
