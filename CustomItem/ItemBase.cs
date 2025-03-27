namespace DZCP.CustomItem
{
    public abstract class ItemBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ItemBase(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public abstract void Use();
    }
}