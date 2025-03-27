namespace DZCP.Gameplay
{
    public enum Team
    {
        Foundation,
        ChaosInsurgency,
        ClassD,
        SCP
    }

    public class Role
    {
        public string RoleName { get; set; }
        public Team RoleTeam { get; set; }

        public Role(string roleName, Team roleTeam)
        {
            RoleName = roleName;
            RoleTeam = roleTeam;
        }

        public virtual void PerformRoleAction()
        {
            // كود لتنفيذ وظيفة الدور
        }
    }
}