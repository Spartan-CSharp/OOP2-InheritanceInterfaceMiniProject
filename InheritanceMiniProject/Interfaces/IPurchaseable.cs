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
