using System;
using DZCP.SCPs;

namespace DZCP.Core.Roles
{
    public class SCP096 : SCPBase
    {
        public SCP096() : base("SCP-096", 2000) { }

        public override void PerformAbility()
        {
            Console.WriteLine("[SCP-096] Attacks anyone who looks at his face.");
            // كود تنفيذ غضب SCP-096
        }
    }
}