using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //DeğişkenTürü[] DiziAdı = new DeğişkenTürü[Eleman Sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[0]);

            /* Dizide değeri tanımlanmamış bir index çağırılırsa
            ekranda varsayılan olarak "0" değeri gösterilir.*/

            //int[] numbers = new int[10]; 
            //numbers[0] = 55;
            //numbers[1] = 43;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[6]);

            //string[] cities = {"Prag","Roma","Atina","Berlin","Moskova" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Kırmızı","Beyaz","Yeşil","Turuncu","Sarı","Pembe","Mor" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 45, 866, 7264, 3215, 753, 1497, 356, 149, 368, 234, 98678 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '/', '*','-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //Dizideki en büyük sayıyı bulma
            //int[] myArray = { 87, 356, 41, 21, 78, 98, 246, 854, 345 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = {"ali", "ahmet","ayşe","buse","cem","deniz","kerem" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 79, 35, 49, 32, 46, 26, 64, 14 };
            //Array.Sort(numbers); SIRALAMA
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 79, 35, 49, 32, 46, 26, 64, 14 };
            //Array.Reverse(numbers); DİZİYİ TERS YAZDIRMA
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] persons = {"ali","buse","ayşegül","merve","çınar" };
            //int index = Array.IndexOf(persons,"merve");
            //Console.WriteLine(index);

            //Dizinin en büyük ve em küçük elemanını bulma
            //int[] numbers = { 78, 35, 94, 49, 85, 70, 38, 569 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: "+ numbers.Max()+ " Dizinin En Küçük Elemanı: "+ numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Length Şehrini Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{ 
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];

            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion

            Console.Read();
        }
    }
}
