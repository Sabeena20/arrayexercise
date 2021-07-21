using System;

namespace arrayexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNos = { 1, 1, 2, 3, 5, 8 };

            foreach(int i in randomNos)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
