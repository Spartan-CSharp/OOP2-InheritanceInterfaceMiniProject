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
