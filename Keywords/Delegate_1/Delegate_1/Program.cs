

// Pass a Function as a Parameter in C# as Delegare


using System;

namespace pass_function_as_parameter
{
    class Program
    {
        static int functionToPass(int x)
        {
            return x + 10;
        }
        static void function(Func<int, int> functionToPass)
        {
            int i = functionToPass(22);
            Console.WriteLine("i = {0}", i);
        }
        static void Main(string[] args)
        {
            function(functionToPass);
        }
    }


    //class Program
    //{
    //    static void functionToPass2(int x)
    //    {
    //        int increment = x + 10;
    //        Console.WriteLine("increment = {0}", increment);
    //    }
    //    static void function2(Action<int> functionToPass2)
    //    {
    //        functionToPass2(22);
    //    }
    //    static void Main(string[] args)
    //    {
    //        function2(functionToPass2);
    //    }
    //}


}