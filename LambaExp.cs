using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    internal class LambaExp
    {
        //delegate int add(int a, int b);
        delegate void Greet(string msg);

        static void Main(string[] args)
        {
            //add sum = (num1, num2) => num1 + num2;
            Greet m = (str) => Console.WriteLine(str);

            //int n1 = 5, n2 = 4;
            var sum = (int n1, int n2) => n1 + n2;
            //sum += (int n1, int n2) => n1 - n2;//outputs this alone

            var diff = (int n1, int n2) => n1 - n2;
            Console.WriteLine(sum(5, 9)+"\n" + diff(5,9));

            m.Invoke("Greetings!");

            var mul = (int num1, int num2) => num1 * num2;
            Console.WriteLine(mul(2, 30));
            //mul += (int num1, int num2) => num1 + num2;

            mul += sum; //have to use delegate to combine all the methods
            foreach (Delegate a in mul.GetInvocationList())
            {
                Console.WriteLine(a.DynamicInvoke(2, 3));
            }

        }
    }
}
