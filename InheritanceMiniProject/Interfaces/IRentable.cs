using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject.Interfaces
{
	public interface IRentable : IInventoryItem
	{
		decimal RentalPrice
		{
			get; set;
		}
		void Rent();
		void Return();
	}
}
