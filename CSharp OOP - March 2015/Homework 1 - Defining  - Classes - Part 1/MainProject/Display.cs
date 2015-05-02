namespace MainProject
{
	using System;
	/* 
		display characteristics (size and number of colors).
	*/
	public class Display
	{
		private double displaySize;
		private uint colors;

		// Problem 2. Constructors
		public Display(double size, uint numberColors) : this (size)
		{
			this.Colors = numberColors;
		}

		public Display(double size)
		{
			this.DisplaySize = size;	
		}

		// Problem 5. Properties
		public double DisplaySize 
		{ 
			get { return this.displaySize; }

			set
			{
				if (value < 0)
				{
					throw new ArgumentException ("Display size must be a positive number.");
				}
				this.displaySize = value;
			}
		}

		public uint Colors 
		{ 
			get { return colors; }

			set
			{
				if (value < 0)
				{
					throw new ArgumentException ("Number of colors must be a positive number.");
				}
				this.colors = value;
			}
		}

		// Problem 4. ToString
		public override string ToString()
		{
			return string.Format("[Size = {0}, Colors = {1}]", DisplaySize, Colors);
		}
	}
}

