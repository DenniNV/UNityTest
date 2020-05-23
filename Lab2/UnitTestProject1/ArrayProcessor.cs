using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class ArrayProcessor
    {
        public int[] SortAndFilter(int[] a)
        {
            List<int> array = new List<int>();

            for(int i = 0; i<a.Length; i++)
            {
                if (a[i] >= 1000)
                {
                    array.Add(a[i]);
                }
            }
            return array.ToArray();
        }
    }
}
