using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sum = 10;
            var Collection = new List<int> { 1, -2, 0, 2, 1, 4, 5, 5, 5, 5, 2, 3, 4, 20, 5, 6, 7, 8, 9, 5, 0, 10, 6, 7, 8, 9, 19, 29, -10, -19, 3, 33, -23, -90, 100 };
            CollectionHelper.GetPairs(Collection, Sum);
        }
    }
}
