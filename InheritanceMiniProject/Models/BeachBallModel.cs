using System;

using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
	internal class BeachBallModel : InventoryItemModel, IPurchaseable
	{
		internal int BallSize
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
			Console.WriteLine($"This {BallSize} {ItemName} has been purchased for ${PurchasePrice}.");
		}
	}
}
