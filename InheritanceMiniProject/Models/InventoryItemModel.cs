using System;

using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
	internal class InventoryItemModel : IInventoryItem
	{
		public string ItemName
		{
			get; set;
		}

		public int QuantityInStock
		{
			get; set;
		}

		internal void InspectItem()
		{
			Console.WriteLine("This item has been inspected.");
		}
	}
}
