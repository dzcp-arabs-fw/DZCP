namespace DZCP.Core.Locations
{
    public class GameLocation
    {
        public string LocationName { get; set; }
        public string Description { get; set; }

        public GameLocation(string locationName, string description)
        {
            LocationName = locationName;
            Description = description;
        }

        public void EnterLocation()
        {
            // كود عند دخول الموقع
        }

        public void ExitLocation()
        {
            // كود عند مغادرة الموقع
        }
    }
}