namespace DZCP.Gameplay
{
    public class Scientist : Role
    {
        public Scientist() : base("Scientist", Team.Foundation)
        {
        }

        public override void PerformRoleAction()
        {
            base.PerformRoleAction();
            // كود خاص بدور العالم
        }
    }
}