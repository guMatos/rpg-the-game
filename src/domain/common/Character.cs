using System.Collections.Generic;

namespace domain.common
{
    public abstract class Character : IBaseEntity
    {
        public Character() { }

        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<IItem> Inventory { get; set; }
    }
}
