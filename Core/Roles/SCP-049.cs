using System;
using DZCP.SCPs;

namespace DZCP.Core.Roles
{
    public class SCP049 : SCPBase
    {
        public SCP049() : base("SCP-049", 2500) { }

        public override void PerformAbility()
        {
            Console.WriteLine("[SCP-049] Can turn dead players into SCP-049-2 (zombies).");
            // كود تحويل اللاعبين إلى زومبي
        }
    }
}