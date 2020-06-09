using System;
using Structure;


namespace TimeClass
{

    public class Times
    {
        //enum – время суток
        public enum Time
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        public static Time nowTime = Time.Morning;

        public static void ChangeTime(int time)
        {
            switch (time)
            {
                case 0:
                    nowTime = Time.Morning;
                    break;
                case 1:
                    nowTime = Time.Afternoon;
                    break;
                case 2:
                    nowTime = Time.Evening;
                    break;
                case 3:
                    nowTime = Time.Night;
                    break;
                default: throw new IndexOutOfRangeException("Incorrect value");
            }
        }

        public static void DisplayTime()
        {
            Console.WriteLine($"Look.. This is {nowTime}");
        }
        public static void DisplayTime(Action<string> action)
        {
            action($"Look.. This is {nowTime}");
        }

    }


}