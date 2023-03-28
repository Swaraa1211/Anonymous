using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    internal class LambaEx
    {
        public static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 10,2,3,4,5,6,15,7,8};
            List<int> divBy5 = l1.FindAll(n => n%5 == 0);
            List<string> s1 = new List<string> {"ab", "bc", "acd", "de" };
            //List<string> containsA = s1.FindAll(s => s.Contains("a"));

            List<string> containsA = s1.OrderBy(s => s).ToList();
            foreach (int n in divBy5)
            {
                Console.WriteLine(n);
            }
            foreach(string s in containsA)
            {
                Console.WriteLine(s);
            }
        }
    }
}
