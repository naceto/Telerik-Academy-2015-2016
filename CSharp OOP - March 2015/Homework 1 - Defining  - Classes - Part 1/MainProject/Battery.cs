namespace MainProject
{
	using System;
	/* 
		battery characteristics (model, hours idle and hours talk) 
 	*/
	public class Battery
	{
		// Problem 5. Properties
		private string model;

		//Problem 2. Constructors
		public Battery(string model, 
		               uint initialHoursTalk, 
		               uint initialHoursIdle, 
		               BatteryType battType = 0) : this (model)
		{
			this.HoursTalk = initialHoursTalk;
			this.HoursIdle = initialHoursIdle;
			BatteryType = battType;
		}

		public Battery(string model)
		{
			this.Model = model;	
		}

		public string Model 
		{  
			get { return model; }

			set 
			{
				if (string.IsNullOrEmpty (value))
				{
					throw new ArgumentException("Value must not be null or empty.");
				}
				model = value;
			}
		}

		private uint HoursIdle { get; set; }

		private uint HoursTalk { get; set; }

		public BatteryType BatteryType { get; set; }

		// Problem 4. ToString
		public override string ToString()
		{
			return string.Format("[Model = {0}, Battery Type = {1}]", Model, BatteryType);
		}
	}
}

