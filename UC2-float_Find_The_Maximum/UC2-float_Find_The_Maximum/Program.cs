using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_float_Find_The_Maximum
{
    internal class float_Maximum
    {
        public class main
        {
            public static void Main(String[] args)
            {

                float_Maximum maximum = new float_Maximum();
                Console.WriteLine("Maximum Value:");
                Console.WriteLine(maximum.getmax(12.3f, 15.8f, 85.3f));
                Console.ReadLine();
            }
        }
        public float getmax(float firstValue, float secondValue, float thirdValue)
        {
            float max = firstValue;
            if (secondValue.CompareTo(max) > 0)
                max = secondValue;
            if (thirdValue.CompareTo(max) > 0)
                max = thirdValue;
            return max;
        }
       
       
    }
}
