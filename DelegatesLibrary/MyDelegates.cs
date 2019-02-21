using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLibrary
{
    public class MyDelegates
    {
        public MyDelegates()
        {
            //NOTE: this is an action and must be done inside something that is callable
            integerActions = PrintInt;
            stringActions = ReturnLine;
        }

        delegate void IntAction(int integer);
        delegate string StringAction();

        IntAction integerActions;
        StringAction stringActions;
        
        public void PrintInt(int number)
        {
            Console.WriteLine(number);
        }

        public string ReturnLine()
        {
            return "test message";
        }
    }
}
