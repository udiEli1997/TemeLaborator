using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] tablou = new string[26][];
            int[] dimensiuni = new int[26];
            for(int i = 0; i < 26; i++)
            {
                tablou[i] = new string[10];
                
            }
            foreach(var cuvant in args)
            {
                int index = (int)cuvant.ToLower()[0] - 97;
                tablou[index][dimensiuni[index]] = cuvant;
                dimensiuni[index]++;
            }
            for(int i = 0; i < 26; i++)
            {
                for(int j = 0; j < dimensiuni[i]; j++)
                {
                    Console.Write("{0} ", tablou[i][j]);
                }
                if (dimensiuni[i] != 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
