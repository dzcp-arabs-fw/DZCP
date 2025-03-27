using System;

namespace DZCP.CustomRole
{
    public class CustomRole
    {
        public string RoleName { get; set; }
        public string Team { get; set; } // Foundation, Chaos, SCP, etc.
        public int Health { get; set; }
        public string SpecialAbility { get; set; }

        public CustomRole(string roleName, string team, int health, string specialAbility)
        {
            RoleName = roleName;
            Team = team;
            Health = health;
            SpecialAbility = specialAbility;
        }

        public void ActivateAbility()
        {
            Console.WriteLine($"[CustomRole] {RoleName} used ability: {SpecialAbility}");
            // تنفيذ القدرة الخاصة بالدور
        }
    }
}