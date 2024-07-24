namespace __8829850_Lab3;
class Program
{
    static void Main(string[] args)
    {
        
        // Creating instance from luggage class
        luggage userData = new luggage();

        // Creating List to store data
        List<string> info = new List<string>();
        info.Add(" " + ", " + "(123) 456-7895, " + 2 + " bags, " + 33 + " average Weight");

        bool inputLoop= true;
        bool okPhone = false;

        while(inputLoop){
            Console.WriteLine("Select a option!!! \n 1) Add a new Passenger \n 2) Display Passenger list \n 3) Exit");
            string menuInput = Console.ReadLine();

            // Prompting the user for data inputs 
            if(menuInput == "1"){

                
                Console.WriteLine("Enter your First Name: ");
                userData.firstName = Console.ReadLine();

                Console.WriteLine("Enter your Last Name: ");
                userData.lastName = Console.ReadLine();
                
                while(okPhone != true){
                    
                    Console.WriteLine("Enter your Phone Number in the format of (XXX) XXX-XXXX : ");
                    userData.phoneNumber = Console.ReadLine();
                    validatePhone();
                    
                }

                okPhone = false;

                Console.WriteLine("Enter the Quantity of bags youll be carrying: ");
                userData.bagsQuantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the total Weights of Bags");
                userData.totalWeight = double.Parse(Console.ReadLine());

                // Storing data in list
                info.Add(userData.firstName + " " + userData.lastName + ", " + userData.phoneNumber + ", " + $"{userData.bagsQuantity} bags, " + " " + $"{userData.averageWeight()} average weight");

            }

            // Outputting Data
            if(menuInput == "2"){
                foreach(string index in info){
                    Console.WriteLine(index);
                }
            }

            // Exiting Program
            if(menuInput == "3"){
                inputLoop = false;
            }


            // Function to Validate Phone Number
            void validatePhone(){
                string phNo = userData.phoneNumber;
                if (phNo.Length == 14 &&
                    phNo[0] == '(' &&
                    Char.IsDigit(phNo[1]) &&
                    Char.IsDigit(phNo[2]) &&
                    Char.IsDigit(phNo[3]) &&
                    phNo[4] == ')' &&
                    phNo[5] == ' ' &&
                    Char.IsDigit(phNo[6]) &&
                    Char.IsDigit(phNo[7]) &&
                    Char.IsDigit(phNo[8]) &&
                    phNo[9] == '-' &&
                    Char.IsDigit(phNo[10]) &&
                    Char.IsDigit(phNo[11]) &&
                    Char.IsDigit(phNo[12]) &&
                    Char.IsDigit(phNo[13]))
                {
                    okPhone = true;
                    
                }
                else
                {
                    okPhone = false;
                    Console.WriteLine("Invalid Phone Number Format");
                }
            }
            

        }
    }
}
