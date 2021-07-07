using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndTesting
{
    public class FindThreeNumbers
    {
        public string FindMaxNumber(string number1, string number2, string number3)
        {
            if ((number1.CompareTo(number2) > 0) && (number1.CompareTo(number3) > 0))
            {
                return number1;
            }
            else if ((number2.CompareTo(number1) > 0) && (number2.CompareTo(number3) > 0))
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }
    }
}
