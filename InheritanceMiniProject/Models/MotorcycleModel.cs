using System;

namespace InheritanceMiniProject.Models
{
	internal class MotorcycleModel : VehicleModel
	{
		internal string RideType
		{
			get; set;
		}

		internal void PopAWheelie()
		{
			Console.WriteLine("We are popping a wheelie!");
		}
	}
}
