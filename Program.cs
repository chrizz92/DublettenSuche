using System;

namespace DublettenSuche.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[10];
            int[] counter = new int[names.Length];



            Console.WriteLine("Dublettensuche");
            Console.WriteLine("==============");

           for(int i = 0; i < names.Length; i++)
            {
                Console.Write("Name Nr. {0,2} eingeben: ", i+1);
                names[i] = Console.ReadLine();
                for(int j = 0; j < i; j++)
                {
                    if (names[i] == names[j])
                    {
                        counter[i]++;
                    }
                }
                
            }

            Console.WriteLine("Eingegebene Namen:");

            for (int k = 0; k < names.Length; k++)
            {
                if (counter[k] == 0)
                {
                    Console.WriteLine("{0}", names[k]);
                }
            }

            Console.WriteLine("Folgende Namen wurden mehrfach eingegeben:");

            for (int m = 0; m < names.Length; m++)
            {
                if (counter[m] == 1)
                {
                    Console.WriteLine("{0}", names[m]);
                }
            }
        }
    }
}
