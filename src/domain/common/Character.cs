using System.Collections.Generic;

namespace domain.common
{
	public abstract class Character : BaseEntity
	{
		public Attributes Attributes { get; set; }
		public Dictionary<int, Item> Inventory { get; set; }
	}
}
