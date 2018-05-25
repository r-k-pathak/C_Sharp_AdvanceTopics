using System;

namespace C_Sharp_AdvanceTopics.Section1.Exercise_Solution
{
    class StopWatch
    {
        public TimeSpan Duration
        {
            get
            {
                return IsClockStarted?(DateTime.Now - ClockStartsAt):TimeSpan.Zero;
            }
            
           
        }
        private DateTime ClockStartsAt;
        private Boolean IsClockStarted=false;
        public void StartClock()
        {
           
                if (!IsClockStarted)
                {
                    IsClockStarted = true;
                    ClockStartsAt = DateTime.Now;
                    Console.WriteLine("StopWatch has been started ,you check duration by typing duration then press enter");
                   
                }
                else
                {
                  throw new ArgumentException("Stop Watch Already Started");
                }
           
        }
        public void StopClock()
        {
            if(IsClockStarted)
            { 
            IsClockStarted = false;
                Console.WriteLine("Clock has been stopped");
            }
            else
            {
                Console.WriteLine("you will need to start StopWatch First");
            }
        }
       

    }
}
