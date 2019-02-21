using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFind
{
    class Program
    {
        // NOTE: The delegate declaration should be outside the method.
        delegate int TempDelegate(int x);
        delegate double TempDelegate1(int x, int y);
        delegate void TempDelegate2();

        static void Main(string[] args)
        {
            List<int> intList = new List<int>();


            // NOTE Lambda expression morphs into the shape of the object it is assigned to
            // NOTE: There is "Func" type taht can be used instead of creating our own delegates
            // NOTE: The last parameter in the "Func" is the return type
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // x => x + 1;                  *implicitly typed, expression body*
            int[] temp = Array.FindAll(ints, x => x >= 7);
            // x => { return x + 1; }       *implicitly typed, statement body*
            int[] temp1 = Array.FindAll(ints, x1 => { return x1 > 7; });
            // (int x) => x + 1;            *explicitly typed, expression*
            int[] temp3 = Array.FindAll(ints, (int x) => x >= 7);
            // (int x) => { return x + 1; } *explicitly typed, statement body*
            TempDelegate myDelegete = (int x) => { return x + 1; };
            // (x, y) => x * y              *multiple parameters*
            TempDelegate1 myDelegate1 = (int x, int y) => { return Math.Sqrt(x * x + y * y); };
            // () => Console.WriteLine()    *no parameters*
            TempDelegate2 myDelegate2 = () => { Console.WriteLine("This is a void delegate with lambda without parameters"); };

            // NOTE: This is how we can replace a lambda expression with an anonymous method (a delegate)
            int[] temp2 = Array.FindAll(ints, delegate (int tempInt) { return tempInt > 7; });
        }
    }
}
