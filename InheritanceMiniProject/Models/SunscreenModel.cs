using System;

using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
	internal class SunscreenModel : InventoryItemModel, IPurchaseable
	{
		internal double BottleSize
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
			Console.WriteLine($"This {BottleSize} bottle of {ItemName} has been purchased for ${PurchasePrice}.");
		}
	}
}
