    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(", 8829850, 9850@conestogac.on.ca");
            Console.WriteLine("=======================");

            try
            {
                // Prompt user for inputs
                Console.WriteLine("Select the pet item purchased:");
                Console.WriteLine("1. Fish");
                Console.WriteLine("2. Cat Food");
                Console.WriteLine("3. Dog Food");
                Console.WriteLine("4. Rabbit Food");
                Console.WriteLine("Enter the item number: ");
                int itemNumber = int.Parse(Console.ReadLine());

                string itemName;
                double basePrice;

                if (itemNumber == 1)
                {
                    itemName = "Fish";
                    basePrice = 5.00;
                }
                else if (itemNumber == 2)
                {
                    itemName = "Cat Food";
                    basePrice = 10.00;
                }
                else if (itemNumber == 3)
                {
                    itemName = "Dog Food";
                    basePrice = 15.00;
                }
                else if (itemNumber == 4)
                {
                    itemName = "Rabbit Food";
                    basePrice = 7.00;
                }
                else
                {
                    Console.WriteLine("Invalid item number.");
                    return;
                }

                Console.Write("Enter the quantity of the item purchased: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.Write("Press 1 if you have loyalty card and Press 2 for No: ");
                int loyaltyCardInput = int.Parse(Console.ReadLine());
                bool hasLoyaltyCard;
                if(loyaltyCardInput == 1){
                    hasLoyaltyCard = true;
                }
                else if(loyaltyCardInput == 2){
                    hasLoyaltyCard = false;
                }
                else{
                    hasLoyaltyCard = false;
                    Console.WriteLine("No loyalty card set as input is invalid ");
                }
                // Calculate discounts
                double individualDiscount = 0.0;
                if (itemName == "Fish" && quantity >= 3)
                {
                    individualDiscount = basePrice * 0.10 * quantity;
                }
                else if (itemName == "Cat Food" && quantity >= 5)
                {
                    int freeBags = 1;
                    individualDiscount = basePrice * freeBags;
                }
                else if (itemName == "Dog Food" && quantity >= 3)
                {
                    individualDiscount = basePrice * 0.50;
                }

                double totalDiscount = individualDiscount;
                if (itemName == "Rabit Food" && quantity >= 2)
                {
                    double itemDiscount = basePrice * 0.05 * quantity;
                    totalDiscount += itemDiscount;
                }

                // Calculate subtotal
                double subtotal = (basePrice * quantity) - totalDiscount;

                // Calculate loyalty discount
                double loyaltyDiscount;
                string loyaltyPrint;
                if (hasLoyaltyCard)
                {
                    loyaltyPrint = "yes";
                    loyaltyDiscount = subtotal * 0.05;
                }
                else
                {
                    loyaltyPrint = "No";
                    loyaltyDiscount = 0.0;
                }

                // Calculate total with tax
                double tax = (subtotal - loyaltyDiscount) * 0.13;
                double total = subtotal - loyaltyDiscount + tax;

                // Output results
                Console.WriteLine();
                Console.WriteLine("Item: " + itemName);
                Console.WriteLine("Qty: " + quantity);
                Console.WriteLine("Base: $" + basePrice);
                Console.WriteLine("Loyalty Card: " + loyaltyPrint);
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Sub total: $" + (basePrice*quantity));
                Console.WriteLine("--");
                Console.WriteLine("Discounts");
                Console.WriteLine("Individual: $" + totalDiscount);
                Console.WriteLine("Loyalty: $" + loyaltyDiscount);
                Console.WriteLine("--");
                Console.WriteLine("Sub total: $" + (subtotal - loyaltyDiscount));
                Console.WriteLine("Tax: $" + tax);
                Console.WriteLine();
                Console.WriteLine("====================");
                Console.WriteLine("TOTAL: $" + total);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong");
            }

        }
    }
