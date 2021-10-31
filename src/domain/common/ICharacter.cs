using System.Collections.Generic;

namespace domain.common
{
    public interface ICharacter : IBaseEntity
    {
        IEnumerable<IItem> Inventory { get; set; }
    }
}
