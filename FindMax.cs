using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment3
{
    internal class FindMax
    {
        public static T FindMaxMethod<T>(T[] array) where T:IComparable<T>
        {
            if(array == null || array.Length == 0)
            
                throw new ArgumentNullException(nameof(array));
                
            
            T max = array[0];
            foreach (var item in array)
            {
                if (item.CompareTo(max)>0)
                {
                    max = item;
                }
              

            }
            return max;
        }
                   

    }
}
