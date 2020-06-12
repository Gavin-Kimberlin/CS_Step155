using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step155
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n                                                        Math App 2\n=======================================================================================================================");
            Console.WriteLine("Enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userNum + " times 226 is " + Maths.Method(userNum));
            Console.WriteLine(userNum + " divided by 2 is " + Maths.Method(Convert.ToDecimal(userNum)));
            Console.WriteLine(userNum + " squared is " + Maths.Method(userNum.ToString()));
            Console.ReadLine();
        }
    }
}
