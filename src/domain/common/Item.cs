namespace domain.common
{
	public abstract class Item : BaseEntity
	{
		public ItemType Type { get; set; }

		public Item(string name, string description) 
			=> (Name, Description) = (name, description);
		
		public Item() {}

		public void Use() {}
	}
}
