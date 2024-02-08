using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
	internal class ExcavatorModel : InventoryItemModel, IRentable
	{
		internal string VehicleIdentificationNumber
		{
			get; set;
		}

		public decimal RentalPrice
		{
			get; set;
		}

		public void Rent()
		{
			QuantityInStock--;
			Console.WriteLine($"This {ItemName} (VIN: {VehicleIdentificationNumber}) has been rented for ${RentalPrice}.");
		}

		public void Return()
		{
			QuantityInStock++;
			Console.WriteLine($"This {ItemName} (VIN: {VehicleIdentificationNumber}) has been returned.");
		}
	}
}
