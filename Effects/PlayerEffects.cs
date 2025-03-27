using System;
using DZCP.Platform;

namespace DZCP.Effects
{
    public static class PlayerEffects
    {
        public static void ApplySpeedBoost(string playerName, float duration)
        {
            Console.WriteLine($"[PlayerEffects] {playerName} حصل على تعزيز سرعة لمدة {duration} ثواني!");
            // كود لتطبيق زيادة السرعة على اللاعب
        }

        public static void ApplyNightVision(string playerName, float duration)
        {
            Console.WriteLine($"[PlayerEffects] {playerName} حصل على رؤية ليلية لمدة {duration} ثواني!");
            // كود لتفعيل الرؤية الليلية
        }
    }
}