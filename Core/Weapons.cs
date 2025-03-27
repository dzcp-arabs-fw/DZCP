namespace DZCP.Gameplay
{
    public enum AmmoType
    {
        Light,
        Medium,
        Heavy
    }

    public class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public float FireRate { get; set; } // بالثواني بين كل طلقة
        public int MagazineCapacity { get; set; }
        public AmmoType Ammo { get; set; }

        public Weapon(string name, int damage, float fireRate, int magazineCapacity, AmmoType ammo)
        {
            Name = name;
            Damage = damage;
            FireRate = fireRate;
            MagazineCapacity = magazineCapacity;
            Ammo = ammo;
        }

        public void Fire()
        {
            // كود لإطلاق النار
        }

        public void Reload()
        {
            // كود لإعادة التلقيم
        }
    }
}