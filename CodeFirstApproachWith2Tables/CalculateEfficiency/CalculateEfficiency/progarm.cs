using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateEfficiency
{
    internal class progarm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the time by worker");
            float time = float.Parse(Console.ReadLine());
            string result = UserProgramCode.EfficiencyChecker(time);
            Console.WriteLine(result);
        }
    }
}
