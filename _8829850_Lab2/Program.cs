
class Program
  {
    static void Main(string[] args)
        {
            // Creating object of Grocery class
            Grocery product = new Grocery();


            // Taking input from user for the amount of food they are going to buy
            Console.WriteLine("Enter the amount of food purchased");
            string quantInput = Console.ReadLine();
            // Checking if the input value entered by the user is a number and not empty or a character 
            if(!int.TryParse(quantInput, out int quantInputInteger) || string.IsNullOrEmpty(quantInput)){
                Console.WriteLine("Input cannot be a character or be empty!");
                return;
            }
            // Storing input in class member
            product.productQuantity = quantInputInteger;


            // Taking input from user for the name of food they are going to buy and storing it in class member
            Console.WriteLine("Enter the name of food purchased");
            product.productPurchased = Console.ReadLine();
            // Checking if the input value entered by the user is empty or not 
            if(string.IsNullOrEmpty(product.productPurchased)){
                Console.WriteLine("Cannot be empty");
                return;
            }


            // Taking input from user for the total weight of food they are going to buy
            Console.WriteLine("Enter the weight of food purchased");
            string weightInput = Console.ReadLine();
            // Checking if the input value entered by the user is a number and not empty or a character 
            if(!double.TryParse(weightInput, out double weightInputDouble) || string.IsNullOrEmpty(weightInput)){
                Console.WriteLine("Input cannot be a character or be empty!");
                return;
            }
            // Storing input in class member
            product.totalWeight = weightInputDouble;


            // Outputting the details of food purchased by the user
            Console.WriteLine($"{product.purchasedOutput()} with average weight of {product.averageWeight()} lbs");

        }
}