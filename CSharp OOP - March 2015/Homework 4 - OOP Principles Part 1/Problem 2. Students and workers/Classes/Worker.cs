namespace Problem_2.Students_and_workers.Classes
{
    using System;

    // Define class Worker derived from Human with a new property 
    // WeekSalary and WorkHoursPerDay and a method MoneyPerHour() 
    // that returns money earned per hour by the worker. 
    public class Worker : Human
    {
        private decimal weekSalary;

        private int workHoursPerDay;

        public Worker (string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value >= 0 && value <= 24)
                {
                    workHoursPerDay = value;
                }
                else
                {
                    throw new ArgumentException("Work hours per day cannot be negative or more than 24.");
                }
            }
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            private set
            {
                if (value >= 0)
                {
                    weekSalary = value;
                }
                else
                {
                    throw new ArgumentException("Week salary cannot be negative.");
                }
            }
        }

        public decimal MonerPerHour ()
        {
            decimal hourSalay = (WeekSalary / 5) / 24;
            return this.WorkHoursPerDay * hourSalay;
        }
    }
}
