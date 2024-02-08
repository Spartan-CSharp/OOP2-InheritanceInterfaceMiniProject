using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject.Interfaces
{
	public interface IPurchaseable : IInventoryItem
	{
		decimal PurchasePrice
		{
			get; set;
		}
		void Puchase();
	}
}
