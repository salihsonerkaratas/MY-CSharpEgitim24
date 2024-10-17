using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4) --> 1: Değişken Türü, 2: Değişken Adı, 3: In, 4: Liste, Koleksiyon, Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova", "Moskova", "Bükreş" };
            //foreach (var x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = {72,32,157,546,85,36,49,356,358,596,1468 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 72, 32, 157, 546, 85, 36, 49, 356, 358, 596, 1468 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 72, 32, 157, 546, 85, 36, 49, 356, 358, 596, 1468 };
            //int total = 0;

            //foreach (var i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8
            //};

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("******* C# Eğitim Kampı Sınav Uygulaması ********");
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızdaki Öğrenci Sayısı: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isim ve not ortalamalarının saklanacağı diziler.
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;
                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notlar toplamı
                    
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
                Console.WriteLine("------------------------------");
            }

            //Öğrencilerin sınav ortalamaları 

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti!");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı!");
                }

                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}
