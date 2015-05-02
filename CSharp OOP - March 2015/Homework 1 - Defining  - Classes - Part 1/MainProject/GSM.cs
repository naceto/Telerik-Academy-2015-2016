namespace MainProject
{
	using System;
	using System.Collections.Generic;
	/* 
	    Problem 1.
	    
		Define a class that holds information about a mobile phone device: model, 
		manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) 
		and display characteristics (size and number of colors).
		Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
 	*/
	public class GSM
	{
		// Problem 6. Static field
		// Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
		private static GSM iphone4S = new GSM("Apple", "iPhone4S", 
		                                     999, "BA", new Display(3.5, 16700000), 
		                                     new Battery("HGB", 100, 100, BatteryType.LiIon), null);
		private string model;
		private string manufacturer;
		private decimal price;

		// Problem 2. Constructors
		public GSM(string manufacturer, string model,  decimal price = 0, 
		           string owner = null, Display display = null, Battery battery = null,
		           List<Call> callList = null) : this (manufacturer, model)
		{
			this.Price = price;
			this.Owner = owner;
			this.deviceDisplay = display;
			this.deviceBattery = battery;
			this.CallHistory = callList;
		}

		public GSM (string manufacturer, string model, decimal price) : this (manufacturer, model)
		{
			this.Price = price;
		}

		public GSM (string manufacturer, string model)
		{
			this.Model = model;
			this.Manufacturer = manufacturer;

		}

		public static GSM Iphone4S 
		{
			get { return iphone4S; }
		}

		// Problem 9. Call history
		public List<Call> CallHistory { get; set; }

		// Problem 5. Properties
		public string Owner { get; set; }

		public string Model 
		{ 
			get { return model; }
			set
			{
				if (string.IsNullOrEmpty (value))
				{
					throw new ArgumentException ("Model must not be empty");
				}
				this.model = value;
			}
		}

		public string Manufacturer 
		{ 
			get { return manufacturer; }

			set
			{
				if (string.IsNullOrEmpty (value))
				{
					throw new ArgumentException ("Manufacturer must not be empty");
				}
				manufacturer = value;
			}
		}

		public decimal Price 
		{
			get { return this.price; }

			private set 
			{
				if (value < 0)
				{
					throw new ArgumentException ("The price has to be a positive number.");
				}
				this.price = value;
			}
		}

		public Display deviceDisplay { get; set; }

		public Battery deviceBattery { get; set; }

		// Problem 10. Add/Delete calls
		public void AddCall (Call call)
		{
			if (this.CallHistory == null)
			{
				this.CallHistory = new List<Call> ();
			}
			this.CallHistory.Add(call);
		}

		public void DeleteCall (Call call)
		{
			if (this.CallHistory.Contains (call))
			{
				this.CallHistory.Remove(call);
			}
		}

		public void ClearHistory ()
		{
			if (this.CallHistory != null && this.CallHistory.Count > 0)
			{
				this.CallHistory.Clear();
			}
		}

		// Problem 11. Call price
		public decimal CalculateTotalPrice (decimal pricePerMinute)
		{
			if (this.CallHistory == null)
			{
				return 0;
			}

			decimal totalSum = 0;
			foreach(var call in this.CallHistory)
			{
				decimal remainder = call.Duraion % 60;
				decimal minutes = call.Duraion / 60;
				totalSum += minutes * pricePerMinute + (remainder > 0 ? pricePerMinute : 0);
			}
			return totalSum;
		}

		// Problem 4. ToString
		public override string ToString()
		{
			return string.Format("GSM:\n Manufacturer = {0},\n Model = {1},\n Price = {2},\n Display = {3},\n Battery = {4},\n Owner = {5}", 
			                     Manufacturer, Model, Price, deviceDisplay, deviceBattery, Owner);
		}
	}
}
