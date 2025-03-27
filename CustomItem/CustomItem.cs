using System;

namespace DZCP.CustomItem
{
    public class CustomItem : ItemBase
    {
        public int ItemID { get; set; }
        public bool IsUsable { get; set; }

        public CustomItem(string name, string description, int itemID, bool isUsable) 
            : base(name, description)
        {
            ItemID = itemID;
            IsUsable = isUsable;
        }

        public override void Use()
        {
            if (IsUsable)
            {
                Console.WriteLine($"[CustomItem] {Name} has been used!");
                // تنفيذ التأثيرات عند الاستخدام
            }
            else
            {
                Console.WriteLine($"[CustomItem] {Name} is not usable.");
            }
        }
    }
}