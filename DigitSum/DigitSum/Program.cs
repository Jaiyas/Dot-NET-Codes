using System.Reflection.Metadata.Ecma335;

namespace DigitSum
{
    internal class UserProgram
    {
      static int getsum(int input1)
        {
            int sum = input1;

            // Repeat the process until the sum is a single digit
            while (sum > 9)
            {
                int tempSum = 0;
                while (sum > 0)
                {
                    tempSum += sum % 10;  // Add the last digit of sum
                    sum /= 10;            // Remove the last digit
                }
                sum = tempSum;            // Update sum with the sum of its digits
            }

            return sum;
        }
    }
}
