using System;

namespace Matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] m = new int[10];
            int broj = 11;

            for (int i = 0; i < 10; i++)
            {
                m[i] = broj;
                broj += 2;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(m[i] + " ");
            }
        }

    }
}
