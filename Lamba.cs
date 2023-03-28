using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    internal class Lamba
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        public static void Main(string[] args)
        {
            
            Lamba obj = new();
            var worker = (int number) => number % 2 == 0;
            int count = obj.CountNum(worker);
            Console.WriteLine(count);

            
            /*int count = numbers.Count((number) => number % 2 == 0);
            Console.WriteLine(count);*/
            /*Lamba obj = new();
            int result = obj.TestMethod(5, 6);
            Console.WriteLine(result);*/
            
        }
        public int CountNum(Func<int, bool> callback)
        {
            return this.numbers.Count(callback);
        }

        /*public int TestMethod(int x, int y)
        {
            var result = (int x, int y) =>
            {
                int total = 0;
                total = x + y;
                return total;
            };
            return result(x,y);
        }*/
    }
}
/*List<int> num = new List<int>() { 1,2,3,4,5,6,7,8};

            var sq = (int n) => { return n * n; };

            foreach(int i in num)
            {
                Console.WriteLine(sq(i));
            }
*/