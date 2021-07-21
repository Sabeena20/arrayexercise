using System;
using System.Collections.Generic;

namespace listexercise
{
    public class Wordlength
    {
        public static String GetLength(List<String> words,int len)
        {

            foreach (string w in words)
            {
                if (w.Length == len)
                {
                    return w;
                    //Console.WriteLine(w);
                }
            }
            return null;
        }
    }
}
