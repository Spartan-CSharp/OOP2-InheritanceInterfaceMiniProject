using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
