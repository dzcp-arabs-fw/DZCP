using System;
using System.Collections.Generic;

namespace DZCP.Effects
{
    public static class EffectManager
    {
        private static Dictionary<string, Action<object>> effectRegistry = new Dictionary<string, Action<object>>();

        public static void RegisterEffect(string effectName, Action<object> effectAction)
        {
            effectRegistry[effectName] = effectAction;
        }

        public static void ApplyEffect(string effectName, object target)
        {
            if (effectRegistry.ContainsKey(effectName))
            {
                effectRegistry[effectName](target);
                Console.WriteLine($"[EffectManager] تم تطبيق التأثير: {effectName} على {target}");
            }
            else
            {
                Console.WriteLine($"[EffectManager] التأثير {effectName} غير موجود!");
            }
        }
    }
}