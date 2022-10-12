using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor2
{
    public class ProgramP
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Maximum Value Of Integer:");
            Console.WriteLine(Refactor3<int>.getmax(50, 20, 70)); 
            Console.WriteLine("Maximum Value Of Flot:");
            Console.WriteLine(Refactor3<float>.getmax(15.3f, 45.5f, 13.2f)); 
            Console.WriteLine("Maximum Value Of String:");
            Console.WriteLine(Refactor3<string>.getmax("CCC", "BBB", "AAA")); 
            Console.ReadLine();
        }
    }
    internal class Refactor3<E> where E : IComparable
    {
        public E firstValue, secondValue, thirdValue;

        public Refactor3(E firstValue, E secondValue, E thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public static E
            getmax(E firstValue, E secondValue, E thirdValue)
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