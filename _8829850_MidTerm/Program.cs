// 
// Student ID: 8829850
// Section 2 
// 23-06-2023

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        store storeDetails = new store();

        List<IitemInfo> itemInventory = new List<IitemInfo>();

        IitemInfo b1 = new item();
        b1.itemName = "Laptop";
        b1.itemQuantity = 1;
        b1.itemPrice = 21;

        IitemInfo b2 = new item();
        b2.itemName = "TV";
        b2.itemQuantity = 2;
        b2.itemPrice = 22;

        IitemInfo b3 = new item();
        b3.itemName = "PS5";
        b3.itemQuantity = 3;
        b3.itemPrice = 23;

        itemInventory.Add(b1);
        itemInventory.Add(b2);
        itemInventory.Add(b3);

        bool addMoreItem = true;
        while (addMoreItem)
        {
            Console.Write("Enter book name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter book quantity: ");
            int itemQuantity = int.Parse(Console.ReadLine());

            Console.Write("Enter book price: ");
            double itemPrice = double.Parse(Console.ReadLine());

            item newItem = new item();
            newItem.itemName = itemName;
            newItem.itemQuantity = itemQuantity;
            newItem.itemPrice = itemPrice;

            itemInventory.Add(newItem);

            Console.WriteLine("Add another book? (y/n): ");
            string x = Console.ReadLine();
            if(x == "y"){
                addMoreItem = true;
            }
            else{
                addMoreItem = false;
            }
        }

        foreach(var items in itemInventory){
            Console.WriteLine(items);
        }

        Console.WriteLine("Which book to delete?, enter the number: ");
        int number = int.Parse(Console.ReadLine());

        itemInventory.RemoveAt(number);

        foreach(var items in itemInventory){
            Console.WriteLine(items);
        }

        void menuDisplay(){

            Console.Clear();
            Console.WriteLine("1. Add a new Item to the inventory");
            Console.WriteLine("2. Display all Inventory");
            Console.WriteLine("3. Delete anitem from the inventory");
            Console.WriteLine("4. Clear Inventory");
            Console.WriteLine("4. Exit the program");


            storeDetails.storeName = "E Corp";
            storeDetails.ownerFirstName = "First Name: ";
            storeDetails.ownerLastName = "Last Name: ";
            storeDetails.address = "YYY PQR ST.";

            Console.WriteLine(storeDetails.storeName);
            Console.WriteLine(storeDetails.ownerFirstName);
            Console.WriteLine(storeDetails.ownerLastName);
        }

        
    }
}