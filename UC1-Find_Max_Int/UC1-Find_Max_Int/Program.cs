using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_Find_Max_Int
{
    public class main
    {
        public static void Main(String[] args)
        {

            FindMaximum maximum = new FindMaximum();
            Console.WriteLine("Maximum Value:");
            Console.WriteLine(maximum.getMax(60, 50, 55));
            Console.ReadLine();
        }

    }
    internal class FindMaximum
    {
        public int getMax(int firstValue, int secondValue, int thirdValue)
        {
            int max = firstValue;
            if (secondValue.CompareTo(max) > 0)
                max = secondValue;
            if (thirdValue.CompareTo(max) > 0)
                max = thirdValue;
            return max;
        }        
    }
}
