using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Number
{
    internal class Driverclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the positive number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = UserProgram.reversenumber(number);
            Console.WriteLine("output:" + result);


        }
    }
}
