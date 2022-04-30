using System;
namespace SimpleEvent
{
    using System;
    /***********发布器类***********/
    public class EventTest
    {
        private int value;

        public delegate void NumManipulationHandler();
        public delegate void DoorManipulationHandler(int a);

        public event NumManipulationHandler ChangeNumEvent;  //NumManipulationHandler是事件的委托类型

        public event DoorManipulationHandler OpenDoorEvent;

        public EventTest()
        {
            int n = 5;
            SetValue(n);
        }


        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                ChangeNumEvent?.Invoke(); /* 事件被触发 */
            }
        }

        public void openDoor(int doorID)
        {
            OpenDoorEvent?.Invoke(doorID);
        }
    }


    /***********订阅器类***********/

    public class subscribEvent
    {
        public void printf()
        {
            Console.WriteLine("event fire");
            //Console.ReadKey(); /* 回车继续 */
        }

        public void openDoor(int doorID)
        {
            Console.WriteLine($"door opened {doorID}");
        }
    }

    /***********触发***********/
    public class MainClass
    {
        public static void Main()
        {
            EventTest e = new EventTest(); /* 实例化对象,第一次没有触发事件 */
            subscribEvent v = new subscribEvent(); /* 实例化对象 */
            e.ChangeNumEvent += new EventTest.NumManipulationHandler(v.printf); /* 注册 */
            e.OpenDoorEvent += new EventTest.DoorManipulationHandler(v.openDoor);
            e.SetValue(7);
            e.SetValue(11);
            e.openDoor(7);
            e.openDoor(8);
        }
    }
}