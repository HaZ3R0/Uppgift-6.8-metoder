using System;
namespace fortnite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal för att undersöka det");
            int tal = int.Parse(Console.ReadLine());
            Primtal(tal);
        }

        static void Primtal(int tal)
        {
            int deltal = 0;
            int primtal = 0;

            for (int i = 1; i < tal; i++)
            {

                for (int j = 2; j < tal; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        deltal++;
                    }
                }
                if (deltal == 0)
                {
                    primtal++;
                }
                deltal = 0;
            }
            Console.WriteLine(primtal);
        }
    }
}
