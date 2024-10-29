namespace CalculateEfficiency
{
    class UserProgramCode
    {
        public static string EfficiencyChecker(float time)
        {
            if (time >= 1 && time <= 3)
            {
                 return " Highly efficient";
            }
            else if (time >= 3 && time <= 4)
            {
                 return "Improve speed ";
            }
            else if (time > 5)
            {
                 return "leave the company";
            }
            else
            {
                return "invalid input";
            }
        }
    }
}
