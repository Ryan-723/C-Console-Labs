namespace __8829850_Assignment2;
class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        // Hardcoding 3 Appointments
        service p1 = new service();
        p1.clientName = "";
        p1.clientNumber = "1234567895";
        p1.clientPhoneNumber = 9632587415;
        p1.clientType = "Home";

        service p2 = new service();
        p2.clientName = "Aman";
        p2.clientNumber = "1234555895";
        p2.clientPhoneNumber = 9632555415;
        p2.clientType = "Office";

        service p3 = new service();
        p3.clientName = "Avi";
        p3.clientNumber = "1234111895";
        p3.clientPhoneNumber = 9632111415;
        p3.clientType = "Industrial";

        // Creating Different Services
        service s1 = new service();
        s1.serviceName = "Light Cleaning";
        s1.servicePrice = 299.99;

        service s2 = new service();
        s2.serviceName = "Medium Cleaning";
        s2.servicePrice = 329.99;

        service s3 = new service();
        s3.serviceName = "Deep Cleaning";
        s3.servicePrice = 439.99;

        service s4 = new service();
        s4.serviceName = "Carpet Drying";
        s4.servicePrice = 49.01;

        service s5 = new service();
        s5.serviceName = "Carpet Repair";
        s5.servicePrice = 69.02;

        service s6 = new service();
        s6.serviceName = "Carpet Replacement";
        s6.servicePrice = 79.03;

        // Creating reservation list and adding hardcoded appointments
        List<object> reservation = new List<object>();

        reservation.Add(p1);
        reservation.Add(p2);
        reservation.Add(p3);

        // Creating service list and adding services
        List<service> service = new List<service>();

        service.Add(s1);
        service.Add(s2);
        service.Add(s3);
        service.Add(s4);
        service.Add(s5);
        service.Add(s6);


        // Creating a tuple to store both appointments and the services to each appointments
        var tupleList = new List<(object, object, List<service>)>
        {
            (p1, s1, new List<service> {}),
            (p2, s2, new List<service> {}),
            (p3, s3, new List<service> {})
        };

        int input = 0;

        do
        {
            menuDisplay();
            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                // Adding new client Info
                service newReservation = new service();
                Console.Write("Enter client name: ");
                newReservation.clientName = Console.ReadLine();


                // Requesting Client Number and checking if its valid or not
                Console.Write("Enter client number: ");
                int clientNumberChecker = int.Parse(Console.ReadLine());
                if(clientNumberChecker.ToString().Length == 10){
                    newReservation.clientNumber = clientNumberChecker.ToString();
                }
                else{
                    Console.WriteLine("Wrong Input");
                    break;
                }
               
                Console.Write("Enter client phone number: ");
                newReservation.clientPhoneNumber = long.Parse(Console.ReadLine());


                Console.Write("Pick a client type by entering the option number: \n 1. Home,\n 2. Office,\n 3. Industrial: ");
                int clientTypeInput = int.Parse(Console.ReadLine());
                if (clientTypeInput == 1)
                {
                    newReservation.clientType = "Home";
                }
                if (clientTypeInput == 2)
                {
                    newReservation.clientType = "Office";
                }
                if (clientTypeInput == 3)
                {
                    newReservation.clientType = "Industrial";
                }


                // Creating a list for services added for the new appointments
                List<service> addedServices = new List<service>();

                bool addMoreServices = true;
                while (addMoreServices)
                {
                    int newServiceInput = 0;
                    service newService = new service();

                    if (newReservation.clientType == "Home")
                    {
                        // Services for Home Clients
                        Console.Write("Pick service number: \n 1. Light Cleaning \n 2. Medium Cleaning \n 3. Deep Cleaning \n 4. Carpet Drying: ");
                        newServiceInput = int.Parse(Console.ReadLine());

                        if (newServiceInput == 1)
                        {
                            newService.serviceName = s1.serviceName;
                            newService.servicePrice = s1.servicePrice;
                        }
                        if (newServiceInput == 2)
                        {
                            newService.serviceName = s2.serviceName;
                            newService.servicePrice = s2.servicePrice;
                        }
                        if (newServiceInput == 3)
                        {
                            newService.serviceName = s3.serviceName;
                            newService.servicePrice = s3.servicePrice;
                        }
                        if (newServiceInput == 4)
                        {
                            newService.serviceName = s4.serviceName;
                            newService.servicePrice = s4.servicePrice;
                        }
                    }
                    
                    // Services for Office Clients
                    if (newReservation.clientType == "Office")
                    {
                        Console.Write("Pick service number: \n 1. Light Cleaning \n 2. Medium Cleaning \n 3. Deep Cleaning \n 4. Carpet Repair: ");
                        newServiceInput = int.Parse(Console.ReadLine());

                        if (newServiceInput == 1)
                        {
                            newService.serviceName = s1.serviceName;
                            newService.servicePrice = s1.servicePrice;
                        }
                        if (newServiceInput == 2)
                        {
                            newService.serviceName = s2.serviceName;
                            newService.servicePrice = s2.servicePrice;
                        }
                        if (newServiceInput == 3)
                        {
                            newService.serviceName = s3.serviceName;
                            newService.servicePrice = s3.servicePrice;
                        }
                        if (newServiceInput == 4)
                        {
                            newService.serviceName = s5.serviceName;
                            newService.servicePrice = s5.servicePrice;
                        }
                    }
                    
                    // Services for Industrial Clients
                    if (newReservation.clientType == "Industrial")
                    {
                        Console.Write("Pick service number: \n 1. Light Cleaning \n 2. Medium Cleaning \n 3. Deep Cleaning \n 4. Carpet Replacement: ");
                        newServiceInput = int.Parse(Console.ReadLine());

                        if (newServiceInput == 1)
                        {
                            newService.serviceName = s1.serviceName;
                            newService.servicePrice = s1.servicePrice;
                        }
                        if (newServiceInput == 2)
                        {
                            newService.serviceName = s2.serviceName;
                            newService.servicePrice = s2.servicePrice;
                        }
                        if (newServiceInput == 3)
                        {
                            newService.serviceName = s3.serviceName;
                            newService.servicePrice = s3.servicePrice;
                        }
                        if (newServiceInput == 4)
                        {
                            newService.serviceName = s6.serviceName;
                            newService.servicePrice = s6.servicePrice;
                        }
                    }

                    Console.WriteLine("Add another service? (y/n): ");
                    string x = Console.ReadLine();
                    if (x == "y")
                    {
                        addMoreServices = true;
                    }
                    else
                    {
                        addMoreServices = false;
                    }


                    addedServices.Add(newService);

                }

                // Saving new clients appointments and the services for each appointment to the tuple 
                tupleList.Add((newReservation, " ", addedServices));

            }

            // Printing the Appointment Info
            if (input == 2)
            {
                foreach (var obj in tupleList)
                {
                    double totalPrice = 0;
                    Console.WriteLine($"{obj.Item1}, \n{obj.Item2}");
                    foreach (var serviceList in obj.Item3)
                    {
                        Console.WriteLine($"{serviceList.serviceName} - {serviceList.servicePrice}");
                        
                        totalPrice += serviceList.servicePrice;
                    }
                    Console.WriteLine($"Total Price: {totalPrice} \n");
                }

                
                Console.WriteLine("\n The First 3 Appointments made by the owner are paid for \n");
            }

            // Clearing reservation list
            if (input == 3)
            {
                reservation.Clear();
                tupleList.Clear();

            }
        } while (input != 4);
        

        // function to print menu 
        void menuDisplay()
        {
            Console.WriteLine("1. Create a reservation");
            Console.WriteLine("2. List all Reservations");
            Console.WriteLine("3. Clear All Reservations");
            Console.WriteLine("4. Exit the program");
        }
    }
}
