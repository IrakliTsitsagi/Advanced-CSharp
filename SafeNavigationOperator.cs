namespace SafeNavigationOperator
{
    internal class SafeNavigationOperator
    {
        static void Main(string[] args)
        {
            Cars bmwM3 = new Cars();
            bmwM3.Brand = "BMW";
            bmwM3.Model = "M3";
            bmwM3.Price = 60_000;

            Cars ferrariEnzo = new Cars();
            ferrariEnzo.Brand = "Ferrari";
            ferrariEnzo.Model = "Enzo";
            ferrariEnzo.Price = 2_500_000;

            Console.WriteLine("Car information");
            Cars.DisplayCarDetails(bmwM3);
            Cars.DisplayCarDetails(ferrariEnzo);

            List<Cars> listOfCars = new List<Cars>();
            //List<Cars> listOfCars = null;
            listOfCars.Add(bmwM3);
            listOfCars.Add(ferrariEnzo);

            int? count = 0;
            count = listOfCars?.Count;
            Console.WriteLine(count);
        }

        class Cars
        {
            private string carBrand;
            private string carModel;
            private decimal carPrice;

            public string Model
            {
                get => carModel;
                set => carModel = value;
            }

            public string Brand
            {
                get => carBrand;
                set => carBrand = value;
            }

            public decimal Price
            {
                get => carPrice;
                set => carPrice = value;
            }

            public static void DisplayCarDetails(Cars car)
            {
                //if (car.Brand != null)
                //    Console.WriteLine(car.Brand);
                //if (car.Model != null)
                //    Console.WriteLine(car.Model);
                //if ( car.Price != null)
                //    Console.WriteLine(car.Price);

                // easyer way same as above 

                Console.WriteLine(car?.Brand);
                Console.WriteLine(car?.Model);
                Console.WriteLine(car?.Price);

                Console.WriteLine();
            }
        }
    }
}