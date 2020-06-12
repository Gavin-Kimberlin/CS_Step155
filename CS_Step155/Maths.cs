using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step155
{
    class Maths
    {
        public static int Method(int input)
        {
            int output = input * 226;
            return output;
        }
        public static decimal Method(decimal input)
        {
            int output = Convert.ToInt32(input) / 2;
            return output;
        }
        public static double Method(string input)
        {
            int output = Convert.ToInt32(input) * Convert.ToInt32(input);
            return output;
        }
    }
}
