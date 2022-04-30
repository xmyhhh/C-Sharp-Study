using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type_Constraint
{
    //类的访问修饰符只有两种：public、internal。如果class前面没有加任何修饰符的话，默认是internal。
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            MyGenericClass<MyClass> myGenericClass = new MyGenericClass<MyClass>(myClass);
        }
    }
    interface IMyInterface
    {
        void Fuc1();
        void Fuc2();
    }


    class MyClass : IMyInterface
    {
        public void Fuc1()
        {
            Console.WriteLine(" MyClass func1");
        }

        public void Fuc2()
        {
            Console.WriteLine(" MyClass func2");
        }
    }
    class MyGenericClass<T> where T : IMyInterface
    {

        public MyGenericClass(T t)
        {
            t.Fuc1();
        }

    }

}
