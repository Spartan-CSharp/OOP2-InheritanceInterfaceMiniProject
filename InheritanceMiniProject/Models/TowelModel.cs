using System;

using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
	internal class TowelModel : InventoryItemModel, IRentable, IPurchaseable
	{
		internal int TowelLength
		{
			get; set;
		}
		internal int TowelWidth
		{
			get; set;
		}
		public decimal RentalPrice
		{
			get; set;
		}

		public decimal PurchasePrice
		{
			get; set;
		}

		public void Puchase()
		{
			QuantityInStock--;
			Console.WriteLine($"This {TowelWidth} × {TowelLength} {ItemName} has been purchased for ${PurchasePrice}.");
		}

		public void Rent()
		{
			QuantityInStock--;
			Console.WriteLine($"This {TowelWidth} × {TowelLength} {ItemName} has been rented for ${RentalPrice}.");
		}

		public void Return()
		{
			QuantityInStock++;
			Console.WriteLine($"This {TowelWidth} × {TowelLength} {ItemName} has been returned.");
		}
	}
}
