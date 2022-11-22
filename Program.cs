using System;

namespace diziler
{
    class program
    {
        static void Main(string[] args)
        { 
            Console.Write("Lütfen Dizinin eleman Sayısını Giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen{0}.sayısı giriniz",i+1);
                sayıDizisi[i]= int.Parse(Console.ReadLine());
            }


             Console.Write("Lütfen Dizinin eleman Sayısını Giriniz: ");
            int diziUzunlugu2 = int.Parse(Console.ReadLine());
            int[] sayıDizisi2 = new int[diziUzunlugu2];

            for (int y = 0; y < diziUzunlugu2; y++)
            {
                Console.Write("Lütfen{0}.sayısı giriniz",y+1);
                sayıDizisi2[y]= int.Parse(Console.ReadLine());
            }

            int[]deneme = sayıDizisi;
            int[]deneme2 =sayıDizisi2;
            int[]combined = combined= deneme.Concat(deneme2).ToArray();

            Array.Sort(combined);

            for (int i = 0; i < combined.Length ; i++)
            {
                Console.WriteLine(combined[i]);
            }
            


            
            


          
        }
    }
}      