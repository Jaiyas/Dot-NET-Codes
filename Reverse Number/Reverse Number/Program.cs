namespace Reverse_Number
{
   class UserProgram
    {
        public static int reversenumber(int input)
        {
            int reverse = 0;
            int temp = 0;
            while(input > 0)
            {
                temp = input % 10;
                reverse = reverse * 10 + temp;
                input /= 10;
            }
            return reverse;
        }
    }
}
