using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //Metotların sonunda () işareti olur.
            //Geri değer döndüren ve döndürmeyen metotlar olarak iki türü vardır.
            //Değer döndürmeyen metotlar void metotlardır.

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Serkan Kara");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Gülerce");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Yunus Şener");

            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //customerCard("Mehmet","Yaz");
            //customerCard("Aslı","Günce");

            #endregion

            #region Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}

            //Sum(5, 9, 3);

            #endregion

            #region Değer DÖNDÜREN Metotlar

            //Geriye döndüreceği değerin türüne göre tanımlanır.

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(studentCard());

            #endregion

            #region Değer DÖNDÜREN String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adınız Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengi Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine();
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Değer DÖNDÜREN Int Parametreli Metotlar

            //int Sum(int x, int y)
            //{
            //    int result = x + y;
            //    return result;
            //}

            //Console.WriteLine(Sum(9,4));
            //Console.WriteLine(Sum(44,78));
            //Console.WriteLine(Sum(10,24));

            #endregion

            #region Örnek Uygulama

            //string examResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " İsimli Öğrenci Sınavı Geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " İsimli Öğrenci Sınavı Geçemedi " + "Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(examResult("Ali", 40, 32, 50));
            //Console.WriteLine(examResult("Beren", 60, 71, 78));

            #endregion

            Console.Read();
        }
    }
}
