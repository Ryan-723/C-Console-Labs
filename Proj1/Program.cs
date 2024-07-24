namespace HelloWorld;

 internal class Program
 {
     static void Main(string[] args)
     {
        
        // Requesting Input of Quantity of items Purchased 
        Console.WriteLine("Enter the quantity of items purchased");
        string quantityString = Console.ReadLine();
        int itemQuantity = int.Parse(quantityString);

        // Requesting Input of Name of item Purchased 
        Console.WriteLine("Enter the name of Fruit or Vegetable purchased");
        string itemPurchased = Console.ReadLine();

        // Requesting Input of total weight of all the items Purchased 
        Console.WriteLine("Enter the total weight of items");
        string weightString = Console.ReadLine();
        float totalWeight = float.Parse(weightString);


        // Calculating the average weight
        float averageWeight = totalWeight/itemQuantity;

        // Outputting the Data
        Console.WriteLine($"I purchased {itemQuantity} {itemPurchased} with average weight of {averageWeight} lbs");
        
     }
 }