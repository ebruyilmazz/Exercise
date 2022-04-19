using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir sayı giriniz");
            int num1 = Convert.ToInt32(Console.ReadLine());


            int birler = num1 % 10;
            int onlar = num1 / 10;

            switch (onlar)
            {
                case 1:
                    Console.WriteLine("On");
                    break;
                case 2:
                    Console.WriteLine("Yirmi");
                    break;
                case 3:
                    Console.WriteLine("Otuz");
                    break;
                case 4:
                    Console.WriteLine("Kırk");
                    break;
                case 5:
                    Console.WriteLine("Elli");
                    break;
                case 6:
                    Console.WriteLine("Altmış");
                    break;
                case 7:
                    Console.WriteLine("Yetmiş");
                    break;
                case 8:
                    Console.WriteLine("Seksen");
                    break;
                case 9:
                    Console.WriteLine("Doksan");
                    break;

            }
            switch (birler)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("İki");
                    break;
                case 3:
                    Console.WriteLine("Üç");
                    break;
                case 4:
                    Console.WriteLine("Dört");
                    break;
                case 5:
                    Console.WriteLine("Beş");
                    break;
                case 6:
                    Console.WriteLine("Altı");
                    break;
                case 7:
                    Console.WriteLine("Yedi");
                    break;
                case 8:
                    Console.WriteLine("Sekiz");
                    break;
                case 9:
                    Console.WriteLine("Dokuz");
                    break;
            }

            Console.ReadKey();
        }
    }
}
