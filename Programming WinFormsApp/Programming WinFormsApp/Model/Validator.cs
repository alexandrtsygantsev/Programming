using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Validator
    {
        public static bool AssertOnPositiveValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("value");
                return false;
            }
            return true;
        }
        public static bool AssertOnPositiveValue(double value)
        {
            if (value < 0.0)
            {
                throw new ArgumentException("value");
                return false;
            }
            return true;
        }
    }
}
