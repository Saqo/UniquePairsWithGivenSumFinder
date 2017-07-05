using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public static class CollectionHelper
    {
        public static void GetPairs(IList<int> collection, int sum)
        {
            var dict = new Dictionary<int, int>();
            var hashSet = new HashSet<string>();
            for (int i = 0; i < collection.Count; i++)
            {
                if (!dict.ContainsKey(collection[i]))
                    dict.Add(collection[i], i);
            }
            for (int i = 0; i < collection.Count; i++)
            {
                if (dict.ContainsKey(sum - collection[i]) &&
                    dict[sum - collection[i]] != i &&
                    collection[i] <= (sum - collection[i]) &&
                    !hashSet.Contains("" + dict[sum - collection[i]] + collection[i]))
                {
                    hashSet.Add("" + dict[sum - collection[i]] + collection[i]);
                    Console.WriteLine(collection[i].ToString() + " " + (sum - collection[i]).ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
