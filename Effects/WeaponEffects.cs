using System;

namespace DZCP.Effects
{
    public static class WeaponEffects
    {
        public static void ApplyRecoil(string weaponName, float intensity)
        {
            Console.WriteLine($"[WeaponEffects] السلاح {weaponName} حصل على ارتداد بقوة {intensity}!");
            // كود لتطبيق تأثير الارتداد
        }

        public static void ApplyMuzzleFlash(string weaponName)
        {
            Console.WriteLine($"[WeaponEffects] السلاح {weaponName} أطلق وظهر فلاش كموميض للرصاصة!");
            // كود لتفعيل وميض الفلاش عند إطلاق النار
        }

        public static void PlayGunSound(string weaponName)
        {
            Console.WriteLine($"[WeaponEffects] تشغيل صوت إطلاق نار للسلاح {weaponName}!");
            // كود لتشغيل صوت السلاح
        }
    }
}