using System;
namespace SimpleEvent
{
    using System;
    /***********发布器类***********/
    public class EventTest
    {
        private int value;


        public delegate void DoorManipulationHandler();

        public event DoorManipulationHandler OpenDoorEvent;

        public EventTest()
        {

        }

        public void openDoor()
        {
            OpenDoorEvent?.Invoke();
        }
    }


    /***********订阅器类***********/

    public class subscribEvent
    {
        int value;
        public subscribEvent(int a)
        {
            value = a;
        }
        public void openDoor()
        {
            Console.WriteLine($"door opened{value}");
        }
    }

    /***********触发***********/
    public class MainClass
    {
        public static void Main()
        {
            //EventTest e = new EventTest(); /* 实例化对象,第一次没有触发事件 */
            //subscribEvent v = new subscribEvent(1); /* 实例化对象 */
            //subscribEvent b = new subscribEvent(2); /* 实例化对象 */
            //e.OpenDoorEvent += new EventTest.DoorManipulationHandler(v.openDoor); /* 注册 */

            //var a = new EventTest.DoorManipulationHandler(v.openDoor);
            //a += b.openDoor;
            //a.Invoke();

            testClass testClass = new testClass();
            testClass.a.Invoke();
        }
    }

    public class testClass
    {
        public EventTest.DoorManipulationHandler a;
        public testClass()
        {

            subscribEvent v = new subscribEvent(1); /* 实例化对象 */


            a = new EventTest.DoorManipulationHandler(v.openDoor);

        }
    }
}