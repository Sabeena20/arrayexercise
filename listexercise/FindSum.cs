using System;
using System.Collections.Generic;
using System.Text;

namespace listexercise
{
    public class FindSum
    {
        public static int GetSumOfEven(List<int> numbers)
        {
            int sum = 0;
            foreach(int n in numbers) { 
              if(n % 2 == 0)
                {
                    sum += n;
                }
            }
            return sum;
        }

    }
}
