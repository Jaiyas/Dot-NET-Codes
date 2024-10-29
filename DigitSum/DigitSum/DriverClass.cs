using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSum
{
    internal class DriverClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" enter the non negative integer");
            int input = Convert.ToInt32(Console.ReadLine());
            int result = UserProgram.getSum(input);
            Console.WriteLine("Output: " + result);
        }
    }
}
