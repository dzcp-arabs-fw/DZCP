using System;
using DZCP.SCPs;

namespace DZCP.Core.Roles
{
    public class SCP173 : SCPBase
    {
        public SCP173() : base("SCP-173", 3200) { }

        public override void PerformAbility()
        {
            Console.WriteLine("[SCP-173] Moves when not being observed and kills instantly.");
            // كود تنفيذ حركة SCP-173
        }
    }
}