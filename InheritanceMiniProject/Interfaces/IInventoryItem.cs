using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject.Interfaces
{
	public interface IInventoryItem
	{
		string ItemName
		{
			get; set;
		}

		int QuantityInStock
		{
			get; set;
		}
	}
}
