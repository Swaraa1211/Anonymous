namespace Anonymous
{
    delegate int delegateForMath(int a, int b);
    delegate void Print(string msg);
    internal class Program
    {
        static void Main(string[] args)
        {
            //delegateForMath dAdd = new delegateForMath(delegate (int a, int b) { return a + b; })
            //
            delegateForMath dAdd = delegate (int a, int b) { return a + b; };
            Console.WriteLine(dAdd(10, 20));

            Print print =  new Print(delegate(string msg) { Console.WriteLine(msg); });

            print.Invoke("Hello");
        }

      
    }
}