namespace domain.common
{
    public interface IItem : IBaseEntity
    {
        ItemType Type { get; }
    }
}
