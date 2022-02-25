using System.Collections.Generic;

namespace domain.common
{
    public abstract class Character : BaseEntity
    {
        public IEnumerable<Item> Inventory { get; set; }
    }
}
