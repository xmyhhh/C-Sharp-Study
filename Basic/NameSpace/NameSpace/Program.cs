namespace MyNest
{
    public class A
    {
        B b;  //accessable !
        class C
        {

        }
        public class D
        {

        }
    }
    class B
    {
        //C c;  //not accessable !
        //A.C c;  //not accessable !
        A.D d;   //accessable !
    }
}

namespace MyNest2
{
    class TestCalss
    {
        MyNest.A a;
        MyNest.B b;
        //MyNest.A.C c; //not accessable !
        MyNest.A.D d;  //accessable !
    }
}