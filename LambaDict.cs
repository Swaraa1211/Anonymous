using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    internal class LambaDict
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(2, "f");
            dict.Add(5, "c");
            dict.Add(4, "d");
            dict.Add(6, "e");
            dict.Add(3, "b");
            dict.Add(1, "a");
            // descending order nly for numbers so x.key*-1 or use OrderByDescending
            foreach (var item in dict.OrderBy(x => x.Key * -1).ToList()) //x.Key sorts according to the key
            {
                Console.WriteLine(item);
            }

            int[] arr = { 2, 3, 2, 0, 35 };
            foreach (var item in arr.OrderBy(x => -x).ToList())
            {
                Console.WriteLine(item);
            }

            /*int[,] arr1 =
            {
                {1,2 },
                {4,1 },
                { 5,7},
                {6,5 },
            };

            foreach(var k in Array.Sort(arr1, (x,y))
            {
                Console.WriteLine(k);
            }*/
        }
    }
}
