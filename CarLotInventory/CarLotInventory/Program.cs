using System;

namespace CarLotInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================WELCOME TO THE CAR LOT=========================");
            CarLot.AddNewCar();

        }

    }

    public class CarLot
    {
        public int NoOfCars { get; set; }
        public int MaxCapacity { get; set; }
        //need a list of cars here. Possibly an array of objects created via the car class?

        public CarLot()
        {

        } //CarLot's Construct

        public static void AddNewCar() //Method for adding a beginning inventory of cars
        {
            int featureNum = 0;
            int colorNum = 0;
            int colorMax = 5;
            Car NewCar1 = new Car();
            Car NewCar2 = new Car(); //adding cars manually. Will need to figure out how to dynamically add.
            Car NewCar3 = new Car(); //Once able to do that, find a way to make each feature random. 
            Car NewCar4 = new Car();
            Car NewCar5 = new Car();
            Car[] Lot = new Car[5] { NewCar1, NewCar2, NewCar3, NewCar4, NewCar5 }; //adding 5 objects to the object array.

            CarLot.LotStat(Lot.Length);

            for (int NewCarNum = 0; NewCarNum < Lot.Length; NewCarNum++) //this assigns attributes to the objects
            {
                Console.WriteLine("Object: " + (NewCarNum + 1));
                while (colorNum < colorMax) //in this case Im just working with color
                {
                    Console.WriteLine(" Color: " + Lot[NewCarNum].Color(colorNum));
                    Console.WriteLine(" Make:  " + Lot[NewCarNum].Make(featureNum)); //while keeping make, model and door type the same.
                    Console.WriteLine(" Model: " + Lot[NewCarNum].Model(featureNum));//next step is to make them all change. 
                    Console.WriteLine(" Doors: " + Lot[NewCarNum].Doors(0)); //then to randomize that action.
                    Console.WriteLine();
                    break;
                }
                colorNum++;

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

    public class Car
    {
        public int Year { get; set; }
        public string Condition { get; private set; }
        public int MarketValue { get; private set; }
        public int PurchasePrice { get; set; }
        private string CarID { get; set; }

        public string Color(int i)
        {
            string[] Color = new string[5] { "Black", "Silver", "Red", "Blue", "Green" };
            return Color[i];
        }

        public string Make(int i)
        {
            string[] Make = new string[5] { "Dodge", "Ford", "Nissan", "VolksWagen", "Toyota" };
            return Make[i];
        }

        public string Model(int i)
        {
            string[] Model = new string[5] { "Viper", "Focus", "350Z", "Jetta", "Echo" };
            return Model[i];
        }

        public string Doors(int i)
        {
            string[] Doors = new string[2] { "Two-Door", "Four-Door" };
            return Doors[i];
        }


        class CarFeatures
        {
            public bool CDPlayer { get; set; }
            public bool LeatherSeats { get; set; }
            public bool AlloyRims { get; set; }
            public bool PowerWindows { get; set; }
        }

        public Car()
        {

        }


    }

    class Bank
    {
        public Int64 BankBalance { get; private set; }
        //need to keep a list of transactions here. Who, When, How Much. Database would be much easier here.

    }
}
