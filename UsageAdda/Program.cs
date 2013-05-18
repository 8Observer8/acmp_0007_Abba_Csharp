using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acmp_0007_Abba_Csharp;

namespace UsageAdda
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstHeap = "189285";
            string secondHeap = "283";
            string thirdHeap = "4958439238923098349024";

            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            System.Console.WriteLine("firstHeap = " + firstHeap);
            System.Console.WriteLine("secondHeap = " + secondHeap);
            System.Console.WriteLine("thirdHeap = " + thirdHeap);
            System.Console.WriteLine();
            System.Console.WriteLine("result = " + result);
        }
    }
}
