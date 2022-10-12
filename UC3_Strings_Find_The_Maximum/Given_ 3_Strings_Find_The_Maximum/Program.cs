using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Given_3_Strings_Find_The_Maximum
{
    internal class string_Maximum
    {
        public class main
        {
            public static void Main(String[] args)
            {
                string_Maximum maximum = new string_Maximum();
                Console.WriteLine("Maximum Value:");
                Console.WriteLine(maximum.getmax("BBB", "CCC", "AAA"));
                Console.ReadLine();
            }
        }

        public string getmax(string firstValue, string secondValue, string thirdValue)
        {
            string max = firstValue;
            if (secondValue.CompareTo(max) > 0)
                max = secondValue;
            if (thirdValue.CompareTo(max) > 0)
                max = thirdValue;
            return max;
        }
        
    }    
}
