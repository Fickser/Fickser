
namespace CarLotInventory.VehicleType.Makes.toyota.CarModels
{
    class Prius : Vehicle
    {
        public Prius()
        {
            this.Make = "Toyota";
            this.Model = "Prius";
            YearCheck();
        }

        void YearCheck()
        {
            this.Year = 2056;
        }
    }
}
