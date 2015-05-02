namespace Problem_07.Timer
{
    using System;
    class MainMethod
    {
        static void Main()
        {
            Action<uint, int> newAction = (count, seconds) =>
            {
                Console.WriteLine("{0} loops passed for the last {1} seconds.", count, seconds);
            };
            int timerTime = 3;

            Timer t = new Timer(newAction, timerTime);
            uint counter = 0;
            while (true)
            {
                t.Run(counter++, timerTime);
            }
        }
    }
}
