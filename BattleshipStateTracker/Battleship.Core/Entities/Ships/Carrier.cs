using BattleshipStateTracker.Core.Enums;

namespace BattleshipStateTracker.Core.Entities.Ships
{
    public class Carrier : Ship
    {
        public Carrier()
        {
            Name = "Aircraft Carrier";
            Width = 5;
            OccupationType = OccupationType.Carrier;
        }
    }
}
