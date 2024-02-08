using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
	internal class BookModel : InventoryItemModel, IPurchaseable
	{
		internal int NumberOfPages
		{
			get; set;
		}

		internal string Author
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
			Console.WriteLine($"This {ItemName} by {Author} ({NumberOfPages} pages) has been purchased for ${PurchasePrice}.");
		}
	}
}
