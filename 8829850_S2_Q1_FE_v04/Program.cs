// 
// Student ID: 8829850
// Section 2 
// 18-08-2023
namespace _8829850_S2_Q1_FE_v04;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Clear();

            int input = 0;
            try
            {
                do
                {
                    menuDisplay();
                    Console.WriteLine("Pick a option");
                    input = int.Parse(Console.ReadLine());

                    Car newCar = new Car();
                    Boat newBoat = new Boat();
                    
                    if (input == 1)
                    {
                        Console.Write("Enter Car name: ");
                        string LandVehicleName = Console.ReadLine();

                        Console.Write("Enter Fuel efficiency: ");
                        double LandVehicleFuelEfficiency = double.Parse(Console.ReadLine());

                        newCar.vehicleName = LandVehicleName;
                        newCar.fuelEfficiency = LandVehicleFuelEfficiency;

                    }

                    
                    if (input == 2)
                    {
                        Console.Write("Enter Boat name: ");
                        string WaterVehicleName = Console.ReadLine();

                        Console.Write("Enter Max Speed: ");
                        double WaterVehicleMaxSPeed = double.Parse(Console.ReadLine());

                        newBoat.vehicleName = WaterVehicleName;
                        newBoat.maxSpeed = WaterVehicleMaxSPeed;
                    }

                    
                    if (input == 3)
                    {
                        Console.WriteLine("\nList of Cars and Boats: ");

                        Console.WriteLine(newBoat.ToString());
                        Console.WriteLine(newCar.ToString());
                        
                        // Console.WriteLine(newBoat.vehicleName);
                        // Console.WriteLine(newBoat.maxSpeed);
                        // Console.WriteLine(newCar.vehicleName);
                        // Console.WriteLine(newCar.fuelEfficiency);
                    }

                } while (input != 4);
            }
            catch (Exception e) { }


            // function to print menu 
            void menuDisplay()
            {

                Console.WriteLine("1. Add a new Car");
                Console.WriteLine("2. Add a new Boat");
                Console.WriteLine("3. View Cars and Boats");
                Console.WriteLine("4. Exit the program");

            }
        }
        catch (Exception e)
        {

        }
    }
}