using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
