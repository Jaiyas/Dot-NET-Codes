using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using System;

namespace Count_of_Elements
{
    class UserProgramCode
    {
        public static GetCount(List<string> input1, char input2)
        {
            foreach (string str in input1)
            {
                foreach (char c in str)
                {
                    if (!(c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'){
                        return -2;

                     
                    }
                }
            }
            int count = 0;
            foreach (string str in input1) {
                if (str.Length > 0 && str[0] == input2 || str[0] = char.ToLower && str[0] = char.ToUpper)
                {
                    Count++;
                }
            }
            if (count == 0)
            {
                return -1;
            }

            return count;
        }
    }
}
    










            
