using System;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = new string[9]
            {
              "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
              "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"
            };
            Console.WriteLine("\n");
            Console.WriteLine("Sample : Display the list according to the length then by name in ascending order :\r\n--------------------------------------------------------------------------------  \r\n");

            Console.WriteLine("The cities are :\n");
            var k = 0;
            foreach (var item in strings)
            {
                Console.Write(strings[k]+" ");
                k++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Here is the arranged list : ");
            Console.WriteLine("------------------------------");
            var temp = "";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (strings[j].Length > strings[j+1].Length)
                    {
                        temp= strings[j];
                        strings[j]= strings[j + 1];
                        strings[j + 1]= temp;
                    }
                }
            }


            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }

            Console.ReadLine();
        }
    }
}
