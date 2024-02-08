using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
	internal class VehicleModel : InventoryItemModel, IPurchaseable, IRentable
	{
		internal string VehicleIdentificationNumber
		{
			get; set;
		}

		public decimal PurchasePrice
		{
			get; set;
		}

		public decimal RentalPrice
		{
			get; set;
		}

		public void Puchase()
		{
			QuantityInStock--;
			Console.WriteLine($"This {ItemName} (VIN: {VehicleIdentificationNumber}) has been purchased for ${PurchasePrice}.");
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
