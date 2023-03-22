using System;
using System.Runtime.InteropServices;

namespace metoder
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett valfrit heltal");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            Console.WriteLine(" ");
            
            Console.WriteLine("Talet " + b + " har " + Primtal(b) +" Primtal unde sig");
        }
        static int Primtal(int tal)
        {
            int g = 0;
            
            for (int i = 0; i < tal; i++)
            {
                if (i % 3 == 0 & i !=3 || i % 2 == 0 & i !=2 || i % 5 ==0 & i!=5 || i % 7 ==0 & i !=7)
                {
                    continue;
                    
                }

                else if (i % 3 != 0 || i == 3 & i % 2 != 0 || i == 2)
                {
                    g++;
                    Console.WriteLine(i);
                }
               
            }
            return g;
            return 0;
        }
    }
}