using System;
using System.Collections.Generic;

namespace DZCP.Core
{
    public static class EventSystem
    {
        private static Dictionary<string, List<Action<object[]>>> eventHandlers = new Dictionary<string, List<Action<object[]>>>();

        public static void RegisterEvent(string eventName, Action<object[]> callback)
        {
            if (!eventHandlers.ContainsKey(eventName))
                eventHandlers[eventName] = new List<Action<object[]>>();

            eventHandlers[eventName].Add(callback);
        }

        public static void TriggerEvent(string eventName, params object[] args)
        {
            if (eventHandlers.ContainsKey(eventName))
            {
                foreach (var callback in eventHandlers[eventName])
                    callback.Invoke(args);
            }
        }
    }
}