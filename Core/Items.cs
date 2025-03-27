namespace DZCP.Gameplay
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Use()
        {
            // كود لاستخدام الأداة
        }
    }
}