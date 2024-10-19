using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment3
{
    internal class ReverseArray
    {
        public static void ReverseArrayMethod<T>(T[] values)
        {
            if (values == null) throw new ArgumentNullException("array is null");
            int left = 0;
            int right = values.Length - 1;
            while (left < right)
            {
                T temp = values[left];
                values[left] = values[right];
                values[right] = temp;

                left++;
                right--;
            }
        }
    }
}
