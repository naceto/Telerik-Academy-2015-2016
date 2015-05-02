namespace Problem_07.Timer
{
    using System;
    /*
        Problem 7. Timer
        Using delegates write a class Timer that can execute certain method at each t seconds.
     */
    class Timer
    {
        private DateTime lastTimeStamp;
        private Action<uint, int> Execute;
        private int afterSeconds;
        private uint lastCount;
        
        public Timer (Action<uint, int> act, int seconds)
        {
            lastTimeStamp = DateTime.Now;
            this.Execute = act;
            this.afterSeconds = seconds;
            this.lastCount = 0;
        }

        public void Run (uint count, int timerTime)
        {
            DateTime now = DateTime.Now;

            if ((now - this.lastTimeStamp).Seconds >= this.afterSeconds)
            {
                uint newCount = count - this.lastCount;
                this.Execute(newCount, timerTime);
                this.lastTimeStamp = now;
                this.lastCount = count;
            }
        }
    }
}
