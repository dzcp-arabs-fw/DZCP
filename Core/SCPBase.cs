using System;

namespace DZCP.SCPs
{
    public abstract class SCPBase
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public SCPBase(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void PerformAbility();
    }
}