using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[]
            {
                "Gelistirme",
                "Baslangic",
                "Java",
                "Python"

            };


            for (int i = 0 ; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.ReadLine();
        }
    }
}
