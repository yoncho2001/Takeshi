using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Takeshi
{
    public class Validate
    {
        public static void isPositive(int input)
        {
            if (input < 0)
            {
                throw new ArgumentException("cannot be negative.");
            }
        }

        public static void isPositive(double input)
        {
            if (input < 0)
            {
                throw new ArgumentException("cannot be negative.");
            }
        }

        public static void isString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("Null input is not allowed ");
            }
        }
    }
}
