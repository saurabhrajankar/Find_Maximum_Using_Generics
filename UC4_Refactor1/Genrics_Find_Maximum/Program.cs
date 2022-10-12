using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics_Find_Maximum
{
    public class main
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Maximum Value Of Integer");
            Console.WriteLine(Refactor.getmax<int>(50, 20, 70)); 
            Console.WriteLine("Maximum Value Of Flot:");
            Console.WriteLine(Refactor.getmax<float>(15.3f, 45.5f, 13.2f)); 
            Console.WriteLine("Maximum Value Of String:");
            Console.WriteLine(Refactor.getmax<string>("BBB", "CCC", "AAA")); 
            Console.ReadLine();
        }
    }
    internal class Refactor
    {
        public static E getmax<E> (E firstValue, E secondValue, E thirdValue) where E : IComparable
        {
              E max = firstValue;
            if (secondValue.CompareTo(max) > 0)
                max = secondValue;
            if (thirdValue.CompareTo(max) > 0)
                max = thirdValue;
            return max;
        }
    }
}
