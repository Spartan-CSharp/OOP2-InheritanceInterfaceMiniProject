using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
