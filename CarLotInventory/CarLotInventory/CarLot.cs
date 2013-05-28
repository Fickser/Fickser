using System;

namespace CarLotInventory
{
    class CarLot
    {
        public int NoOfCars { get; set; }
        public int MaxCapacity { get; set; }
        // public List<Car> CarList;

        //need a list of cars here. Possibly an array of objects created via the car class?

        public CarLot()
        {

        } //CarLot's Construct

        static void addNewCar()
        {
            int iterations = 5;
            // Car[] Lot = new Car[iterations];

            for (int i = 0; i < iterations; i++)
            {
                //Car newCar = new Car();
                // newCar = Lot[i];
            }


        }

        public static void LotStat(int current) //checks status of number of cars. Need something that does this without adding text. 
        {                                       //Maybe haing LotStatBrief and LotStatVerbose?
            int max = 20;
            int remainder = max - current;
            //Console.WriteLine("========================================================================");
            Console.WriteLine("No of cars: " + current);
            Console.WriteLine("Max amount of cars on this lot: " + max);


            if (remainder == 0)
            {
                Console.WriteLine("SORRY, NO ROOM FOR MORE CARS.");
            }

            if (remainder <= 5 && remainder != 0)
            {

                Console.WriteLine("**ATTENTION** OPEN SPACES RUNNING LOW. ONLY " + remainder + " SPACES LEFT.");
            }
            else
            {
                Console.WriteLine("Open car slots available: " + remainder);
            }
            Console.WriteLine();
        }
        void BuyCar() //Method for buying cars
        {
        }
        void SellCar() //Moethod for selling cars
        {
        }
        void GetTotalDebt() //Adds up the total purchase price of all cars on the lot
        {
        }
        void GetNetValue() //Subtracts Purchase Price of all cars from Market Value
        {

        }
        void GetGrossValue() //Determines Market Value
        {

        }
    }
}
