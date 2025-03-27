using System;

namespace DZCP.Effects
{
    public static class StatusEffects
    {
        public static void ApplyBleeding(string playerName, float duration)
        {
            Console.WriteLine($"[StatusEffects] {playerName} يعاني من نزيف لمدة {duration} ثواني!");
            // كود لإحداث ضرر تدريجي على اللاعب
        }

        public static void ApplyPoison(string playerName, float duration)
        {
            Console.WriteLine($"[StatusEffects] {playerName} تسمم لمدة {duration} ثواني!");
            // كود لتخفيض صحة اللاعب بشكل تدريجي
        }

        public static void ApplyShock(string playerName, float duration)
        {
            Console.WriteLine($"[StatusEffects] {playerName} أصيب بصعقة كهربائية لمدة {duration} ثواني!");
            // كود لجعل اللاعب غير قادر على التحرك
        }
    }
}