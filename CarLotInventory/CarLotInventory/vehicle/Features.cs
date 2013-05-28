
namespace CarLotInventory
{
    public class CarFeatures
    {
        public bool CDPlayer { get; set; }
        public bool LeatherSeats { get; set; }
        public bool AlloyRims { get; set; }
        public bool PowerWindows { get; set; }
    }

    public enum Features
    {
        CDPlayer,
        LeatherSeats,
        AlloyRims,
        PowerWindows
    }
}
