using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Elements
{
    internal class Driverclass
    {
        public static void Main(string[] args)
        {
            List<string> input1 = new List<string> { "abc", "Apple", "Mango" };
            char input2 = 'a';
            int result = UserProgramCode.GetCount(input1,input2);
            if (result == -1)
            {
                Console.WriteLine(" no element found");
            }
            else if (result == -2)
            {
                Console.WriteLine("only  alphabet is found");
            }
            else
            {
                Console.WriteLine("result");
            }
        }
    }
}
