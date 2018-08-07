using BattleshipStateTracker.Core.Enums;

namespace BattleshipStateTracker.Core.Entities.Ships
{
    public class Submarine : Ship
    {
        public Submarine()
        {
            Name = "Submarine";
            Width = 3;
            OccupationType = OccupationType.Submarine;
        }
    }
}
