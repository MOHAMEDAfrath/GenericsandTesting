using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndTesting
{
    public class FindThreeNumbers<T> where T : IComparable
    {
        public T number1, number2, number3;
        public T[] array;
        public FindThreeNumbers(T[] array)
        {
            this.array = array;
        }
        public FindThreeNumbers(T number1, T number2, T number3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;

        }
        public T FindMaxNumber(T number1, T number2, T number3)
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
        public T[] sorting(T[] array)
        {
            Array.Sort(this.array);
            return this.array;
        }
        public T MaxFromArray(T[] array)
        {
            return this.array[^1];
        }
        public T Max()
        {
            T max = FindMaxNumber(this.number1, this.number2, this.number3);
            return max;

        }
        public T MaxArray()
        {
            Console.WriteLine(MaxFromArray(sorting(this.array)));
            return(MaxFromArray(sorting(this.array)));
        }
    }

}
        
    

