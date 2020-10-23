using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            char[] bruh = new char[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                bruh[i] = original[i];
            }
            string wut = string.Join("", bruh);
            wut = null;
            foreach (char k in original)
            {
                wut = wut + k + k;
            }
            return wut;



            



        }

    }
}
