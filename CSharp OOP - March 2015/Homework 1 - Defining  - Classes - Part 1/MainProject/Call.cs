namespace MainProject
{
	using System;
	/* 
		 Problem 8. Calls
		 Create a class Call to hold a call performed through a GSM.
		 It should contain date, time, dialled phone number and duration (in seconds).
	 */
	public class Call
	{
		private string phoneNumber;
		private string dialedNumber;

		// Problem 2. Constructors
		public Call(string number, uint duration, DateTime callDate, DateTime callTime) : this (number, duration)
		{
			this.Date = callDate;
			this.Time = callTime;
		}

		public Call(string number, uint duration)
		{
			this.PhoneNumber = number;
			this.Duraion = duration;
		}

		// Problem 5. Properties
		public DateTime Date { get; set; } 

		public DateTime Time { get; set; }

		// in seconds
		public uint Duraion { get; set; }

		public string PhoneNumber 
		{
			get { return phoneNumber; }

			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException ("Value cannot be null or empty.");
				}
				phoneNumber = value;
			}
		}

		public string DialedNumber 
		{
			get { return dialedNumber; }

			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException ("Value cannot be null or empty.");
				}
				dialedNumber = value;
			}
		}

		// Problem 4. ToString
		public override string ToString ()
		{
			DateTime start = default(DateTime);
			string date = this.Date == start ? "Not Set" : this.Date.ToShortTimeString();
			string time = this.Time == start ? "Not Set" : this.Time.ToShortTimeString();
			return string.Format("Call:\n Phone Number = {0},\n Duration = {1},\n Date = {2},\n Time = {3}",
			                     this.PhoneNumber, this.Duraion, date, time);
		}
	}
}
