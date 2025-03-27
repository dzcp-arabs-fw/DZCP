using System;
using System.Collections.Generic;

namespace DZCP.Core
{
    public static class Permissions
    {
        private static Dictionary<string, List<string>> userPermissions = new Dictionary<string, List<string>>();

        public static void GrantPermission(string user, string permission)
        {
            if (!userPermissions.ContainsKey(user))
                userPermissions[user] = new List<string>();

            userPermissions[user].Add(permission);
        }

        public static bool HasPermission(string user, string permission)
        {
            return userPermissions.ContainsKey(user) && userPermissions[user].Contains(permission);
        }
    }
}